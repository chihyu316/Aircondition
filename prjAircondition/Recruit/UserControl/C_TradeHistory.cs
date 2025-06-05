using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjAircondition.Properties;

namespace prjAircondition
{
    public partial class C_TradeHistory : UserControl
    {

        public C_TradeHistory()
        {
            InitializeComponent();
            LoadTocmbPaymethod();
            this.txtAccount.TextChanged += txtAccount_TextChanged;

        }
        private void LoadTocmbPaymethod()
        {
            List<string> Paymethods = new List<string>() { "轉帳", "信用卡" };

            foreach (string paymethod in Paymethods)
            {
                this.cmbPaymethod.Items.Add(paymethod);
            }
        }

        private int?currentRegistrationID = null;
        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();  //輸入帳號，用Trim扣掉前後空白
                                                      //string payment = txtPay.Text;      //輸出報名金額

            if (string.IsNullOrEmpty(account)) //會員的帳號是空的或空白時
            {
                txtPay.Text = " ";
                currentRegistrationID = -1;
                return;
            }
            string connstring = Settings.Default.ACConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT TOP 1 r.RegisterID, r.RegistrationFee
                    FROM Registration r
                    INNER JOIN Member m ON r.MemberID = m.MemberID
                    WHERE m.MemberAccount = @account AND r.PaymentStatus = 0
                    ORDER BY r.RegisterDate DESC";

                    cmd.Parameters.AddWithValue("@account", account);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        currentRegistrationID = Convert.ToInt32(reader["RegisterID"]);
                        decimal payment = Convert.ToDecimal(reader["RegistrationFee"]);
                        txtPay.Text = payment.ToString("C0");
                    }
                    else
                    {
                        currentRegistrationID = null;
                        txtPay.Text = "";
                        MessageBox.Show("查無未付款紀錄");
                    }
                }
             }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void C_confirmPay_Click(object sender, EventArgs e)
        {
            string account = this.txtAccount.Text.Trim();
            
            if(cmbPaymethod.SelectedItem == null) 
            { MessageBox.Show("請選擇付款方式"); return; }
            string cmbpaymethod = this.cmbPaymethod.SelectedItem.ToString();
            
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(cmbpaymethod)) //如果會員帳號跟付款方式都是空白的話
            {
                MessageBox.Show("請輸入帳號並選擇付款方式");
                return;
            }
            string connstring = Settings.Default.ACConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"UPDATE Registration
                         SET PaymentMethod = @method,
                         PaymentDate = @date,
                         PaymentStatus = 1
                         WHERE RegisterID = @id";

                cmd.Parameters.AddWithValue("@method", cmbpaymethod);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", currentRegistrationID);

                int result = cmd.ExecuteNonQuery();

                if(result>0)
                {
                    MessageBox.Show("付款成功");
                }
                
            }   
        }

        private void Record_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            if (string.IsNullOrEmpty(account)) 
            {
                MessageBox.Show("請輸入會員帳號");
                return;
            }
            LoadPaymentHistory(account);
        }

        private void LoadPaymentHistory(string memberAccount)
        {

            string connstring = Settings.Default.ACConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [RegisterID] as 報名編號,
                                    [RegistrationFee] as 報名費用,
                                    [PaymentMethod] as 付款方式,
                                    [PaymentDate] as 付款日期
                                    FROM Registration r
                                    INNER JOIN Member m ON r.MemberID = m.MemberID
                                    WHERE m.MemberAccount = @account AND r.PaymentStatus = 1 ";
                cmd.Parameters.AddWithValue("@account", memberAccount);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
        }
    }
}
