using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition
{
    public partial class C_FrmEdit : Form
    {
        public C_FrmEdit()
        {
            InitializeComponent();
            //LoadData();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.c_RecruitDataSet);
            this.courseTableAdapter1.Fill(this.c_RecruitDataSet.Course);
            this.courseBindingSource.DataSource=this.c_RecruitDataSet;
        }
    }
}
