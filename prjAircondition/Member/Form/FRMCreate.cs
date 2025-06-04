using prjAircondition.Properties;
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
    public partial class FRMCreate : Form
    {
        MemberClass MC;
        Image DefaultImage;
        public FRMCreate()
        {
            InitializeComponent();
            MC = new MemberClass();
            LoadDefaultImageFromDB();
            AvatarPicturebox.AllowDrop = true;
            AvatarPicturebox.DragEnter += AvatarPicturebox_DragEnter;
            AvatarPicturebox.DragDrop += AvatarPicturebox_DragDrop;
        }

        private void AvatarPicturebox_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            AvatarPicturebox.Image = Image.FromFile(data[0]);
        }

        private void AvatarPicturebox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void LoadDefaultImageFromDB()
        {
            using (var conn = new SqlConnection(Settings.Default.ACConnectionString))
            using (var cmd = new SqlCommand("SELECT DefaultPicture FROM DefaultPicture WHERE ID = 1", conn))
            {
                conn.Open();
                var result = cmd.ExecuteScalar() as byte[];
                if (result != null)
                {
                    DefaultImage = Image.FromStream(new MemoryStream(result));
                    AvatarPicturebox.Image = DefaultImage;
                }
            }
        }

        private void CancelBTN_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchFileBTN_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MemberopenFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(MemberopenFileDialog1.FileName);
                    AvatarPicturebox.Image = img;
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("所選檔案不是有效的圖片格式。請選擇 JPG、PNG 等圖片類型。", "檔案格式錯誤", MessageBoxButtons.OK);
                }
            }
        }

        private void ResetAvatarBTN_Click_1(object sender, EventArgs e)
        {
            AvatarPicturebox.Image = (Image)DefaultImage.Clone();
        }

        private void ShowPasswordBTN_Click(object sender, EventArgs e)
        {
            MC.ShowPassword(PassWordTXB);
        }

        private void MaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MC.Sexechange(MaleCheckBox, FemaleCheckBox);
        }

        private void FemaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MC.Sexechange(FemaleCheckBox, MaleCheckBox);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string account = AccountTXB.Text; string email = EmailTXB.Text; string phonenumber = PhoneNumberTXB.Text; string nickname = NickNameTXB.Text; int gendervalue;
            string rawpassword = PassWordTXB.Text;
            string password = MC.HashPassword(rawpassword);
            List<string> emptyFields = new List<string>();
            if (string.IsNullOrWhiteSpace(account)) emptyFields.Add("帳號");
            if (string.IsNullOrWhiteSpace(password)) emptyFields.Add("密碼");
            if (string.IsNullOrWhiteSpace(email)) emptyFields.Add("信箱");
            if (string.IsNullOrWhiteSpace(phonenumber)) emptyFields.Add("電話");

            if (emptyFields.Count > 0)
            {
                MessageBox.Show(string.Join("、", emptyFields) + " 為必填欄位，請確認輸入完整。", "欄位未填寫", MessageBoxButtons.OK);
                return;
            }
            byte[] pictures;
            using (MemoryStream ms = new MemoryStream())
            {
                AvatarPicturebox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                pictures = ms.GetBuffer();
            }
            if (!MC.SetsexValue(MaleCheckBox, FemaleCheckBox, out gendervalue))
            {
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.ACConnectionString))
                {
                    conn.Open();
                    string checkSql = @"SELECT  MemberAccount, Email, PhoneNumber, NickName FROM Member 
                    WHERE MemberAccount = @MemberAccount OR Email = @Email OR PhoneNumber = @PhoneNumber OR NickName = @Nickname";

                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.Add("@MemberAccount", SqlDbType.NVarChar, 10).Value = account;
                        checkCmd.Parameters.Add("@Email", SqlDbType.VarChar, 30).Value = email;
                        checkCmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 30).Value = phonenumber;
                        checkCmd.Parameters.Add("@NickName", SqlDbType.VarChar, 30).Value = nickname;

                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<string> conflictFields = new List<string>();

                                if (reader["MemberAccount"] != DBNull.Value && reader["MemberAccount"].ToString() == account)
                                    conflictFields.Add("帳號");

                                if (reader["Email"] != DBNull.Value && reader["Email"].ToString() == email)
                                    conflictFields.Add("Email");

                                if (reader["PhoneNumber"] != DBNull.Value && reader["PhoneNumber"].ToString() == phonenumber)
                                    conflictFields.Add("電話");

                                if (reader["NickName"] != DBNull.Value && reader["NickName"].ToString() == nickname)
                                    conflictFields.Add("暱稱");

                                MessageBox.Show(string.Join("、", conflictFields) + " 已被使用，請更換！");
                                return;
                            }
                        }
                        string sql = @"INSERT INTO Member (MemberAccount, Password, HeadShot, Sexual, Email, PhoneNumber, NickName) 
                                    VALUES (@MemberAccount, @Password, @HeadShot, @Sexual, @Email, @PhoneNumber, @NickName)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.Add("@MemberAccount", SqlDbType.NVarChar, 10).Value = account;
                            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                            cmd.Parameters.Add("@HeadShot", SqlDbType.VarBinary).Value = pictures;
                            cmd.Parameters.Add("@Sexual", SqlDbType.Bit).Value = gendervalue;
                            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;
                            cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 10).Value = phonenumber;
                            cmd.Parameters.Add("@NickName", SqlDbType.VarChar, 30).Value = nickname;
                            cmd.ExecuteNonQuery();
                            if (TorNOT.Checked)
                            {
                                string insertTsql = @"INSERT INTO Technicians (Account, Password, Photo, Email, Phone, Nickname,gender) 
                                                    VALUES (@Account, @Password, @Photo, @Email, @Phone, @Nickname,@sexual)";
                                using (SqlCommand insertTcmd = new SqlCommand(insertTsql, conn))
                                {
                                    insertTcmd.Parameters.Add("@Account", SqlDbType.NVarChar, 20).Value = account;
                                    insertTcmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                                    insertTcmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = pictures;
                                    insertTcmd.Parameters.Add("@Sexual", SqlDbType.Bit).Value = gendervalue;
                                    insertTcmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;
                                    insertTcmd.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = phonenumber;
                                    insertTcmd.Parameters.Add("@NickName", SqlDbType.VarChar, 10).Value = nickname;
                                    insertTcmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("新增會員成功");
            Close();
        }
    }
}
