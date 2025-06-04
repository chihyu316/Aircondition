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
            LoadBatchName();
        }
        public class CBatchItem
        {
            public int CourseBatchID { get; set; }
            public string Display { get; set; }
            public decimal ActualPrice { get; set; }
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
                    cmd.CommandText = @"SELECT cb.CourseBatchID, 
                                       cb.BatchName + ' - ' + c.CourseTitle AS '課程梯次',
                                       cb.ActualPrice
                                       FROM CourseBatch cb 
                                       JOIN Course c ON cb.CourseBatchID = c.CourseBatchID
                                       ORDER BY cb.CourseBatchID";//選取資料欄

                    SqlDataReader reader = cmd.ExecuteReader();
                    this.cmSelectCourse.Items.Clear();

                  

                    while (reader.Read())
                    {   //設定CourseBatchID進去
                        CBatchItem item = new CBatchItem();
                        item.CourseBatchID = (int)reader["CourseBatchID"];
                        item.Display = reader["課程梯次"].ToString(); //設定顯示的文字
                        item.ActualPrice = Convert.ToDecimal(reader["ActualPrice"]);
                        this.cmSelectCourse.Items.Add(item);//放入combobox
                        
                        
                    }
                    if (cmSelectCourse.Items.Count > 0)
                    {
                        this.cmSelectCourse.SelectedIndex = 0;
                        
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

        private void C_confirmR_Click(object sender, EventArgs e)
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

        private void C_checkR_Click(object sender, EventArgs e)
        {
            string connstring = Settings.Default.ACConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    
                    cmd.CommandText = @"SELECT r.RegisterID AS '報名編號',
                                        m.MemberAccount AS '會員帳號',
                                        cb.BatchName AS '梯次名稱',
                                        c.CourseTitle AS '課程名稱',
                                        r.RegisterDate AS '報名日期',
                                        r.RegistrationFee AS '報名費', 
                                        r.PaymentMethod AS '付款方式',
                                        r.PaymentDate AS '付款日期',
                                        CASE r.PaymentStatus
                                        WHEN 0 THEN '未付款'
                                        WHEN 1 THEN '已付款'
                                        WHEN 2 THEN '已退款'
                                        END AS '付款狀態'
                                        FROM Registration r
                                        LEFT JOIN Member m 
                                        ON r.MemberID = m.MemberID
                                        LEFT JOIN CourseBatch cb 
                                        ON r.CourseBatchID = cb.CourseBatchID 
                                        LEFT JOIN Course c ON cb.CourseBatchID = c.CourseBatchID"; //選取資料欄

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    this.dataGridView1.DataSource = dt;
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        private void cmSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmSelectCourse.SelectedItem != null)
            {
                CBatchItem selectedCourse = (CBatchItem)cmSelectCourse.SelectedItem;

                // 在textbox顯示價格
                txtPrice.Text = selectedCourse.ActualPrice.ToString("C0");  // 15,000 格式
            }
        }
        private void LoadBatchName()
        {
            string connstring = Settings.Default.ACConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT cb.CourseBatchID,
                                    cb.BatchName + ' - ' + c.CourseTitle AS '課程梯次'
                               FROM CourseBatch cb 
                               JOIN Course c ON cb.CourseBatchID = c.CourseBatchID 
                               ORDER BY cb.CourseBatchID";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {   //設定CourseBatchID進去
                    CBatchItem item = new CBatchItem();
                    item.CourseBatchID = (int)reader["CourseBatchID"];
                    item.Display = reader["課程梯次"].ToString(); //設定顯示的文字

                    this.cmBC.Items.Add(item);//放入combobox
                }
            }
        }

        private void cmBC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBC.SelectedItem != null) //當我選取個別的課程梯次時 datagridview要顯示所選取的報名資料
            {
                CBatchItem batchItem = (CBatchItem)cmBC.SelectedItem;
                LoadBDetail(batchItem.CourseBatchID);
            }
        }
        private void LoadBDetail(int CourseBatchID)
        {
            string connstring = Settings.Default.ACConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT cb.CourseBatchID AS '梯次編號',
                             cb.BatchName AS '梯次名稱',
                             c.CourseTitle AS '課程名稱',
                             c.CourseLevel AS '課程級別',
                             cc.CategoryName AS '課程類別',
                             cm.ClassroomName AS '教室名稱',
                             cb.StartDate AS '開課日期',
                             cb.EndDate AS '結束日期',
                             cb.ClassTime AS '上課時間',
                             cb.MaxCapacity AS '最大容量',
                             cb.CurrentEnrollment AS '目前報名人數',
                             cb.ActualPrice AS '實際價格',CASE cb.BatchStatus
                                 WHEN 0 THEN '未開'
                                 WHEN 1 THEN '報名中'
                                 WHEN 2 THEN '額滿'
                                 WHEN 3 THEN '開課'
                                 WHEN 4 THEN '結束'
                                 ELSE '未知'
                             END AS '梯次狀態'
                         FROM CourseBatch cb
                         JOIN Course c ON cb.CourseBatchID = c.CourseBatchID
                         JOIN CourseCategory cc ON cb.CategoryID = cc.CategoryID
                         LEFT JOIN ClassroomManagement cm ON cb.ClassroomID = cm.ClassroomID
                         WHERE cb.CourseBatchID = @CourseBatchID";

                cmd.Parameters.AddWithValue("@CourseBatchID", CourseBatchID);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // 將資料綁定到DataGridView
                this.dataGridView1.DataSource = dt;

            }
        }
    }
}
                      
        
    

