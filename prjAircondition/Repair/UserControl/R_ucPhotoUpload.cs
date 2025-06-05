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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace prjAircondition.Repair
{
    public partial class R_ucPhotoUpload : UserControl
    {
        private string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
        private DataTable photoTable;
        private SqlDataAdapter adapter;
        private byte[] selectedPhotoBytes = null;

        public R_ucPhotoUpload()
        {
            InitializeComponent();
            this.Load += R_ucPhotoUpload_Load;

        }

        private void R_ucPhotoUpload_Load(object sender, EventArgs e)
        {
            LoadPhotoList();
        }


        private void LoadPhotoList()
        {
            string sql = "SELECT PhotoID, PhotoDescription, UploadTime FROM WorkOrderPhoto WHERE WorkOrderID IS NULL";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                adapter = new SqlDataAdapter(cmd);
                photoTable = new DataTable();
                adapter.Fill(photoTable);

                RE_dgvPhotoList.DataSource = photoTable;
                RE_lblCount.Text = $"共 {photoTable.Rows.Count} 筆";
            }
            InitPhotoHeaders();//顯示中文欄名
        }

        private void RE_btnDelete_Click(object sender, EventArgs e)
        {
            if (RE_dgvPhotoList.CurrentRow == null)
            {
                MessageBox.Show("請先選取一筆照片");
                return;
            }

            //  加入確認刪除提示
            var result = MessageBox.Show(
                "確定要刪除這筆照片嗎？\n刪除後無法復原。",
                "確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return; // 使用者按了「否」
            }

            int photoId = Convert.ToInt32(RE_dgvPhotoList.CurrentRow.Cells["PhotoID"].Value);

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM WorkOrderPhoto WHERE PhotoID = @PhotoID", conn))
            {
                cmd.Parameters.AddWithValue("@PhotoID", photoId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(" 照片已成功刪除！");
            LoadPhotoList(); // 重新整理
        }

        private void RE_dgvPhotoList_SelectionChanged(object sender, EventArgs e)
        {
            if (RE_dgvPhotoList.CurrentRow == null) return;

            int photoId = Convert.ToInt32(RE_dgvPhotoList.CurrentRow.Cells["PhotoID"].Value);
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand("SELECT PhotoData FROM WorkOrderPhoto WHERE PhotoID = @PhotoID", conn))
            {
                cmd.Parameters.AddWithValue("@PhotoID", photoId);
                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result is byte[] data)
                {
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        RE_pbPreview.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    RE_pbPreview.Image = null;
                    MessageBox.Show(" 找不到照片資料！");
                }
            }
        }

        private void RE_btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "圖片檔 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                selectedPhotoBytes = File.ReadAllBytes(filePath);

                using (MemoryStream ms = new MemoryStream(selectedPhotoBytes))
                {
                    RE_pbPreview.Image = Image.FromStream(ms);
                }
                MessageBox.Show(" 圖片已預覽，請填寫說明後按下【儲存】");
            }
            
        }

        private void RE_btnSave_Click(object sender, EventArgs e)
        {
            if (selectedPhotoBytes == null || selectedPhotoBytes.Length == 0)
            {
                MessageBox.Show(" 尚未選擇圖片，無法儲存！");
                return;
            }


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                INSERT INTO WorkOrderPhoto (WorkOrderID, PhotoData, PhotoDescription, UploadTime)
                VALUES (NULL, @PhotoData, @Description, @UploadTime)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PhotoData", selectedPhotoBytes);
                    cmd.Parameters.AddWithValue("@Description", RE_txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@UploadTime", DateTime.Now);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" 已儲存照片！");
                        selectedPhotoBytes = null;
                        RE_pbPreview.Image = null;
                        RE_txtDescription.Text = "";
                        LoadPhotoList(); // 重新載入清單
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" 儲存失敗：" + ex.Message);
                    }
                }
            }
        }
        private void InitPhotoHeaders()
        {
            var dgv = RE_dgvPhotoList;

            if (dgv.Columns.Contains("PhotoID"))
                dgv.Columns["PhotoID"].HeaderText = "照片編號";

            if (dgv.Columns.Contains("PhotoDescription"))
                dgv.Columns["PhotoDescription"].HeaderText = "照片說明";

            if (dgv.Columns.Contains("UploadTime"))
                dgv.Columns["UploadTime"].HeaderText = "上傳時間";
        }
    }

}
