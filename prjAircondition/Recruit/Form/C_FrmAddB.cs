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
    public partial class C_FrmAddB : Form
    {
        public C_FrmAddB()
        {
            InitializeComponent();
        }

        private void courseBatchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBatchBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.c_RecruitDataSet);

        }

        private void C_FrmAddB_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'c_RecruitDataSet.CourseBatch' 資料表。您可以視需要進行移動或移除。
            this.courseBatchTableAdapter.Fill(this.c_RecruitDataSet.CourseBatch);
            this.courseBatchBindingSource.AddNew();

            LoadCategory();
        }
        private void LoadCategory() 
        {

        }
    }
}
