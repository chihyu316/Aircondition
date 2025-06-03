using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  呼叫搜尋結果
            DataTable result = RE_DataSearch.WorkOrderSearch((string)ER_comboBox1.SelectedItem, ER_SearchT.Text);

            //  綁定結果到 DataGridView
            RE_dataGridView1.DataSource = result;

            //  顯示筆數到 Label
            ER_lblCount.Text = $"共 {result.Rows.Count} 筆資料";
        }
    }
}
