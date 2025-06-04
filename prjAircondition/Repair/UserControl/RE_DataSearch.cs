using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition
{
    public class RE_DataSearch
    {


        public static DataTable LoadWorkOrder()
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            string query = "SELECT * FROM WorkOrder";


            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }

            return result;
        }




        public static DataTable LoadhWorkOrder()
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            string query =
            " SELECT W.WorkOrderID as '工單編號', " +
            "       WT.WorkType as '工作類型', " +
            "       T.Nickname as '師傅名稱', " +
            "       W.ModelName as '機型', " +
            "       W.SerialNumber as '機號', " +
            "       W.CreatedDate as '工單建立日期', " +
            "       OS.Status as '工單狀態', " +
            "       W.CompletedDate as '工單完工日期', " +
            "       CASE " +
            "           WHEN W.PaymentType = 0 THEN N'現金' " +
            "           WHEN W.PaymentType = 1 THEN N'分期付款' " +
            "           ELSE N'' " +
            "       END AS '付款方式', " +
            "       M.NickName as '會員名稱', " +
            "       Ci.City as '城市名稱', " +
            "       Ar.AREA as '地區名稱', " +
            "       W.AddressDetail as '施工地址' " +
            "       FROM WorkOrder AS W " +
            "       LEFT JOIN Technicians AS T ON T.T_id = W.TechnicianID " +
            "       LEFT JOIN [Member] AS M ON M.MemberID = W.MemberID " +
            "       LEFT JOIN CityList AS Ci ON Ci.CityID = W.CityID " +
            "       LEFT JOIN AreaList AS Ar ON Ar.AreaID = W.AreaID " +
            "       LEFT JOIN OrderStatus AS OS ON OS.OrderStatus = W.OrderStatus " +
            "       LEFT JOIN WorkType AS WT ON WT.WorkTypeID = W.WorkTypeID ";

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
        public static DataTable WorkOrderSearch(string S, string T)
        {
            //工作類型
            //師傅名稱
            //會員名稱
            //工單建立日期
            //工單狀態
            //付款方式
            //施工地址
            DataTable resultTable = new DataTable();
            SqlConnection conn;
            conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            string query = 
            " SELECT W.WorkOrderID as '工單編號', " +
            "       WT.WorkType as '工作類型', " +
            "       T.Nickname as '師傅名稱', " +
            "       W.ModelName as '機型', " +
            "       W.SerialNumber as '機號', " +
            "       W.CreatedDate as '工單建立日期', " +
            "       OS.Status as '工單狀態', " +
            "       W.CompletedDate as '工單完工日期', " +
            "       CASE " +
            "           WHEN W.PaymentType = 0 THEN N'現金' " +
            "           WHEN W.PaymentType = 1 THEN N'分期付款' " +
            "           ELSE N'' " +
            "       END AS '付款方式', " +
            "       M.NickName as '會員名稱', " +
            "       Ci.City as '城市名稱', " +
            "       Ar.AREA as '地區名稱', " +
            "       W.AddressDetail as '施工地址' " +
            "       FROM WorkOrder AS W " +
            "       LEFT JOIN Technicians AS T ON T.T_id = W.TechnicianID " +
            "       LEFT JOIN [Member] AS M ON M.MemberID = W.MemberID " +
            "       LEFT JOIN CityList AS Ci ON Ci.CityID = W.CityID " +
            "       LEFT JOIN AreaList AS Ar ON Ar.AreaID = W.AreaID " +
            "       LEFT JOIN OrderStatus AS OS ON OS.OrderStatus = W.OrderStatus " +
            "       LEFT JOIN WorkType AS WT ON WT.WorkTypeID = W.WorkTypeID ";

            switch (S)
            {
                case "工作類型":
                    query += " where WT.WorkType LIKE @T   ";
                    break;
                case "師傅名稱":
                    query += " where t.Nickname Like @T    ";
                    break;
                case "會員名稱":
                    query += " where M.NickName Like @T    ";
                    break;
                case "工單建立日期":
                    query += " where FORMAT(CreatedDate, 'yyyy/MM') LIKE @T    ";
                    break;
                case "工單狀態":
                    query += " where OS.Status Like @T   ";
                    break;
                case "付款方式":
                    query += @"
                                WHERE 
                                CASE 
                                WHEN PaymentType = 0 THEN N'現金'
                                WHEN PaymentType = 1 THEN N'分期付款'
                                ELSE N''
                                END LIKE @T";
                    break;
                case "施工地址":
                    query += " where AddressDetail like @T   ";
                    break;
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@T", "%" + T + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查詢失敗：" + ex.Message);
                return resultTable;
            }
            return resultTable;
        }
    }
}
