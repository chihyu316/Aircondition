using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Shop
{
    public partial class S_UcMateral : UserControl
    {
        private SqlDataAdapter adapter;
        private System.Data.DataSet dataSet;
        private BindingSource bindingSource;
        private SqlCommandBuilder commandBuilder;
        private string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True";
        public S_UcMateral()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        private void UcMaterial_Load(object sender, EventArgs e)
        {
            LoadMaterial();
        }
        private void InitializeCustomComponents()
        {
            btnShowAll.Click += (s, e) => LoadMaterial();
            txtMaterial.TextChanged += (s, e) => LoadMaterial(txtMaterial.Text.Trim());
            //btnAddNew.Click += btnAddNew_Click;
            btnSaveChanges.Click += btnSaveChanges_Click;
            btnDelete.Click += btnDelete_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            //dataGridView1.CellClick += dataGridView1_CellClick;
            picMaterial.SizeMode = PictureBoxSizeMode.Zoom;//顯示圖片用 Zoom 模式
        }
        private void LoadMaterial(string keyword = "")
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Material WHERE MaterialName LIKE @kw";
                adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                commandBuilder = new SqlCommandBuilder(adapter);

                dataSet = new System.Data.DataSet();
                adapter.Fill(dataSet, "Material");

                bindingSource = new BindingSource(dataSet, "Material");
                dataGridView1.DataSource = bindingSource;

                

                if (dataGridView1.Columns.Contains("CreatedTime"))
                    dataGridView1.Columns["CreatedTime"].ReadOnly = true;
                if (dataGridView1.Columns.Contains("MaterialID"))
                    dataGridView1.Columns["MaterialID"].ReadOnly = true;

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //資料還是存在、可讀可寫，但不顯示那一欄。
                if (dataGridView1.Columns.Contains("SmallImage"))
                    dataGridView1.Columns["SmallImage"].Visible = false;

                if (dataGridView1.Columns.Contains("MaterialID")) dataGridView1.Columns["MaterialID"].HeaderText = "材料編號";
                if (dataGridView1.Columns.Contains("MaterialName")) dataGridView1.Columns["MaterialName"].HeaderText = "材料名稱";
                if (dataGridView1.Columns.Contains("Price")) dataGridView1.Columns["Price"].HeaderText = "價格";
                if (dataGridView1.Columns.Contains("Stock")) dataGridView1.Columns["Stock"].HeaderText = "庫存";
                if (dataGridView1.Columns.Contains("IsAvailable")) dataGridView1.Columns["IsAvailable"].HeaderText = "是否啟用";
                if (dataGridView1.Columns.Contains("CreatedTime")) dataGridView1.Columns["CreatedTime"].HeaderText = "建立時間";
                if (dataGridView1.Columns.Contains("CreatedBy")) dataGridView1.Columns["CreatedBy"].HeaderText = "建立者";
                if (dataGridView1.Columns.Contains("UpdatedTime")) dataGridView1.Columns["UpdatedTime"].HeaderText = "更新時間";
                if (dataGridView1.Columns.Contains("UpdatedBy")) dataGridView1.Columns["UpdatedBy"].HeaderText = "更新者";
                if (dataGridView1.Columns.Contains("SmallImage")) dataGridView1.Columns["SmallImage"].HeaderText = "圖片資料";

                dataGridView1.Columns["Price"].DefaultCellStyle.Format = "N0";//N0 表示「不顯示小數點」僅影響畫面，不影響資料庫

            }
            // ✅ 若尚未加入圖片按鈕欄位就加
            if (!dataGridView1.Columns.Contains("圖片"))
            {
                DataGridViewButtonColumn btnImage = new DataGridViewButtonColumn();
                btnImage.Name = "圖片";
                btnImage.HeaderText = "圖片";
                btnImage.Text = "🖼 編輯圖片";
                btnImage.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnImage);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bindingSource.EndEdit();

                adapter = new SqlDataAdapter("SELECT * FROM Material", connStr);
                commandBuilder = new SqlCommandBuilder(adapter);

                bool hasNewRow = false;

                foreach (DataRow row in dataSet.Tables["Material"].Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        string name = row["MaterialName"]?.ToString().Trim();
                        string priceText = row["Price"]?.ToString().Trim();
                        string stockText = row["Stock"]?.ToString().Trim();

                        if (string.IsNullOrEmpty(name) ||
                            !decimal.TryParse(priceText, out decimal price) || price < 0 ||
                            !int.TryParse(stockText, out int stock) || stock < 0)
                        {
                            MessageBox.Show("請確認欄位是否完整與正確（名稱、價格、庫存）", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        row["CreatedTime"] = DateTime.Now;
                        row["CreatedBy"] = "Adminator";
                        row["IsAvailable"] = true;
                        hasNewRow = true;
                    }
                }

                if (!hasNewRow)
                {
                    MessageBox.Show("請先在表格中輸入一筆新資料再點選新增。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                adapter.Update(dataSet, "Material");
                MessageBox.Show("新增成功！");
                LoadMaterial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗: " + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM Material", connStr);
                commandBuilder = new SqlCommandBuilder(adapter);
                this.Validate();
                bindingSource.EndEdit();

                bool isModified = false;
                foreach (DataRow row in dataSet.Tables["Material"].Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        row["UpdatedTime"] = DateTime.Now;
                        row["UpdatedBy"] = "Adminator";
                        isModified = true;
                    }
                }

                // 移除 adapter 重建，改用現有 adapter
                // adapter = new SqlDataAdapter("SELECT * FROM Material", connStr);
                // commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, "Material");
                if (isModified)
                    MessageBox.Show("修改成功！");
                LoadMaterial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("請選擇一筆要刪除的資料！");
                return;
            }

            var confirm = MessageBox.Show("確定要刪除這筆資料嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaterialID"].Value);
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Material WHERE MaterialID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "刪除成功！" : "刪除失敗！");
                    LoadMaterial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗：" + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.Columns.Contains("MaterialName"))
            {
                string name = dataGridView1.CurrentRow.Cells["MaterialName"].Value?.ToString();
                lblSelectedMaterial.Text = "目前選取: " + name;

                if (dataGridView1.Columns.Contains("SmallImage"))
                {
                    object imgData = dataGridView1.CurrentRow.Cells["SmallImage"].Value;
                    if (imgData != DBNull.Value && imgData is byte[] bytes)
                    {
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            picMaterial.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picMaterial.Image = null;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            // ✅ 處理圖片欄位
            if (colName == "圖片")
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                ShowImageDialog(selectedRow); // ✅ 彈出圖片視窗
            }

            // ✅ 處理會員細節（如果還需要）
            else if (colName == "MemberID" || colName == "MemberAccount")
            {
                string memberId = dataGridView1.Rows[e.RowIndex].Cells["MemberID"].Value.ToString();
                FormOrderDetails frm = new FormOrderDetails(memberId);
                frm.ShowDialog();
            }
        }
        
        //ShowImageDialog() 方法
        private void ShowImageDialog(DataGridViewRow row)
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "圖片管理";
                dialog.Size = new Size(400, 400);

                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Dock = DockStyle.Fill;

                if (row.Cells["SmallImage"].Value is byte[] bytes)
                {
                    using (MemoryStream ms = new MemoryStream(bytes))
                        pb.Image = Image.FromStream(ms);
                }

                Button btnUpload = new Button { Text = "上傳圖片", Dock = DockStyle.Bottom };
                Button btnRemove = new Button { Text = "移除圖片", Dock = DockStyle.Bottom };

                btnUpload.Click += (s, e) =>
                {
                    using (OpenFileDialog ofd = new OpenFileDialog())
                    {
                        ofd.Filter = "圖片檔案 (*.jpg;*.png)|*.jpg;*.png";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            Image img = Image.FromFile(ofd.FileName);
                            pb.Image = img;

                            using (MemoryStream ms = new MemoryStream())
                            {
                                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                row.Cells["SmallImage"].Value = ms.ToArray(); // ✅ 寫入欄位
                            }
                        }
                    }
                };

                btnRemove.Click += (s, e) =>
                {
                    row.Cells["SmallImage"].Value = DBNull.Value;
                    pb.Image = null;
                };

                dialog.Controls.Add(pb);
                dialog.Controls.Add(btnRemove);
                dialog.Controls.Add(btnUpload);
                dialog.ShowDialog();
            }
        }
    }
}
