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
            // 🛡️ 防止 dataTable 還沒載入就執行
            if (dataTable == null || RE_checklist.CurrentRow == null)
            {
                MessageBox.Show("請先選取一筆資料再執行刪除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 🧩 取得當前資料列
            DataGridViewRow gridRow = RE_checklist.CurrentRow;
            DataRowView rowView = gridRow.DataBoundItem as DataRowView;
            DataRow row = rowView?.Row;

            if (row == null)
            {
                MessageBox.Show("找不到資料列，無法刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ⚠️ 若是新列（尚未儲存進資料庫），可直接刪除無需提示
            if (row.RowState == DataRowState.Added)
            {
                row.Delete();
                return;
            }

            // 🔐 若是已存在於資料庫的資料列，加上確認提示
            var confirm = MessageBox.Show("確定要刪除這筆資料嗎？刪除後無法復原。", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                row.Delete(); // 標記為刪除狀態，儲存時由 adapter.Update() 執行
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

        }
    }
}

