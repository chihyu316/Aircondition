using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prjAircondition
{
    public class RE_DataSearch
    {


        public static DataTable LoadWorkOrder()
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            string query = @"
    SELECT WorkOrderID, DetailID, WorkTypeID, TechnicianID, ClosingTechnicianID,
           ModelName, SerialNumber, CreatedDate, OrderStatus,
           CompletedDate, PaymentType, MemberID, CityID, AreaID, AddressDetail
    FROM WorkOrder";




            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }

            return result;
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


        public static void UpdateWorkOrder(DataRow row)
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            string sql = @"
        UPDATE WorkOrder SET
            DetailID = @DetailID,
           
            TechnicianID = @TechnicianID,
            ClosingTechnicianID = @ClosingTechnicianID,
            ModelName = @ModelName,
            SerialNumber = @SerialNumber,
            CreatedDate = @CreatedDate,
            OrderStatus = @OrderStatus,
            CompletedDate = @CompletedDate,
            PaymentType = @PaymentType,
            MemberID = @MemberID,
            CityID = @CityID,
            AreaID = @AreaID,
            AddressDetail = @AddressDetail
        WHERE WorkOrderID = @WorkOrderID";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                //  加入所有欄位的參數
                cmd.Parameters.AddWithValue("@WorkTypeID", row["WorkTypeID"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@WorkOrderID", row["WorkOrderID"]);
                cmd.Parameters.AddWithValue("@DetailID", row["DetailID"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TechnicianID", row["TechnicianID"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ClosingTechnicianID", row["ClosingTechnicianID"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ModelName", row["ModelName"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SerialNumber", row["SerialNumber"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CreatedDate", row["CreatedDate"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OrderStatus", row["OrderStatus"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CompletedDate", row["CompletedDate"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PaymentType", row["PaymentType"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MemberID", row["MemberID"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CityID", row["CityID"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AreaID", row["AreaID"] ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AddressDetail", row["AddressDetail"] ?? DBNull.Value);

                try
                {
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    MessageBox.Show($" 更新成功，共 {count} 筆資料");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" 更新失敗：" + ex.Message);
                }
            }
        }

        public static void DeleteWorkOrder(int workOrderID)
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            string sql = "DELETE FROM WorkOrder WHERE WorkOrderID = @WorkOrderID";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@WorkOrderID", workOrderID);
                try
                {
                    conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show($"已刪除 {result} 筆工單", "刪除成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("刪除失敗：" + ex.Message, "錯誤");
                }
            }

        }
        public static bool HasRelatedData(int workOrderID)
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            string sql = @"
        SELECT COUNT(*) FROM (
            SELECT WorkOrderID FROM InstallationChecklist WHERE WorkOrderID = @ID
            UNION
            SELECT WorkOrderID FROM MaintenanceForm WHERE WorkOrderID = @ID
            UNION
            SELECT WorkOrderID FROM RepairIssue WHERE WorkOrderID = @ID
            UNION
            SELECT WorkOrderID FROM DismantleRecord WHERE WorkOrderID = @ID
        ) AS RelatedRecords";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ID", workOrderID);
                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // 若有子資料，回傳 true 表示「有關聯資料」
                }
                catch (Exception ex)
                {
                    MessageBox.Show("檢查子資料時發生錯誤：" + ex.Message);
                    return true; // 發生錯誤時，當作不能刪
                }
            }
        }

        
      
        
    }
}
