using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Repair
{
    public partial class R_ucWorkOrder : UserControl
    {
        
        public R_ucWorkOrder()
        {
            InitializeComponent();
            //  載入全部工單資料
            DataTable result = RE_DataSearch.LoadhWorkOrder();
            RE_dataGridView1.DataSource = result;

            //  顯示筆數
            ER_lblCount.Text = $"共 {result.Rows.Count} 筆資料";
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //  呼叫搜尋結果
            DataTable result = RE_DataSearch.WorkOrderSearch((string)RE_cob.SelectedItem, RE_SearchT.Text);

            //  綁定結果到 DataGridView
            RE_dataGridView1.DataSource = result;

            //  顯示筆數到 Label
            ER_lblCount.Text = $"共 {result.Rows.Count} 筆資料";
        }

        private void RE_btnNew_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            int nextID = 0;

            try
            {
                // 第一步：取得最新 WorkOrderID + 1
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT ISNULL(MAX(WorkOrderID), 0) + 1 FROM WorkOrder";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        nextID = (int)cmd.ExecuteScalar();
                    }

                }


                //  新增一筆空的工單（只建立 CreatedDate，其它預設）
                string sqlInsert = "INSERT INTO WorkOrder (WorkOrderID, CreatedDate) VALUES (@WorkOrderID, @CreatedDate)";

                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkOrderID", nextID);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("新增空白工單成功", "新增成功");

                    }
                    else
                    {
                        MessageBox.Show("新增失敗", "錯誤");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message, "例外錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RE_update_Click(object sender, EventArgs e)
        {
            RE_dataGridView1.DataSource = RE_DataSearch.LoadWorkOrder();
        }
    }
}
