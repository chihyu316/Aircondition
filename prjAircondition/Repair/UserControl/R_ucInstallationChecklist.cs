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
    public partial class R_ucInstallationChecklist : UserControl
    {

        private string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
        private DataTable dataTable;
        private SqlDataAdapter adapter;
        private int currentWorkOrderID;

        public R_ucInstallationChecklist()
        {
            InitializeComponent();
            this.Load += R_ucInstallationChecklist_Load;
        }
        private void R_ucInstallationChecklist_Load(object sender, EventArgs e)
        {
            //  預設載入工單 ID = 1 的資料來測試
            LoadAll();

        }
        private void RE_btnNew1_Click(object sender, EventArgs e)
        {
            if (dataTable == null)
            {
                MessageBox.Show("請先選取一筆工單，才能新增確認項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow newRow = dataTable.NewRow();
            newRow["WorkOrderID"] = currentWorkOrderID;
            newRow["CreatedTime"] = DateTime.Now; //  自動填入建立時間
            dataTable.Rows.Add(newRow);
        }


        private void RE_btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    adapter.SelectCommand.Connection = conn; // 確保連線是有效的
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    conn.Open();
                    adapter.Update(dataTable);
                }

                MessageBox.Show(" 資料已儲存", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAll(); // 重新載入資料
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RE_delet_Click(object sender, EventArgs e)
        {
            if (dataTable == null || RE_checklist.CurrentRow == null)
            {
                MessageBox.Show("請先選取一筆資料再執行刪除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //  取得當前資料列
            DataGridViewRow gridRow = RE_checklist.CurrentRow;
            DataRowView rowView = gridRow.DataBoundItem as DataRowView;
            DataRow row = rowView?.Row;

            if (row == null)
            {
                MessageBox.Show("找不到資料列，無法刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  若是新列（尚未儲存進資料庫）
            if (row.RowState == DataRowState.Added)
            {
                row.Delete();
                MessageBox.Show("🗑️ 已移除新增列（尚未儲存至資料庫）", "提示");
                return;
            }

            string checklistID = row.Table.Columns.Contains("ChecklistID") ? row["ChecklistID"].ToString() : "(無 ID)";
            var result = MessageBox.Show(
                $"是否確定刪除 ChecklistID = {checklistID}？\n刪除後將無法復原！",
                " 確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                row.Delete(); // 標記刪除，按下儲存才會寫入資料庫
                MessageBox.Show($" 已標記刪除 ChecklistID = {checklistID}\n請記得按下「儲存」以完成刪除！", "已標記刪除");
            }
        }

        private void RE_ref_Click(object sender, EventArgs e)
        {
            LoadAll(); // 重新載入資料
            MessageBox.Show("資料已重新載入");
        }
        public void LoadAll()
        {
            string sql = "SELECT * FROM InstallationChecklist";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                adapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataTable.AcceptChanges();

                RE_checklist.DataSource = dataTable;

                // 抓第一筆的 WorkOrderID（新增用）
                if (dataTable.Rows.Count > 0 && dataTable.Columns.Contains("WorkOrderID"))
                {
                    currentWorkOrderID = Convert.ToInt32(dataTable.Rows[0]["WorkOrderID"]);
                }
                else
                {
                    currentWorkOrderID = 0;
                }

                //  顯示總筆數
                RE_lbl.Text = $"共 {dataTable.Rows.Count} 筆資料";
            }
            InitGridHeaders();
        }
        private void InitGridHeaders()
        {
            var dgv = RE_checklist;

            if (dgv.Columns.Contains("ChecklistID")) dgv.Columns["ChecklistID"].HeaderText = "清單編號";
            if (dgv.Columns.Contains("WorkOrderID")) dgv.Columns["WorkOrderID"].HeaderText = "工單編號";
            if (dgv.Columns.Contains("ScheduledInstallationDate")) dgv.Columns["ScheduledInstallationDate"].HeaderText = "安裝日期";
            if (dgv.Columns.Contains("IsInstallLocationConfirmed")) dgv.Columns["IsInstallLocationConfirmed"].HeaderText = "安裝位置確認";
            if (dgv.Columns.Contains("IsPanelAdjustedOrPurchased")) dgv.Columns["IsPanelAdjustedOrPurchased"].HeaderText = "面板已調整/購買";
            if (dgv.Columns.Contains("IsDrillingLocationConfirmed")) dgv.Columns["IsDrillingLocationConfirmed"].HeaderText = "鑽孔位置確認";
            if (dgv.Columns.Contains("IsFunctionTested")) dgv.Columns["IsFunctionTested"].HeaderText = "功能測試通過";
            if (dgv.Columns.Contains("IsWarrantyProvided")) dgv.Columns["IsWarrantyProvided"].HeaderText = "保固已提供";
            if (dgv.Columns.Contains("IsMemberConsulted")) dgv.Columns["IsMemberConsulted"].HeaderText = "已與會員確認";
            if (dgv.Columns.Contains("IsRecycleAgreement")) dgv.Columns["IsRecycleAgreement"].HeaderText = "回收同意書已簽署";
            if (dgv.Columns.Contains("IsCleaningDone")) dgv.Columns["IsCleaningDone"].HeaderText = "已清潔完畢";
            if (dgv.Columns.Contains("IsRemoteAreaFeeConfirmed")) dgv.Columns["IsRemoteAreaFeeConfirmed"].HeaderText = "偏遠費用已確認";
            if (dgv.Columns.Contains("IsPaymentConfirmed")) dgv.Columns["IsPaymentConfirmed"].HeaderText = "付款已確認";
            if (dgv.Columns.Contains("Inspector")) dgv.Columns["Inspector"].HeaderText = "檢查人員";
            if (dgv.Columns.Contains("CreatedTime")) dgv.Columns["CreatedTime"].HeaderText = "建立時間";
        }
    }
}

