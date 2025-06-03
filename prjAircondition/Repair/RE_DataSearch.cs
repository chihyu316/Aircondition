using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prjAircondition
{
    public class RE_DataSearch
    {
        public static DataTable LoadhWorkOrder()
        {
            SqlConnection conn;
            conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            conn.Open();
            //SqlDataAdapter adapter = new SqlDataAdapter("select * from Products", conn);
            string query = "SELECT W.WorkOrderID as '工單編號' , WT.WorkType '工作類型' , t.Nickname '師傅名稱' , ModelName as '機型', " +
                           " SerialNumber as '機號' , CreatedDate as '工單建立日期' , OS.Status as '工單狀態' , CompletedDate as '工單完工日期'," +
                           "  CASE WHEN PaymentType = 0 THEN N'現金'  WHEN PaymentType = 1 THEN N'分期付款' ELSE N''  END AS PaymentType " +
                           " , M.NickName as '會員名稱' , Ci.City as '城市名稱' , Ar.AREA as '地區名稱' , AddressDetail as '施工地址' " +
                           " FROM WorkOrder AS W inner join Technicians as T on T.T_id = W.TechnicianID" +
                           " join[Member] as M on M.MemberID = W.MemberID " +
                           "JOIN[CityList] AS Ci on Ci.CityID = W.CityID " +
                           "join[AreaList] as Ar on Ar.AREAID = W.AreaID " +
                           "join[OrderStatus] as OS on OS.OrderStatus = W.OrderStatus INNER JOIN WorkType AS WT ON WT.WorkTypeID = W.WorkTypeID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);
            conn.Close();
            return resultTable;
        }
        public static DataTable WorkOrderSearch(string S,string T) 
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
            string query= "SELECT W.WorkOrderID as '工單編號' , WT.WorkType '工作類型' , t.Nickname '師傅名稱' , ModelName as '機型', " +
                           " SerialNumber as '機號' , CreatedDate as '工單建立日期' , OS.Status as '工單狀態' , CompletedDate as '工單完工日期'," +
                           "  CASE WHEN PaymentType = 0 THEN N'現金'  WHEN PaymentType = 1 THEN N'分期付款' ELSE N''  END AS PaymentType " +
                           " , M.NickName as '會員名稱' , Ci.City as '城市名稱' , Ar.AREA as '地區名稱' , AddressDetail as '施工地址' " +
                           " FROM WorkOrder AS W inner join Technicians as T on T.T_id = W.TechnicianID" +
                           " join[Member] as M on M.MemberID = W.MemberID " +
                           "JOIN[CityList] AS Ci on Ci.CityID = W.CityID " +
                           "join[AreaList] as Ar on Ar.AREAID = W.AreaID " +
                           "join[OrderStatus] as OS on OS.OrderStatus = W.OrderStatus INNER JOIN WorkType AS WT ON WT.WorkTypeID = W.WorkTypeID";

            switch (S) 
            {
                case "工作類型":
                    query = query + " where WT.WorkType LIKE @T   ";
                    break;
                case "師傅名稱":
                    query = query + " where t.Nickname Like @T    ";
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
                return resultTable;
            }
            return resultTable;
        }
    }
}
