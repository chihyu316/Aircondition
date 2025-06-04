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
        public void LoadAll()
        {
            string sql = "SELECT * FROM InstallationChecklist";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                adapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataTable.AcceptChanges(); // ⭐ 避免當作初始就是修改

                RE_checklist.DataSource = dataTable;

                // 📌 若有 WorkOrderID 欄位，抓第一筆來設定 currentWorkOrderID，給新增用
                if (dataTable.Rows.Count > 0 && dataTable.Columns.Contains("WorkOrderID"))
                {
                    currentWorkOrderID = Convert.ToInt32(dataTable.Rows[0]["WorkOrderID"]);
                }
                else
                {
                    currentWorkOrderID = 0; // 或預設為 1
                }
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RE_delet_Click(object sender, EventArgs e)
        {
            if (RE_checklist.CurrentRow != null)
                RE_checklist.Rows.Remove(RE_checklist.CurrentRow);
        }

        private void RE_ref_Click(object sender, EventArgs e)
        {
            LoadAll(); // 重新載入資料
        }
    }
}
