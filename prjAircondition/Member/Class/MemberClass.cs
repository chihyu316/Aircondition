using prjAircondition.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Member
{
    internal class MemberClass
    {
        string password { get; set; }
        bool sexual { get; set; }
        string phone { get; set; }
        string nickname { get; set; }
        bool isInternalchange = false;
        public void ShowPassword(object password)
        {
            if (password is TextBox passwordBox)
            {
                if (passwordBox.PasswordChar == '\0')
                {
                    passwordBox.PasswordChar = '●';
                }
                else
                {
                    passwordBox.PasswordChar = '\0';
                }
            }
        }
        public string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        public void ObjectIsChange(object password, object sexual, object phone, object nickname)
        {

        }
        public bool Sexechange(object sex, object othersex)
        {
            if (isInternalchange) return false;
            if (sex is CheckBox Sex && othersex is CheckBox OtherSex)
            {
                isInternalchange = true;

                Sex.Checked = true;
                OtherSex.Checked = false;

                isInternalchange = false;
                return true;
            }
            return false;
        }
        public bool SetsexValue(object sex, object othersex, out int gendervalue)
        {
            gendervalue = -1;
            if (sex is CheckBox Sex && othersex is CheckBox OtherSex)
            {
                if (Sex.Checked)
                {
                    gendervalue = 1;
                    return true;
                }
                else if (OtherSex.Checked)
                {
                    gendervalue = 0;
                    return true;
                }
                else
                {
                    MessageBox.Show("請選擇性別!", "性別未選擇", MessageBoxButtons.OK);
                    return false;
                }
            }
            return false;
        }
        public void SQLDataFill(string Account)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            SqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.Add("@Account",SqlDbType.NVarChar,10).Value = Account;
            string query = @"SELECT [MemberID],[ProductType],[InstallDate],[Address],[Notes],[FileCreateTime],[RegularMaintenanceNotice] 
                            FROM [dbo].[MemberProduct] mp
                            JOIN 
                            [dbo].[Member] m ON mp.MemberID = m.MemberID
                            WHERE 
                            m.MemberAccount = @account";
            DataTable resulttable = new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
