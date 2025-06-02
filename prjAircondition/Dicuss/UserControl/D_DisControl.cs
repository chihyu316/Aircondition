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
            this.D_postsMainTableAdapter1.Fill(this.d_ACDataSet1.PostsMain);
            this.D_bindingSource1.DataSource = this.d_ACDataSet1.PostsMain;
            this.D_PostdataGridView.DataSource = this.D_bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void D_button1_Click(object sender, EventArgs e)
        {

        }

        private void D_buttoserchuser_Click(object sender, EventArgs e)
        {
            string connectstring = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectstring;
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from products", conn);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
