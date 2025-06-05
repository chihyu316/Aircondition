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

namespace prjAircondition
{
    public partial class D_ReplyControl : UserControl
    {
        //public static  string UserID { get; set; }
        public D_ReplyControl(string UserID)
        {
            InitializeComponent();
            dataGridView1.DataSource = D_DataConnect.LoadhPostmain();
            NickNameT.Text = UserID;
            PostSortCombo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Insert_Post_Click(object sender, EventArgs e)
        {
            D_DataConnect.PostInsert(NickNameT.Text, (string)PostSortCombo.SelectedItem,TitleT.Text, ContextT.Text);
        }
    }
}
