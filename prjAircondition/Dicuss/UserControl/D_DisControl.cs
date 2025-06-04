using prjAircondition.Dicuss.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Dicuss
{
    public partial class D_DisControl : UserControl
    { 
        public D_DisControl()
        {   
            InitializeComponent();
            D_PostdataGridView.DataSource = D_DataConnect.LoadhPostmain();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void D_Btn_Date_Click(object sender, EventArgs e)
        {

        }
    }
}
