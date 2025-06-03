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
            RE_dataGridView1.DataSource = RE_DataSearch.LoadhWorkOrder();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
         RE_dataGridView1.DataSource = RE_DataSearch.WorkOrderSearch((string)ER_comboBox1.SelectedItem, ER_SearchT.Text);
        }
    }
}
