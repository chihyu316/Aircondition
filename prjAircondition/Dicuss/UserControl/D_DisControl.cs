using prjAircondition.Dicuss.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.D_PostdataGridView.DataSource = D_DataConnect.SerchPost();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void D_button1_Click(object sender, EventArgs e)
        {

        }

        private void D_buttoserchuser_Click(object sender, EventArgs e)
        {

            this.D_PostdataGridView.DataSource = D_DataConnect.SerchPostUser(D_textUserT.Text);  
        }

        private void D_buttonSearchTitle_Click(object sender, EventArgs e)
        {
            this.D_PostdataGridView.DataSource = D_DataConnect.SerchPostTitle(D_textTitleT.Text);
        }
    }
}
