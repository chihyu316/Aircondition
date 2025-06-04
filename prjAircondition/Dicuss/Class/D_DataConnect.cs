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
            string connStr = "Data Source=192.168.71.139;User Id=sa;Password=sa;Initial Catalog=AC;Integrated Security=True;";
            string query = @"M.NickName as '發文者' , 
                             PS.PostsSortName AS '文章類型' 
                            ,PL.PostsStateListId AS '文章狀態', P.Title AS '文章標題' ,
                             P.Contents AS '文章內容', P.GreatPoint AS 'GP數'
                            ,P.PageView AS '瀏覽數' , P.PostTime AS '發文時間',
                             CASE 
                             WHEN P.EditTime IS NOT NULL THEN CONVERT(VARCHAR, P.EditTime, 120) 
                             ELSE NULL 
                             END AS '編輯時間'
                             from PostsMain as P
                             join [Member] as M on  P.MemberID = M.MemberID
                             join [PostsSortList] as ps on PS.PostsSortID = P.PostsSortID
                             join [PostsStateList] as PL on PL.PostsStateListId = P.PostsState;";                            
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
                return resultTable;
            }
            return resultTable;
        }
    }
}
