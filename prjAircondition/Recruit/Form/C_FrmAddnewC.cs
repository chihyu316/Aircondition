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
using prjAircondition.Properties;

namespace prjAircondition
{
    public partial class C_FrmAddnewC : Form
    {
        public C_FrmAddnewC()
        {
            InitializeComponent();
            LoadToCourseBatchComboBox();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (this.courseBindingSource.Current is DataRowView rowView)
            {
                DataRow row = rowView.Row;
                if (row["CourseStatus"] == DBNull.Value || row["CourseStatus"] == null)
                {
                    row["CourseStatus"] = 0;
                }
            }
            if (cmbBatch.SelectedIndex >= 0 && cmbBatch.SelectedValue != null)
            {
                ((DataRowView)this.courseBindingSource.Current)["CourseBatchID"] = cmbBatch.SelectedValue;
            }
            else
            {
                ((DataRowView)this.courseBindingSource.Current)["CourseBatchID"] = DBNull.Value;
                MessageBox.Show("請選擇課程梯次！");
                return;
            }

            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.c_RecruitDataSet);

            MessageBox.Show("儲存成功");
            this.Close();
        }

        private void C_FrmAddnewC_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'c_RecruitDataSet.Course' 資料表。您可以視需要進行移動或移除。
            this.courseTableAdapter.Fill(this.c_RecruitDataSet.Course);
            this.courseBindingSource.AddNew();
            LoadTocmC();
        }
        private void LoadTocmC()
        {
            List<string> levels = new List<string> { "初級", "中級", "高級" };

            this.courseLevelComboBox.Items.Clear();
            this.courseLevelComboBox.Items.Add("選擇級別");

            foreach (string level in levels)
            {
                this.courseLevelComboBox.Items.Add(level);
            }
            this.courseLevelComboBox.SelectedIndex = 0;
        }

        private void LoadToCourseBatchComboBox()
        {
            string connstring = Settings.Default.ACConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string sql = @"SELECT 
                CourseBatchID,
                BatchName + '｜' +
                ISNULL(ClassTime, '未設定') + '｜' +
                FORMAT(StartDate, 'yyyy/MM/dd') AS DisplayName
                 FROM CourseBatch
                ORDER BY StartDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // 綁定 ComboBox
                cmbBatch.DataSource = dt;
                cmbBatch.DisplayMember = "DisplayName";     // 顯示名稱
                cmbBatch.ValueMember = "CourseBatchID";     // 真正要存的值
                cmbBatch.SelectedIndex = -1; // 預設不選
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            { 
                MessageBox.Show("ok" + this.openFileDialog1.FileName);
                this.photosPictureBox.Image= Image.FromFile(this.openFileDialog1.FileName);               


            }
        }


    }
} 

