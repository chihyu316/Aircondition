using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.PowerShell.Commands;

namespace prjAircondition.Dicuss.Class
{
    internal class D_DataConnect
    {
        public static DataTable LoadhPostmain()
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True";
            string query = @"select M.NickName as '發文者' , 
                             PS.PostsSortName AS '文章類型' 
                            ,PL.PostsStateName AS '文章狀態', P.Title AS '文章標題' ,
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
                SqlConnection conn = new SqlConnection(connStr);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();                
                adapter.Fill(resultTable);
                conn.Close();     
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultTable;
        }
        public static DataTable PostMainSrc(string srcStr1, string srcStr2, string srcStr3)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            string query = @"select M.NickName as '發文者' , PS.PostsSortName AS '文章類型' ,
                               PL.PostsStateName AS '文章狀態', P.Title AS '文章標題' ,  
                               P.Contents AS '文章內容', P.GreatPoint AS 'GP數',
                               P.PageView AS '瀏覽數' , P.PostTime AS '發文時間',
                               CASE 
                               WHEN P.EditTime IS NOT NULL THEN CONVERT(VARCHAR, P.EditTime, 120) 
                               ELSE NULL 
                               END AS '編輯時間'
                               from PostsMain as P
                               join [Member] as M on  P.MemberID = M.MemberID
                               join [PostsSortList] as ps on PS.PostsSortID = P.PostsSortID
                               join [PostsStateList] as PL on PL.PostsStateListId = P.PostsState";
            List<string> conditions = new List<string>();
            DataTable resultTable = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //判斷有無傳入值有的話加入查詢語法至List
                if (!string.IsNullOrEmpty(srcStr1))
                {
                    conditions.Add("P.Title LIKE @Title");
                    cmd.Parameters.AddWithValue("@Title", "%" + srcStr1 + "%");
                }

                if (!string.IsNullOrEmpty(srcStr2))
                {
                    conditions.Add("M.NickName LIKE @Name");
                    cmd.Parameters.AddWithValue("@Name", "%" + srcStr2 + "%");
                }

                if (!string.IsNullOrEmpty(srcStr3))
                {
                    conditions.Add("CONVERT(VARCHAR, P.PostTime, 120) LIKE @Date");
                    cmd.Parameters.AddWithValue("@Date", "%" + srcStr3 + "%");
                }
                //依據list行數進行不同次數的where條件式
                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }
                cmd.CommandText = query;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(resultTable);
                }
                return resultTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return resultTable;
            }
        }
    }
}

