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
    public partial class C_FrmAddnewC : Form
    {
        public C_FrmAddnewC()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.c_RecruitDataSet);

        }

        private void C_FrmAddnewC_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'c_RecruitDataSet.Course' 資料表。您可以視需要進行移動或移除。
            if()
            this.courseTableAdapter.Fill(this.c_RecruitDataSet.Course);

        }
    }
}
