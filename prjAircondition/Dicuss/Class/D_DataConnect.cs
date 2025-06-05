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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace prjAircondition.Dicuss.Class
{
    internal class D_DataConnect
    {
        public static DataTable LoadhPostmain()
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True";
            string query = @"select P.PostsID as '文章編號', M.NickName as '發文者' , 
                             PS.PostsSortName AS '文章類型' 
                            ,PL.PostsState AS '文章狀態', P.Title AS '文章標題' ,
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
        {  //建立連線字串與設定基礎select字串
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            string query = @"select P.PostsID as '文章編號', M.NickName as '發文者' , PS.PostsSortName AS '文章類型' ,
                               PL.PostsState AS '文章狀態', P.Title AS '文章標題' ,  
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
            //建立條件式List與結果DataTable
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
        public static DataTable PostUpdate(string state, string userName, string Title)
        {
            // 根據 state 參數決定要更新的 PostsStateID
            int stateID = 0;
            if (state == "置頂")
                stateID = 1;
            else if (state == "精華")
                stateID = 2;
            else if (state == "一般")
                stateID = 3;
            DataTable resultTable = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            conn.Open();
            // 先用 userName 查出對應的 MemberID
            int memberId = -1;
            using (SqlCommand cmdGetId = new SqlCommand("SELECT MemberID FROM Member WHERE NickName = @NickName", conn))
            {
                cmdGetId.Parameters.AddWithValue("@NickName", userName);
                var result = cmdGetId.ExecuteScalar();
                if (result == null)
                {
                    resultTable.Columns.Add("Error");
                    resultTable.Rows.Add("找不到該使用者。");
                    return resultTable;
                }
                memberId = Convert.ToInt32(result);
            }
            // 使用 MemberID 和 Title 更新 PostsMain 的 PostsState
            conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            string query = @"update PostsMain set PostsState = @stateID where MemberID = @MemberID and Title = @Title";
            SqlCommand cmdUpdate = new SqlCommand(query, conn);
            conn.Open();
            cmdUpdate.Parameters.AddWithValue("@stateID", stateID);
            cmdUpdate.Parameters.AddWithValue("@MemberID", memberId);
            cmdUpdate.Parameters.AddWithValue("@Title", Title);
            int rowsAffected = cmdUpdate.ExecuteNonQuery();
            resultTable.Columns.Add("Result");
            resultTable.Rows.Add($"更新了 {rowsAffected} 筆資料。");
            conn.Close();
            return resultTable;
        }
        public static void PostDelete(int Postid)
        {

            DialogResult result = MessageBox.Show(
            "確定要刪除這筆資料嗎？",
            "刪除確認",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
                string deleteQuery = "DELETE FROM PostsMain WHERE PostsID = @PostID";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@PostID", Postid);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("資料已刪除！");
            }
            else
            {
                MessageBox.Show("取消刪除。");
            }
        }
        public static DataTable PostInsert(string userName,string Postsort ,string Title ,string Contents)
        {
            DataTable resultTable = new DataTable();
            DialogResult result = MessageBox.Show(
            "確定要新增這筆資料嗎？",
            "新增確認",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            int memberId = -1;
            int PostsSortID = -1;
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AC;Integrated Security=True;");
            conn.Open();
            using (SqlCommand cmdGetId = new SqlCommand("SELECT MemberID FROM Member WHERE NickName = @NickName", conn))
            {
                cmdGetId.Parameters.AddWithValue("@NickName", userName);
                var ra = cmdGetId.ExecuteScalar();
                if (ra == null)
                {
                    resultTable.Columns.Add("Error");
                    resultTable.Rows.Add("找不到該使用者。");
                    return resultTable;
                }
                memberId = Convert.ToInt32(ra);
            }
            using (SqlCommand cmdGetId = new SqlCommand("SELECT PostsSortID FROM [PostsSortList] WHERE PostsSortName = @PostsSortName", conn))
            {
                cmdGetId.Parameters.AddWithValue("@PostsSortName", Postsort);
                var rb = cmdGetId.ExecuteScalar();
                if (rb == null)
                {
                    resultTable.Columns.Add("Error");
                    resultTable.Rows.Add("找不到此文章分類。");
                    return resultTable;
                }
                PostsSortID = Convert.ToInt32(rb);
            }
            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
                string insertQuery = @"INSERT INTO PostsMain 
                                      (MemberID, PostsSortID, PostsState, Title, 
                                       Contents,PostTime )
                                       VALUES 
                                      (@MemberID,@PostsSortID, 3 ,@Title,@Contents,GETDATE())";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@PostsSortID", PostsSortID);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Contents", Contents);          
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("資料已新增！");
            }
            else
            {
                MessageBox.Show("取消新增。");
            }
            return resultTable;
        }
    }
}


