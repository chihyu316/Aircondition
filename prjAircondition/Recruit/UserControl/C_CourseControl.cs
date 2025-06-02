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

namespace prjAircondition.Recruit
{
    public partial class C_CourseControl : UserControl
    {
        public C_CourseControl()
        {
            InitializeComponent();
            CourseControl_Load();
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
                    this.comboBox1.SelectedIndex = 0;
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
                this.dataGridView1.Columns["梯次狀態"].Visible = false;
                this.dataGridView1.Columns["課程狀態"].Visible = false;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void C_btnAddCourse(object sender, EventArgs e)
        {
            
        }
    }
}
