using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAircondition.Dicuss.Class
{
    internal class D_DataConnect
    {
        
        public static DataTable SerchPost()
        {
        SqlConnection conn;
        conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
        //SqlDataAdapter adapter = new SqlDataAdapter("select * from Products", conn);
        string query = "select P.PostsID as '文章編號' , M.NickName as '發文者名稱',P.PostsSortID as '文章分類',P.Title as '文章標題',P.Contents as '文章內容'," +
                "P.GreatPoint as 'GP數',P.PageView AS '瀏覽數',P.PostTime AS '發文時間',P.EditTime AS '編輯時間'" +
                "  from PostsMain as P inner join [Member] as M on P.MemberID = M.MemberID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);
            return resultTable;
        }
        public static DataTable SerchPostUser(string NickName)
        {
            DataTable resultTable = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;"))
            {
                string query = @"SELECT P.PostsID AS '文章編號', 
                                M.NickName AS '發文者名稱', 
                                P.PostsSortID AS '文章分類',
                                P.Title AS '文章標題',
                                P.Contents AS '文章內容',
                                P.GreatPoint AS 'GP數',
                                P.PageView AS '瀏覽數',
                                P.PostTime AS '發文時間',
                                P.EditTime AS '編輯時間'
                         FROM PostsMain AS P
                         INNER JOIN [Member] AS M ON P.MemberID = M.MemberID
                         WHERE M.NickName LIKE  @NickName";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 使用參數避免 SQL 注入
                        cmd.Parameters.AddWithValue("@NickName", "%" + NickName + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 你可以選擇紀錄錯誤或回傳 null 或空的 DataTable
                    return resultTable;
                }
            }

            return resultTable;
        }
        public static DataTable SerchPostTitle(string PostTitle)
        {
            DataTable resultTable = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;"))
            {
                string query = @"SELECT P.PostsID AS '文章編號', 
                                M.NickName AS '發文者名稱', 
                                P.PostsSortID AS '文章分類',
                                P.Title AS '文章標題',
                                P.Contents AS '文章內容',
                                P.GreatPoint AS 'GP數',
                                P.PageView AS '瀏覽數',
                                P.PostTime AS '發文時間',
                                P.EditTime AS '編輯時間'
                         FROM PostsMain AS Pgg 
                         INNER JOIN [Member] AS M ON P.MemberID = M.MemberID
                         WHERE P.Title LIKE  @PostTitle";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 使用參數避免 SQL 注入
                        cmd.Parameters.AddWithValue("@PostTitle", "%" + PostTitle + "%");

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
            }

            return resultTable;
        }
        public static DataTable SerchPostdate(string PostDate)
        {
            DataTable resultTable = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;"))
            {
                string query = @"SELECT P.PostsID AS '文章編號', 
                                M.NickName AS '發文者名稱', 
                                P.PostsSortID AS '文章分類',
                                P.Title AS '文章標題',
                                P.Contents AS '文章內容',
                                P.GreatPoint AS 'GP數',
                                P.PageView AS '瀏覽數',
                                P.PostTime AS '發文時間',
                                P.EditTime AS '編輯時間'
                                FROM PostsMain AS P
                                ";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 使用參數避免 SQL 注入
                        cmd.Parameters.AddWithValue("@PostTitle", "%" + PostDate + "%");

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
            }

            return resultTable;
        }

    }
}
