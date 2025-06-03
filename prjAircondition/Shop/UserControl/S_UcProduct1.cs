using prjAircondition.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Shop
{
    public partial class S_UcProduct1 : UserControl
    {
        // ✅ 全域變數（宣告在類別內，但不在任何方法裡）
        private SqlDataAdapter adapter;
        private System.Data.DataSet dataSet;
        private BindingSource bindingSource;
        private SqlCommandBuilder commandBuilder;
        private DataTable vendorTable;
        public S_UcProduct1()
        {
            InitializeComponent();
        }

        private void S_UcProduct1_Load(object sender, EventArgs e)
        {
            LoadVendorList();
            LoadCoolingProduct(); // ✅ 初始化 adapter, dataSet, bindingSource
            this.dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
        }

        /// <summary>
        /// 從資料庫載入廠商資料至 vendorTable
        /// </summary>
        private void LoadVendorList()
        {
            // 補充限制使用者不能改 CreatedTime：
            if (dataGridView1.Columns.Contains("CreatedTime"))
                dataGridView1.Columns["CreatedTime"].ReadOnly = true;
            //設定欄位唯讀
            if (dataGridView1.Columns.Contains("UpdatedTime"))
                dataGridView1.Columns["UpdatedTime"].ReadOnly = true;

            vendorTable = new DataTable();
            string connString = Settings.Default.ACConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "SELECT VendorID, VendorName FROM Vendor";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(vendorTable);
            }

            BindComboBox(vendorTable);
        }

        private void BindComboBox(DataTable data)
        {
            comboVendor.DataSource = null;
            comboVendor.Items.Clear();

            if (data.Rows.Count > 0)
            {
                comboVendor.DataSource = data;
                comboVendor.DisplayMember = "VendorName";
                comboVendor.ValueMember = "VendorID";
                comboVendor.SelectedIndex = -1;
            }
            else
            {
                comboVendor.Text = "查無結果";
                dataGridView1.DataSource = null; // ✅ 顯示空表格
            }
        }

        private void LoadCoolingProduct()
        {
            string connString = Settings.Default.ACConnectionString;
            string sql = "SELECT * FROM CoolingProduct";

            adapter = new SqlDataAdapter(sql, connString);
            commandBuilder = new SqlCommandBuilder(adapter);

            dataSet = new System.Data.DataSet();
            adapter.Fill(dataSet, "CoolingProduct");

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables["CoolingProduct"];
            dataGridView1.DataSource = bindingSource;

            // ✅ 設定不能修改主鍵
            if (dataGridView1.Columns.Contains("CoolingProductID"))
                dataGridView1.Columns["CoolingProductID"].ReadOnly = true;

            // ✅ 加入選取模式設定
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 一次選整行
            dataGridView1.MultiSelect = false; // 限制只能選一筆

            // ✅ 額外建議（欄位寬度自動）
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadProductByVendor(int vendorId)
        {
            string connString = Settings.Default.ACConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = @"
                           SELECT CoolingProductID, CoolingName, Price, Stock, ProductStatus
                           FROM CoolingProduct
                           WHERE VendorID = @VendorID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@VendorID", vendorId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    this.Validate();
                    bindingSource.EndEdit();

                    foreach (DataRow row in dataSet.Tables["CoolingProduct"].Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                        {
                            row["CreatedTime"] = DateTime.Now;
                        }
                    }

                    adapter.Update(dataSet, "CoolingProduct");

                    MessageBox.Show("新增儲存成功！");
                    LoadCoolingProduct();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存失敗：" + ex.Message);
                }
            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bindingSource.EndEdit();

                foreach (DataRow row in dataSet.Tables["CoolingProduct"].Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        row["UpdatedTime"] = DateTime.Now;
                    }
                }

                adapter.Update(dataSet, "CoolingProduct");
                MessageBox.Show("修改儲存成功！");
                LoadCoolingProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失敗：" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("請選擇一筆要刪除的資料！");
                return;
            }

            // 取得選取列的主鍵 ID
            var result = MessageBox.Show("確定要刪除這筆資料嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CoolingProductID"].Value);
                string connString = Settings.Default.ACConnectionString;
                string sql = "DELETE FROM CoolingProduct WHERE CoolingProductID = @ID";

                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(rows > 0 ? "刪除成功！" : "刪除失敗！");
                    LoadCoolingProduct(); // 重新載入資料
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗：" + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.ACConnectionString;
            string sql = "SELECT * FROM CoolingProduct";

            adapter = new SqlDataAdapter(sql, connString);
            commandBuilder = new SqlCommandBuilder(adapter);

            dataSet = new System.Data.DataSet();
            adapter.Fill(dataSet, "CoolingProduct");

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables["CoolingProduct"];

            dataGridView1.DataSource = bindingSource;

            // 設定欄位是否可編輯
            if (dataGridView1.Columns.Contains("CoolingProductID"))
                dataGridView1.Columns["CoolingProductID"].ReadOnly = true;

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVendor.SelectedValue != null && int.TryParse(comboVendor.SelectedValue.ToString(), out int vendorId))
            {
                LoadProductByVendor(vendorId);
            }
        }

        private void txtSearchVendor_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchVendor.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // 還原全部
                BindComboBox(vendorTable);
                dataGridView1.DataSource = null;
                return;
            }

            // 搜尋廠商名稱
            DataView dv = new DataView(vendorTable);
            dv.RowFilter = $"VendorName LIKE '%{keyword}%'";

            if (dv.Count > 0)
            {
                DataTable filteredVendor = dv.ToTable();
                BindComboBox(filteredVendor);

                // 顯示第一筆符合廠商的商品
                if (int.TryParse(filteredVendor.Rows[0]["VendorID"].ToString(), out int vendorId))
                {
                    LoadProductByVendor(vendorId); // ✅ 查商品
                }
            }
            else
            {
                // 查無此廠商
                comboVendor.DataSource = null;
                comboVendor.Items.Clear();
                comboVendor.Text = "查無結果";

                // 顯示「查無此資料」到 dataGridView1
                DataTable emptyTable = new DataTable();
                emptyTable.Columns.Add("訊息");
                emptyTable.Rows.Add("查無此資料");

                dataGridView1.DataSource = emptyTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Category")
                {
                    int val;
                    if (int.TryParse(e.Value?.ToString(), out val))
                    {
                        if (val == 0) e.Value = "家用";
                        else if (val == 1) e.Value = "商用";
                        else e.Value = "其他";
                    }
                }

                if (columnName == "Type")
                {
                    int val;
                    if (int.TryParse(e.Value?.ToString(), out val))
                    {
                        if (val == 0) e.Value = "定頻";
                        else if (val == 1) e.Value = "變頻";
                        else e.Value = "其他";
                    }
                }

                if (columnName == "ProductStatus")
                {
                    int val;
                    if (int.TryParse(e.Value?.ToString(), out val))
                    {
                        e.Value = val == 0 ? "下架" : "上架";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("CellFormatting 錯誤：" + ex.Message);
            }
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.IsCurrentRowDirty)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                string productName = row.Cells["CoolingName"].Value?.ToString().Trim();
                string priceText = row.Cells["Price"].Value?.ToString().Trim();
                string stockText = row.Cells["Stock"].Value?.ToString().Trim();

                // 商品名不能為空
                if (string.IsNullOrEmpty(productName))
                {
                    row.ErrorText = "請修正此列錯誤資料";
                    MessageBox.Show("商品名稱不能為空！");
                    e.Cancel = true;
                    return;
                }

                // 價格必須為有效的 decimal，且 >= 0
                if (!decimal.TryParse(priceText, out decimal price) || price < 0)
                {
                    row.ErrorText = "請修正此列錯誤資料";
                    MessageBox.Show("價格必須是大於等於 0 的數值！");
                    e.Cancel = true;
                    return;
                }

                //  庫存驗證（可選）
                if (!int.TryParse(stockText, out int stock) || stock < 0)
                {
                    row.ErrorText = "請修正此列錯誤資料";
                    MessageBox.Show("庫存必須是大於等於 0 的整數！");
                    e.Cancel = true;
                    return;
                }

                // ✅ 驗證成功 → 清除錯誤提示
                row.ErrorText = string.Empty;
            }
        }
    }
}
