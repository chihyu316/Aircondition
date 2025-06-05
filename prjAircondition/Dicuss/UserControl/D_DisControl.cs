using prjAircondition.Dicuss.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
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
            D_PostdataGridView.ReadOnly = true;                  
            D_PostdataGridView.AllowUserToAddRows = false;       
            D_PostdataGridView.AllowUserToDeleteRows = false;    
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
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void PostMaindataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (D_PostdataGridView.CurrentRow != null)
            {
                DataGridViewRow row = D_PostdataGridView.CurrentRow;

                D_ListTitleT.Text = row.Cells["文章標題"].Value?.ToString();
                D_ListSortT.Text = row.Cells["文章類型"].Value?.ToString();
                D_ListUserT.Text = row.Cells["發文者"].Value?.ToString();
                D_ListContextT.Text = row.Cells["文章內容"].Value?.ToString();
                var status = row.Cells["文章狀態"].Value?.ToString();
                if (D_PL_Combobox.Items.Contains(status))
                {
                    D_PL_Combobox.SelectedItem = status;
                }
            }
        }

        private void D_BTN_Update_Click(object sender, EventArgs e)
        {
            D_DataConnect.PostUpdate((string)D_PL_Combobox.SelectedItem,D_ListUserT.Text,D_ListTitleT.Text);
            D_PostdataGridView.DataSource = D_DataConnect.LoadhPostmain();
        }

        private void D_BTN_Delete_Click(object sender, EventArgs e)
        {
            if (D_PostdataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = D_PostdataGridView.SelectedRows[0];
                int postId = Convert.ToInt32(selectedRow.Cells["文章編號"].Value);
                D_DataConnect.PostDelete(postId);
                D_PostdataGridView.DataSource = D_DataConnect.LoadhPostmain();
            }
            else 
            {
                MessageBox.Show("請選擇要刪除的文章。");
            }
        }
    }
}
