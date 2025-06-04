using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters;
using prjAircondition.Tech.DataSet;
using prjAircondition.Dicuss.DataSet;

namespace prjAircondition
{
    public partial class FormTech : Form
    {
        public FormTech()
        {
            InitializeComponent();
        }

        private void FormTech_Load(object sender, EventArgs e)
        {
            techniciansTableAdapter1.Fill(t_ACDataSet11.Technicians);
            this.techbindingSource1.DataSource = this.t_ACDataSet11.Technicians;
            BindUI();
        }

        private void BindUI()
        {
            userNameTextBox.DataBindings.Add("Text", techbindingSource1, "name");
            NickNameTextBox.DataBindings.Add("Text", techbindingSource1, "NickName");
            phone_textBox.DataBindings.Add("Text", techbindingSource1, "phone");
            techAccountTextBox.DataBindings.Add("Text", techbindingSource1, "account");
            PasswordtextBox.DataBindings.Add("Text", techbindingSource1, "password");
            AddresstextBox.DataBindings.Add("Text", techbindingSource1, "address");
            emailTextBox.DataBindings.Add("Text", techbindingSource1, "email");
            cmdGender.DataBindings.Add("Text", techbindingSource1, "gender");
            createdAtPicker.DataBindings.Add("Value", techbindingSource1, "created_at", true, DataSourceUpdateMode.OnValidation, DateTime.Now);
            updatedAtPicker.DataBindings.Add("Value", techbindingSource1, "", true, DataSourceUpdateMode.OnValidation, DateTime.Now);
        }

        //建立暫存
        private void btnAddTemp_Click(object sender, EventArgs e)
        {
            //DataRow newRow = t_ACDataSet11.Technicians.NewRow();

            //// 注意！此時不設定 created_at、updated_at 讓它維持空值 (DBNull)
            //t_ACDataSet11.Technicians.Rows.Add(newRow);
            //techbindingSource1.MoveLast();

            // 透過 BindingSource 直接產生新的一筆
            var newRowView = (DataRowView)techbindingSource1.AddNew();
            newRowView["created_at"] = DateTime.Now;
            newRowView["updated_at"] = DateTime.Now;

            //移動到最後一筆
            techbindingSource1.MoveLast();

            // 新增時仍隱藏時間
            createdAtPicker.Visible = false;
            updatedAtPicker.Visible = false;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (techbindingSource1.Current == null)
            {
                MessageBox.Show("目前沒有可更新的資料");
                return;
            }

            // 取目前資料行
            DataRowView currentRowView = (DataRowView)techbindingSource1.Current;

            //檢查這筆資料 是不是有創立過了
            bool isNew = (currentRowView["created_at"] == DBNull.Value);
            DateTime now = DateTime.Now;

            if (isNew)
            {
                // 第一次存檔
                currentRowView["created_at"] = now;
                currentRowView["updated_at"] = now;
            }
            else
            {
                // 之後只更新 updated_at
                currentRowView["updated_at"] = now;
            }

            // 讓時間欄位出現
            createdAtPicker.Value = Convert.ToDateTime(currentRowView["created_at"]);
            updatedAtPicker.Value = Convert.ToDateTime(currentRowView["updated_at"]);
            createdAtPicker.Visible = true;
            updatedAtPicker.Visible = true;

            // 存回資料庫
            this.Validate();
            techbindingSource1.EndEdit();
            techniciansTableAdapter1.Update(t_ACDataSet11.Technicians);

            MessageBox.Show("資料已更新");
        }
    }
}