using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Tech
{
    public partial class T_OrderUserControl1 : UserControl
    {
        //要配對的師傅id
        public int techID;

        public T_OrderUserControl1()
        {
            InitializeComponent();
        }

        private void workOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t_ACDataSet1);
        }

        private void T_OrderUserControl1_Load(object sender, EventArgs e)
        {
            // 預設顯示全部
            // 串好workOrder中介點
            // 先在 Form_Load (UserControl_Load) 中做綁定：
            this.workOrderBindingSource.DataSource = this.t_ACDataSet1.WorkOrder;
            this.workOrderDataGridView.DataSource = this.workOrderBindingSource;
            this.workOrderTableAdapter.Fill(this.t_ACDataSet1.WorkOrder);

            //綁定UI
            this.labelTechNameInWorkOrder.DataBindings.Add("Text", workOrderBindingSource, "TechnicianName");
            this.WorkOrdertextBox.DataBindings.Add("Text", workOrderBindingSource, "TechnicianID");

            // 載入工作類型資料表
            // 這裡是把 WorkTypes 資料撈進 DataSet
            this.workTypeTableAdapter1.Fill(this.t_ACDataSet1.WorkType);

            //設定binding
            BindWorkTypeComboBox();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.WorkOrdertextBox.Text, out int inputTechID))
            {
                // 儲存技師ID (後面 ComboBox會用到)
                this.techID = inputTechID;

                // 預設查詢該技師所有訂單
                this.workOrderTableAdapter.FillByCertainTechAllWorkOrders(this.t_ACDataSet1.WorkOrder, techID);
            }
            else
            {
                // 如果沒有輸入正確 ID，就重新載入全部訂單
                this.workOrderTableAdapter.FillByAllWorkOrderWithTechnicians(this.t_ACDataSet1.WorkOrder);
            }
        }

        private void BindWorkTypeComboBox()
        {
            //先在comboBox加入全部選項
            // 先在資料載入後插入一筆「全部」
            DataRow newRow = this.t_ACDataSet1.WorkType.NewRow();
            //增加一筆 資料含有這兩個欄位到這個資料表
            newRow["WorkTypeID"] = 0;  // 0 代表全部
            newRow["WorkType"] = "全部";
            this.t_ACDataSet1.WorkType.Rows.InsertAt(newRow, 0);

            //先綁好資料表
            this.workTypeBindingSource1.DataSource = this.t_ACDataSet1.WorkType;

            // 讓 ComboBox 綁定離線 這個資料中界點
            WorkTypeComboBox.DataSource = this.workTypeBindingSource1;
            // 給使用者看的文字 比如 1-維修 2-安裝 顯示欄位
            this.WorkTypeComboBox.DisplayMember = "WorkType";
            //實際上拿到的是ID TODO
            WorkTypeComboBox.ValueMember = "WorkTypeID";
            // 實際代表的值 (當 SelectedValue 取出時拿到的是 WorkTypeID)
        }

        //去撈索引 comboBox去撈對應的工單類型資料
        private void WorkTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkTypeComboBox.SelectedValue != null)
            {
                //先初始化為0
                int workTypeID = 0;
                // 這種情況表示你 DataSource 綁在 BindingSource (也就是 workTypeBindingSource1)
                // 你需要從 DataRowView 取出 WorkTypeID 欄位值
                // 綁定int型別的欄位 轉object 因為裡面可能是Null或別的只能用Convert.toInt32
                // 底下錯誤示範
                // int workTypeID = (int)WorkTypeComboBox.SelectedValue;

                //dateRow物件要[""] 欄位轉換成int
                if (WorkTypeComboBox.SelectedItem is DataRowView drv)
                {
                    workTypeID = Convert.ToInt32(drv["WorkTypeID"]);
                }
                else
                {
                    workTypeID = Convert.ToInt32(WorkTypeComboBox.SelectedValue);
                }

                if (workTypeID == 0)
                {
                    //全部工單（依照技師ID是否有值）
                    if (techID > 0)
                        this.workOrderTableAdapter.FillByCertainTechAllWorkOrders(this.t_ACDataSet1.WorkOrder, techID);
                    else
                        this.workOrderTableAdapter.FillByAllWorkOrderWithTechnicians(this.t_ACDataSet1.WorkOrder);
                }
                else
                {
                    // 師傅ID需有值才能做此查詢
                    if (techID > 0)
                    {
                        this.workOrderTableAdapter.FillByTechnicianIDAndWorkTypeID(this.t_ACDataSet1.WorkOrder, techID, workTypeID);
                    }
                }
            }
        }

        //textBox變化 id變化時 重新比對  WorkTypeComboBox 和這個 WorkOrdertextBox
        //去找師傅 資料
        private void WorkOrdertextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void WorkOrderbutton1_Click(object sender, EventArgs e)
        {
            this.workOrderBindingSource.Position = 0;
        }

        private void WorkOrderbutton2_Click(object sender, EventArgs e)
        {
            this.workOrderBindingSource.Position -= 1;
        }

        private void WorkOrderbutton3_Click(object sender, EventArgs e)
        {
            this.workOrderBindingSource.Position += 1;
        }

        //最後一筆索引位置
        private void WorkOrderbutton4_Click(object sender, EventArgs e)
        {
            this.workOrderBindingSource.Position = this.workOrderBindingSource.Count - 1;
        }
    }
}