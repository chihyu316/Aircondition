using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Dicuss.Class
{
    internal class D_DataConnect
    {
        public static DataTable LoadhPostmain()
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            string query = "";

            DataTable resultTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(resultTable);
                }
            }
            catch (Exception ex)
            {
                // 🧯 錯誤處理（你也可以改寫成 log 紀錄）
                MessageBox.Show("載入工單資料失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultTable;
        }
    }
}
