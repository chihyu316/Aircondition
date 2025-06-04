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

namespace prjAircondition
{
    public partial class S_UcOrderMain : UserControl
    {
        private string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True";
        public S_UcOrderMain()
        {
            InitializeComponent();
        }

        private void S_UcOrderMain_Load(object sender, EventArgs e)
        {
            LoadOrders(); // ✅ 預設顯示所有訂單
        }
        private void LoadOrders(string keyword = "")
        {
            dataGridView1.ReadOnly = true;                     // 整張表格不可編輯
            dataGridView1.AllowUserToAddRows = false;         // 不可新增
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 一次選整列
            string sql = @"
        SELECT 
            m.MemberAccount, 
            m.NickName,
            o.*         
        FROM Orders o
        JOIN Member m ON o.MemberID = m.MemberID
        WHERE (@kw = '') 
              OR (CAST(o.MemberID AS NVARCHAR) LIKE @kw 
              OR m.MemberAccount LIKE @kw 
              OR m.NickName LIKE @kw)";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["OrderID"].HeaderText = "訂單編號";
                    dataGridView1.Columns["MemberID"].HeaderText = "會員ID";
                    dataGridView1.Columns["MemberAccount"].HeaderText = "會員帳號";
                    dataGridView1.Columns["NickName"].HeaderText = "暱稱";
                    dataGridView1.Columns["OrderDate"].HeaderText = "訂單日期";
                    dataGridView1.Columns["OrderStatus"].HeaderText = "訂單狀態";
                    dataGridView1.Columns["PaymentStatus"].HeaderText = "付款狀態";
                    dataGridView1.Columns["TotalAmount"].HeaderText = "總金額";
                    dataGridView1.Columns["Receiver"].HeaderText = "收件人";
                    dataGridView1.Columns["Address"].HeaderText = "地址";
                    dataGridView1.Columns["DeliveryMethod"].HeaderText = "配送方式";
                    dataGridView1.Columns["ReceiverAddress"].HeaderText = "收件門市或地址";
                    dataGridView1.Columns["InvoiceType"].HeaderText = "發票型式";
                    dataGridView1.Columns["TaxID"].HeaderText = "統一編號";
                    dataGridView1.Columns["Note"].HeaderText = "備註";


                    // 設定欄位寬度與顯示模式
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("載入失敗：" + ex.Message);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string col = dataGridView1.Columns[e.ColumnIndex].Name;

            if (col == "MemberAccount")
            {
                e.CellStyle.ForeColor = Color.Blue;
                e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Underline);
            }

            // ✅ 訂單狀態轉文字
            if (col == "OrderStatus" && e.Value is byte val1)
            {
                e.Value = val1 == 0 ? "未出貨" : val1 == 1 ? "出貨中" : "已完成";
            }

            if (col == "PaymentStatus" && e.Value is byte val2)
            {
                e.Value = val2 == 0 ? "未付款" : val2 == 1 ? "已付款" : "未知付款狀態";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            // 如果點的是 MemberID 或 MemberAccount 欄位
            if (colName == "MemberID" || colName == "MemberAccount")
            {
                string memberId = dataGridView1.Rows[e.RowIndex].Cells["MemberID"].Value.ToString();
                FormOrderDetails frm = new FormOrderDetails(memberId);
                frm.ShowDialog();
            }
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchMember.Text.Trim();
            LoadOrders(keyword); // ✅ 傳入關鍵字查詢
        }

        private void txtSearchMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick(); // 等同點查詢
            }
        }
    }
    
}
