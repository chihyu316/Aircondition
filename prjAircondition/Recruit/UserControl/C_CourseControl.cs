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
using prjAircondition.Recruit.DateSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjAircondition.Recruit
{
    public partial class C_CourseControl : UserControl
    {
        string s1 = " ";
        public C_CourseControl()
        {
            InitializeComponent();
            CourseControl_Load();

            this.bindingSource1.DataSource = this.c_RecruitDataSet1.Course;
            this.dataGridView1.DataSource = this.bindingSource1;

        }

        private void CourseControl_Load()
        {

            //Connected
            //1.SqlConnection
            //2.SqlCommand
            //3.SqlDataReader
            //4.UI - ListBox
            string connstring = Settings.Default.ACConnectionString;
            try
            {
                SqlConnection conn;
                using (conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = $"select CategoryName from CourseCategory";//選取資料欄

                    SqlDataReader reader = cmd.ExecuteReader();
                    this.comboBox1.Items.Clear();
                    this.comboBox1.Items.Add("所有課程");
                    while (reader.Read())
                    {
                        this.comboBox1.Items.Add(reader["CategoryName"]);
                    }
                    //this.comboBox1.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connstring = Settings.Default.ACConnectionString;

            SqlConnection conn;
            using (conn = new SqlConnection(connstring))

            {
                conn.Open();

                string sql;


                if (this.comboBox1.Text == "所有課程")
                {
                    sql = $"select 編號=CourseID,課程級別=courselevel,課程名稱=coursetitle,開課日期=StartDate,結束日期=EndDate,BatchStatus,CourseStatus " +
                         $"from course join CourseBatch on CourseBatch.CourseBatchID = Course.CourseBatchID " +
                        $"join CourseCategory on Coursecategory.categoryID = CourseBatch.categoryID";//選取資料欄
                }
                else
                {
                    sql = $"select 編號=CourseID,課程級別=courselevel,課程名稱=coursetitle,開課日期=StartDate,結束日期=EndDate,BatchStatus,CourseStatus " +
                        $"from course join CourseBatch on CourseBatch.CourseBatchID = Course.CourseBatchID " +
                        $"join CourseCategory on coursecategory.categoryID = CourseBatch.categoryID " +
                        $"where CategoryName ='{this.comboBox1.Text}'";//選取資料欄

                }
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dt.Columns.Add("梯次狀態", typeof(string));
                dt.Columns.Add("課程狀態", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    row["梯次狀態"] = GetBStext((byte)row["BatchStatus"]);
                    row["課程狀態"] = GetCStatus((byte)row["CourseStatus"]);
                }

                this.dataGridView1.DataSource = dt;


                this.dataGridView1.ReadOnly = false;

                // 設定哪些欄位可以編輯（可選）
                this.dataGridView1.Columns["編號"].ReadOnly = true;  // 編號不能改
                this.dataGridView1.Columns["BatchStatus"].Visible = false;  // 隱藏欄位不能改
                this.dataGridView1.Columns["CourseStatus"].Visible = false;  // 隱藏欄位不能改
                this.dataGridView1.Columns["梯次狀態"].Visible = true;          // 顯示中文
                this.dataGridView1.Columns["課程狀態"].Visible = true;          // 顯示中文
            }
        }

        private void dataGridView1_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = (int)this.dataGridView1.CurrentRow.Cells[1].Value;
            if (e.ColumnIndex == 0)
            {
                C_FrmDtail detail = new C_FrmDtail();
                detail.CategoryID = Id;
                detail.CourseBatchID = Id;
                detail.CourseID = Id;
                detail.Show();
            }
        }
        private string GetBStext(byte status)
        {
            switch (status)
            {
                case 0: return "未開";
                case 1: return "報名中";
                case 2: return "額滿";
                case 3: return "開課";
                case 4: return "結束";
                default: return "未知";
            }
        }
        private string GetCStatus(byte status)
        {
            switch (status)
            {
                case 0: return "啟用";
                case 1: return "結束";
                default: return "未知";
            }
        }

        private void C_btnAddCourse_click(object sender, EventArgs e)
        {
            C_FrmAddnewC addnewC = new C_FrmAddnewC();
            addnewC.ShowDialog();
            if (addnewC.DialogResult == DialogResult.OK)
            {
                cmCourse_SelectedIndexChanged(this.comboBox1, EventArgs.Empty);


            }
        }

        private void C_btnalterC_click(object sender, EventArgs e) //修改課程
        {
            MessageBox.Show("現在可以修改表格了！雙擊要修改的欄位即可");
            this.dataGridView1.ReadOnly = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string connstring = Settings.Default.ACConnectionString;
            DataTable dt = (DataTable)this.dataGridView1.DataSource;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    // 只處理有變更的行
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            int courseID = Convert.ToInt32(row["編號"]);
                            string courseLevel = row["課程級別"].ToString();
                            string courseTitle = row["課程名稱"].ToString();
                            DateTime startDate = Convert.ToDateTime(row["開課日期"]);
                            DateTime endDate = Convert.ToDateTime(row["結束日期"]);

                            // 更新資料庫
                            string sql = @"UPDATE Course SET CourseLevel = @CourseLevel, CourseTitle = @CourseTitle
                              WHERE CourseID = @CourseID;
                              
                              UPDATE CourseBatch SET StartDate = @StartDate, EndDate = @EndDate
                              WHERE CourseBatchID = (SELECT CourseBatchID FROM Course WHERE CourseID = @CourseID)";

                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@CourseID", courseID);
                                cmd.Parameters.AddWithValue("@CourseLevel", courseLevel);
                                cmd.Parameters.AddWithValue("@CourseTitle", courseTitle);
                                cmd.Parameters.AddWithValue("@StartDate", startDate);
                                cmd.Parameters.AddWithValue("@EndDate", endDate);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("儲存成功！");
                this.dataGridView1.ReadOnly = true;

                // 接受變更
                dt.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                s1 = textBox1.Text;
            }
            else
            {
                s1 = "";
            }
        }

        private void C_btnSearch_Click(object sender, EventArgs e)
        {
            this.courseTableAdapter1.FillByCoursetitle(this.c_RecruitDataSet1.Course, s1);
            this.dataGridView1.DataSource = this.c_RecruitDataSet1.Course;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("請先選擇要刪除的課程");
                return;
            }

            DataGridViewRow currentRow = this.dataGridView1.CurrentRow;

            // 取得課程ID和課程名稱
            int courseID = Convert.ToInt32(currentRow.Cells["編號"].Value);
            string courseName = currentRow.Cells["課程名稱"].Value.ToString();

            if (MessageBox.Show($"確定要刪除課程「{courseName}」嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // 刪除
                string connstring = Settings.Default.ACConnectionString;
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    string sql = "DELETE FROM Course WHERE CourseID = @CourseID";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", courseID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("刪除成功！");
                            cmCourse_SelectedIndexChanged(this.comboBox1, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("刪除失敗：找不到該課程");
                        }
                    }
                }


            }
        }
    }
}