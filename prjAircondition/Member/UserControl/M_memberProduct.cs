using prjAircondition.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Member
{
    public partial class M_memberProduct : UserControl
    {
        MemberClass MC = new MemberClass();
        public M_memberProduct()
        {
            InitializeComponent();
        }

        private void SearchMember_TextChanged(object sender, EventArgs e)
        {
            string cludename = SearchMember.Text;
            MemberListV.Items.Clear();
            //MemberListV.Columns.Clear();
            //MemberListV.Columns.Add("帳號", 200);
            string conn = Settings.Default.ACConnectionString;
            try
            {

                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string sql = $"SELECT MemberAccount FROM Member where MemberAccount Like @cludename";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.Parameters.AddWithValue("@cludename", "%" + cludename + "%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string account = reader["MemberAccount"].ToString();
                        ListViewItem item = new ListViewItem(account);
                        item.BackColor = (MemberListV.Items.Count % 2 == 0) ? Color.Gray : Color.White;
                        MemberListV.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void MemberListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Account = MemberListV.Text;
            MC.SQLDataFill(Account);
        }

        private void M_memberProduct_Load(object sender, EventArgs e)
        {
            MemberListV.View = View.Details;
            MemberListV.Columns.Clear();
            MemberListV.Columns.Add("帳號", 200);
            string conn = Settings.Default.ACConnectionString;
            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string sql = "SELECT MemberAccount FROM Member";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string account = reader["MemberAccount"].ToString();
                        ListViewItem item = new ListViewItem(account);
                        item.BackColor = (MemberListV.Items.Count % 2 == 0) ? Color.Gray : Color.White;
                        MemberListV.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}


