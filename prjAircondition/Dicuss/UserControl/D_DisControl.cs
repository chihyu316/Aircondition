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
            for (int year = 2020; year <= DateTime.Now.Year; year++)  
            comboBox1.Items.Add(year.ToString());
            for (int month = 1; month <= 12; month++) comboBox2.Items.Add(month.ToString("D2"));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void D_Btn_Date_Click(object sender, EventArgs e)
        {
            string TextSrc1=D_textTitleT.Text;
            string TextSrc2=D_textUserT.Text;
            string TextSrc3="";
            string year = comboBox1.SelectedItem?.ToString();
            string month = comboBox2.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                TextSrc3 = $"{year}-{month}";
            else if (!string.IsNullOrEmpty(year))
                TextSrc3 = year;
            else if (!string.IsNullOrEmpty(month))
                TextSrc3 = month;
             D_PostdataGridView.DataSource =D_DataConnect.PostMainSrc(TextSrc1, TextSrc2, TextSrc3);
        }
    }
}
