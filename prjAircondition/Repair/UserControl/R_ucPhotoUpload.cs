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
        private int currentWorkOrderID = 1; // 可改成傳入的 ID
        private DataTable photoTable;
        private SqlDataAdapter adapter;
        public R_ucPhotoUpload()
        {
            InitializeComponent();
            RE_btnUpload.Click += btnUpload_Click;
            RE_btnDelete.Click += RE_btnDelete_Click;
            RE_dgvPhotoList.SelectionChanged += RE_dgvPhotoList_SelectionChanged;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "圖片檔 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                byte[] photoBytes = File.ReadAllBytes(filePath);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = @"
                INSERT INTO WorkOrderPhoto (WorkOrderID, PhotoData, PhotoDescription, UploadTime)
                VALUES (@WorkOrderID, @PhotoData, @Description, @UploadTime)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@WorkOrderID", currentWorkOrderID);
                        cmd.Parameters.AddWithValue("@PhotoData", photoBytes);
                        cmd.Parameters.AddWithValue("@Description", RE_txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@UploadTime", DateTime.Now);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(" 照片已成功上傳！");
                            LoadPhotoList(); // 重新整理
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("上傳失敗：" + ex.Message);
                        }
                    }
                }
            }
        }


        private void LoadPhotos()
        {
            string sql = "SELECT PhotoID, PhotoDescription, UploadTime FROM WorkOrderPhoto WHERE WorkOrderID = @WorkOrderID";
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@WorkOrderID", currentWorkOrderID);
                adapter = new SqlDataAdapter(cmd);
                photoTable = new DataTable();
                adapter.Fill(photoTable);
                RE_dgvPhotoList.DataSource = photoTable;
                RE_lblCount.Text = $"共 {photoTable.Rows.Count} 筆";
            }
        }


        private void LoadPhotoList()
        {
            string sql = "SELECT PhotoID, PhotoDescription, UploadTime FROM WorkOrderPhoto WHERE WorkOrderID = @WorkOrderID";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@WorkOrderID", currentWorkOrderID);
                adapter = new SqlDataAdapter(cmd);
                photoTable = new DataTable();
                adapter.Fill(photoTable);

                RE_dgvPhotoList.DataSource = photoTable;
                RE_lblCount.Text = $"共 {photoTable.Rows.Count} 筆";
            }
        }



        private void R_ucPhotoUpload_Load(object sender, EventArgs e)
        {
            LoadPhotos();
        }

        private void RE_btnDelete_Click(object sender, EventArgs e)
        {
            if (RE_dgvPhotoList.CurrentRow == null)
            {
                MessageBox.Show("請先選取一筆照片");
                return;
            }

            int photoId = Convert.ToInt32(RE_dgvPhotoList.CurrentRow.Cells["PhotoID"].Value);

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM WorkOrderPhoto WHERE PhotoID = @PhotoID", conn))
            {
                cmd.Parameters.AddWithValue("@PhotoID", photoId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("✅ 照片已刪除");
            LoadPhotos();
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
                byte[] data = cmd.ExecuteScalar() as byte[];
                if (data != null)
                {
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        RE_pbPreview.Image = Image.FromStream(ms);
                    }
                }
            }
        }
    }
}
