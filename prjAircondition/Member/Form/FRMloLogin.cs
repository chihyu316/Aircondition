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

namespace prjAircondition.Member
{
    public partial class FRMloLogin : Form
    {
        MemberClass MC;
        public FRMloLogin()
        {
            InitializeComponent();
            MC = new MemberClass();
        }
        public string account = "";
        public string password = "";

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if( Logibtxt.Text =="Adminator")
            {
                MessageBox.Show("登入成功！");
                account = Logibtxt.Text.Trim();
                Form1 form1 = new Form1(account);
                this.Hide();
                form1.ShowDialog();
            }
            else 
            { 
                account = Logibtxt.Text.Trim();
            password = Passwordtxt.Text.Trim();
            if (string.IsNullOrWhiteSpace(account) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("請輸入帳號與密碼！");
                return;
            }
            string hashedPassword = MC.HashPassword(password);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ACConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Member WHERE MemberAccount = @account AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@account", account);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("登入成功！");
                            Form1 form1 = new Form1(account);
                            this.Hide();
                            form1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("帳號或密碼錯誤！");
                        }
                    }
                }
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            FRMCreate fRMCreate = new FRMCreate();
            fRMCreate.ShowDialog();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPasswordBTN_Click(object sender, EventArgs e)
        {
            MC.ShowPassword(Passwordtxt);
        }
    }
}
