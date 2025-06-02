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

namespace prjAircondition.Recruit
{
    public partial class C_RegisterControl : UserControl
    {
        public C_RegisterControl()
        {
            InitializeComponent();
            LoadToCombobox();
        }
        public class CBatchItem
        {
            public int CourseBatchID { get; set; }
            public string Display { get; set; }

            public override string ToString() //用override重新定義tostring
            {
                return Display;
            }
        }
        private void LoadToCombobox()
        {
            //Connected
            //1.SqlConnection
            //2.SqlCommand
            //3.SqlDataReader
            //4.UI - ListBox
            string connstring = Settings.Default.ACConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = $"select cb.CourseBatchID, cb.BatchName + ' - ' + c.CourseTitle AS '課程梯次' " +
                        $"from CourseBatch cb " +
                        $"join course c " +
                        $"on cb.CourseBatchID = c.CourseBatchID ";//選取資料欄

                    SqlDataReader reader = cmd.ExecuteReader();
                    this.cmSelectCourse.Items.Clear();

                    //listBox1.Items.Add("載入課程");

                    while (reader.Read())
                    {   //設定CourseBatchID進去
                        CBatchItem item = new CBatchItem();
                        item.CourseBatchID = (int)reader["CourseBatchID"];
                        item.Display = reader["課程梯次"].ToString(); //設定顯示的文字
                        this.cmSelectCourse.Items.Add(item);//放入combobox

                        //listBox1.Items.Add($"載入{item.CourseBatchID},文字{item.Display}");
                    }
                    if (cmSelectCourse.Items.Count > 0)
                    {
                        this.cmSelectCourse.SelectedIndex = 0;
                        //this.listBox1.Items.Add($"共載入{cmSelectCourse.Items.Count}個課程");
                    }
                    else
                    {
                        listBox1.Items.Add("沒有課程");
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入課程失敗：{ex.Message}");
                listBox1.Items.Add($"錯誤：{ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtMAccount.Text))
            {
                MessageBox.Show("請填寫會員帳號");
                return;
            }
            if (cmSelectCourse.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇課程");
                return;
            }
            CBatchItem selectedC = (CBatchItem)cmSelectCourse.SelectedItem;
            listBox1.Items.Add("===報名資訊===");
            listBox1.Items.Add($"會員帳號{txtMAccount.Text}");
            listBox1.Items.Add($"課程ID{selectedC.CourseBatchID}");
            listBox1.Items.Add($"課程名稱{selectedC.Display}");
            listBox1.Items.Add($"報名時間{DateTime.Now:MM/dd HH:mm}");

            //接下來要確定帳號是有在資料庫內的
            string Account = txtMAccount.Text;
            string connstring = Settings.Default.ACConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select MemberID from Member where MemberAccount = @account";

                    //芳芳老師說要用SqlParameter提高安全
                    cmd.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = Account;

                    SqlDataReader reader = cmd.ExecuteReader();

                    //確認有沒有找到會員資料
                    if (reader.Read())
                    {
                        int memberID = (int)reader["MemberID"];
                        MessageBox.Show($"找到會員{memberID}");
                        reader.Close();

                        //檢查有沒有重複報名
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = conn;

                        //用sql的函數去看有沒有超過1筆以上
                        cmd2.CommandText = "select count(*) from Registration where MemberID = @memberID and CourseBatchID = @coursebatchID";
                        cmd2.Parameters.Add("@memberID", SqlDbType.Int).Value = memberID;
                        cmd2.Parameters.Add("@coursebatchID", SqlDbType.Int).Value = selectedC.CourseBatchID;

                        int doublecount = (int)cmd2.ExecuteScalar();
                        if (doublecount > 0)
                        {
                            MessageBox.Show("重複報名");
                        }
                        else
                        {
                            SqlCommand cmd3 = new SqlCommand();
                            cmd3.Connection = conn;
                            cmd3.CommandText = $"insert into Registration(MemberID,CourseBatchID,RegisterDate,PaymentStatus) values (@memberID,@coursebatchID,@regdate,0)";
                            cmd3.Parameters.Add("@memberID", SqlDbType.Int).Value = memberID;
                            cmd3.Parameters.Add("@coursebatchID", SqlDbType.Int).Value = selectedC.CourseBatchID;
                            cmd3.Parameters.Add("@regdate", SqlDbType.DateTime).Value = DateTime.Now;   //現在的報名時間

                            int insertresult = cmd3.ExecuteNonQuery();

                            if (insertresult > 0)
                            {
                                MessageBox.Show("報名成功");

                            }
                            else
                            {
                                MessageBox.Show("報名失敗");
                            }
                        }
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
    }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
                      
        
    

