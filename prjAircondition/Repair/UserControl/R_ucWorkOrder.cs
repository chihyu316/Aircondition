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
            DataTable result = RE_DataSearch.WorkOrderSearch((string)RE_cob.SelectedItem, RE_SearchT.Text);

            //  綁定結果到 DataGridView
            RE_dataGridView1.DataSource = result;

            //  顯示筆數到 Label
            RE_lblCount.Text = $"共 {result.Rows.Count} 筆資料";
        }
        private void ER_btnSelect_Click(object sender, EventArgs e)
        {
            //  呼叫搜尋結果
            DataTable result = RE_DataSearch.WorkOrderSearch((string)RE_cob.SelectedItem, RE_SearchT.Text);

            //  綁定結果到 DataGridView
            RE_dataGridView1.DataSource = result;

            //  顯示筆數到 Label
            RE_lblCount.Text = $"共 {result.Rows.Count} 筆資料";
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
                        ReloadWorkOrders(); // 重新整理資料表
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
            DataTable dt = (DataTable)RE_dataGridView1.DataSource;

            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Modified)
                {
                    try
                    {
                        RE_DataSearch.UpdateWorkOrder(row); // ✨呼叫資料庫更新
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("更新失敗：" + ex.Message);
                    }
                }
            }

            MessageBox.Show("所有變更已儲存！");
            ReloadWorkOrders(); // 重新載入最新資料
        }
        private void ReloadWorkOrders()
        {
            DataTable result = RE_DataSearch.LoadWorkOrder();  // 載入原始英文欄位資料
            RE_dataGridView1.DataSource = result;
            InitGridHeaders(); // 顯示中文欄位名稱、隱藏系統欄位
            RE_lblCount.Text = $"共 {result.Rows.Count} 筆資料";
        }
        private void InitGridHeaders()
        {
            var dgv = RE_dataGridView1;

            dgv.Columns["WorkOrderID"].HeaderText = "工單編號";
            dgv.Columns["DetailID"].HeaderText = "工單細項";
            dgv.Columns["WorkTypeID"].HeaderText = "工作類型";
            dgv.Columns["TechnicianID"].HeaderText = "派工師傅";
            dgv.Columns["ModelName"].HeaderText = "機型";
            dgv.Columns["SerialNumber"].HeaderText = "機號";
            dgv.Columns["CreatedDate"].HeaderText = "建立日期";
            dgv.Columns["OrderStatus"].HeaderText = "工單狀態";
            dgv.Columns["CompletedDate"].HeaderText = "完工日期";
            dgv.Columns["PaymentType"].HeaderText = "付款方式";
            dgv.Columns["MemberID"].HeaderText = "會員編號";
            dgv.Columns["CityID"].HeaderText = "城市";
            dgv.Columns["AreaID"].HeaderText = "地區";
            dgv.Columns["AddressDetail"].HeaderText = "施工地址";

            // 🛑 隱藏系統用欄位
            //dgv.Columns["WorkOrderID"].Visible = false;
            dgv.Columns["DetailID"].Visible = false;
            dgv.Columns["MemberID"].Visible = false;
            dgv.Columns["TechnicianID"].Visible = false;
            //dgv.Columns["WorkTypeID"].Visible = false;
            dgv.Columns["OrderStatus"].Visible = false;
            dgv.Columns["PaymentType"].Visible = false;
            dgv.Columns["CityID"].Visible = false;
            dgv.Columns["AreaID"].Visible = false;
        }

        
        private void RE_btndele_Click(object sender, EventArgs e)
        {
            //  支援點單格也能刪
            var rowsToDelete = RE_dataGridView1.SelectedRows.Count > 0 ?
                RE_dataGridView1.SelectedRows.Cast<DataGridViewRow>().ToList() :
                (RE_dataGridView1.CurrentRow != null ? new List<DataGridViewRow> { RE_dataGridView1.CurrentRow } : null);

            if (rowsToDelete == null || rowsToDelete.Count == 0)
            {
                MessageBox.Show("請先選取要刪除的工單");
                return;
            }

            List<int> deletable = new List<int>();
            List<int> blocked = new List<int>();

            //  分類是否可刪除
            foreach (var row in rowsToDelete)
            {
                int workOrderID = Convert.ToInt32(row.Cells["工單編號"].Value);

                if (RE_DataSearch.HasRelatedData(workOrderID))
                    blocked.Add(workOrderID);
                else
                    deletable.Add(workOrderID);
            }

            //  提示不能刪除的工單
            if (blocked.Count > 0)
            {
                string blockedMsg = string.Join("、", blocked.Select(id => $"#{id}"));
                MessageBox.Show($"以下工單已有子資料，無法刪除：\n{blockedMsg}", "禁止刪除");
            }

            //  刪除可刪除的工單
            if (deletable.Count == 0) return;

            string deletableMsg = string.Join("、", deletable.Select(id => $"#{id}"));
            var confirm = MessageBox.Show($"確定要刪除以下 {deletable.Count} 筆工單？\n{deletableMsg}", "刪除確認", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            foreach (int id in deletable)
            {
                RE_DataSearch.DeleteWorkOrder(id);
            }

            ReloadWorkOrders(); // 重新整理資料表
        }

        private void RE_update_Click_1(object sender, EventArgs e)
        {
            ReloadWorkOrders();
        }
    }
}

