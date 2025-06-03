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
using prjAircondition.Properties;

namespace prjAircondition
{
    public partial class C_FrmAddnewC : Form
    {
        public C_FrmAddnewC()
        {
            InitializeComponent();

        }

        private void C_FrmAddnewC_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'c_RecruitDataSet.CourseCategory' 資料表。您可以視需要進行移動或移除。
            this.courseCategoryTableAdapter.Fill(this.c_RecruitDataSet.CourseCategory);
            
            //課程級別
            List<string> levels = new List<string> {"初級","中級","高級"};
            foreach (string level in levels)
            {
                this.comboBox2.Items.Add( level);
            }
            this.comboBox2.SelectedIndex = 0;
        }
    }
}
