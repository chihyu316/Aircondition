using prjAircondition.Member.DataSet.M_MemberDatasetTableAdapters;
using prjAircondition.Properties;
using prjAircondition.Tech.DataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Member
{
    public partial class M_meberinfo : UserControl
    {
        MemberClass MC = new MemberClass();
        public M_meberinfo()
        {
            InitializeComponent();
        }

        private void MaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MC.Sexechange(MaleCheckBox, FemaleCheckBox);

        }

        private void FemaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MC.Sexechange(FemaleCheckBox, MaleCheckBox);

        }

        private void ShowPasswordBTN_Click(object sender, EventArgs e)
        {
            MC.ShowPassword(PassWordTXB);
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            string connectionstring = Settings.Default.ACConnectionString;
            string Password = PassWordTXB.Text; int gendervalue; string Phone = PhoneNumberTXB.Text; string Nickname = NicknameTXB.Text;
            string hashpassword = MC.HashPassword(Password);
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.ConnectionString = connectionstring;
                    con.Open();
                    cmd.CommandText = $"UPDATE member set Password = @Password, HeadShot = @Headshot, Sexual = @Sexual, PhoneNumber = @PhoneNumber, Nickname = @Nickname where MemberAccount = ";
                    cmd.Connection = con;
                    byte[] pictures;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(AvatarBOX.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pictures = ms.ToArray();
                        }
                    }

                    MC.SetsexValue(MaleCheckBox, FemaleCheckBox, out gendervalue);
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = hashpassword;
                    cmd.Parameters.Add("@Headshot", SqlDbType.VarBinary).Value = pictures;
                    cmd.Parameters.Add("@Sexual", SqlDbType.Bit).Value = gendervalue;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 10).Value = Phone;
                    cmd.Parameters.Add("@Nickname", SqlDbType.NVarChar, 10).Value = Nickname;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("資料更改成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void M_meberinfo_Load(object sender, EventArgs e)
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

        private void MemberListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemberListV.SelectedItems.Count == 0)
            {
                Accountlbl.Text = "";
                MaleCheckBox.Checked = false;
                FemaleCheckBox.Checked = false;
                PhoneNumberTXB.Text = "";
                NicknameTXB.Text = "";
                AvatarBOX.Image = null;
                return;
            }
            string Account = MemberListV.SelectedItems[0].Text;
            m_MemberDataset1.Member.Clear();
            memberTableAdapter1.FillByAccount(m_MemberDataset1.Member,Account);

            if (m_MemberDataset1.Member.Rows.Count > 0)
            {
                DataRow row = m_MemberDataset1.Member.Rows[0];
                Accountlbl.Text = row["MemberAccount"].ToString();
                bool isMale = (bool)row["Sexual"];
                MaleCheckBox.Checked = isMale;
                FemaleCheckBox.Checked = !isMale;

                PhoneNumberTXB.Text = row["PhoneNumber"].ToString();
                NicknameTXB.Text = row["Nickname"].ToString();
                byte[] bytes = row["HeadShot"] as byte[];

                if (bytes != null && bytes.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            AvatarBOX.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("圖片載入失敗: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("未找到該會員資料！");
            }
        }

    }
}


