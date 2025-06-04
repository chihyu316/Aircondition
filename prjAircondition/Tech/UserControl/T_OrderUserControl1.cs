using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            // 先載入技師資料 (供Label用)
            this.techniciansTableAdapter1.Fill(this.t_ACDataSet1.Technicians);
            this.techniciansBindingSource.DataSource = this.t_ACDataSet1.Technicians;

            // 讓Label自動綁定師傅名稱
            this.labelTechNameInWorkOrder.DataBindings.Add("Text", techniciansBindingSource, "name");

            // 預設顯示全部
            // 串好workOrder中介點
            // 先在 Form_Load (UserControl_Load) 中做綁定：
            this.workOrderBindingSource.DataSource = this.t_ACDataSet1.WorkOrder;
            this.workOrderDataGridView.DataSource = this.workOrderBindingSource;

            //先載入資料 再進行綁定binding source才不會報錯
            this.workOrderTableAdapter.Fill(this.t_ACDataSet1.WorkOrder);

            //綁定UI
            this.WorkOrdertextBox.DataBindings.Add("Text", workOrderBindingSource, "TechnicianID");

            // 載入工作類型資料表
            // 這裡是把 WorkTypes 資料撈進 DataSet
            this.workTypeTableAdapter1.Fill(this.t_ACDataSet1.WorkType);

            //設定binding
            BindWorkTypeComboBox();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FilterWorkOrders();
        }

        private void BindWorkTypeComboBox()
        {
            // 只在資料表為空時插入「全部」
            if (this.t_ACDataSet1.WorkType.Rows.Count == 0)
            {
                //先在comboBox加入全部選項
                // 先在資料載入後插入一筆「全部」
                DataRow newRow = this.t_ACDataSet1.WorkType.NewRow();
                //增加一筆 資料含有這兩個欄位到這個資料表
                newRow["WorkTypeID"] = 0;  // 0 代表全部
                newRow["WorkType"] = "全部";
                this.t_ACDataSet1.WorkType.Rows.InsertAt(newRow, 0);
            }

            //先綁好資料表
            this.workTypeBindingSource1.DataSource = this.t_ACDataSet1.WorkType;

            // 讓 ComboBox 綁定離線 這個資料中界點
            WorkTypeComboBox.DataSource = this.workTypeBindingSource1;
            // 給使用者看的文字 比如 1-維修 2-安裝 顯示欄位  給使用者看到的名稱
            this.WorkTypeComboBox.DisplayMember = "WorkType";
            //實際上拿到的是ID TODO
            WorkTypeComboBox.ValueMember = "WorkTypeID";
        }

        //去撈索引 comboBox去撈對應的工單類型資料
        private void WorkTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterWorkOrders();
        }

        //textBox變化 id變化時 重新比對  WorkTypeComboBox內容(0全部時) 和這個 WorkOrdertextBox
        //直接進行資料篩選
        private void WorkOrdertextBox_TextChanged(object sender, EventArgs e)
        {
            //先確認輸入是否正確

            // 先取得目前師傅ID
            //當 techniciansBindingSource.Position 改變時，自動把該筆 Position 下的 name 欄位值指定到 Label.Text 上
            // ★ 讓師傅名字自動更新

            //inputTechID = 2（使用者輸入了 2）
            //Find() 會去 techniciansBindingSource 裡面找：

            ////有沒有哪一筆 "T_id" 欄位的值等於 2 比如找師傅id2
            ////techniciansBindingSource 也會去移動到 T_id為 2的那筆資料
            ////那筆資料Position為1

            ////pos等於傳回 具有指定屬性名稱和值得項目索引
            // 1. 移動技師BindingSource → 讓Label更新
            if (int.TryParse(this.WorkOrdertextBox.Text, out int inputTechID) && inputTechID > 0)
            {
                int pos = techniciansBindingSource.Find("T_id", inputTechID);
                techniciansBindingSource.Position = (pos >= 0) ? pos : -1;
            }
            else
            {
                techniciansBindingSource.Position = -1;
            }
            // 2. 繼續執行工單篩選邏輯
            FilterWorkOrders();
        }

        //更新資料
        private void UpdateTechnicianNameByID(int techID)
        {
            int pos = techniciansBindingSource.Find("T_id", techID);
            techniciansBindingSource.Position = (pos >= 0) ? pos : -1;
        }

        private void FilterWorkOrders()
        {
            bool validTechID = int.TryParse(this.WorkOrdertextBox.Text, out int inputTechID) && inputTechID > 0;
            // 取得目前 ComboBox 選擇的 WorkTypeID
            int workTypeID = 0;

            if (this.WorkTypeComboBox.SelectedItem is DataRowView drv)
            {
                //轉換這個欄位資料到int 給這個變數
                workTypeID = Convert.ToInt32(drv["WorkTypeID"]);
            }
            else
            {
                workTypeID = Convert.ToInt32(this.WorkTypeComboBox.SelectedValue);
            }

            if (validTechID)
                UpdateTechnicianNameByID(inputTechID);
            else
                techniciansBindingSource.Position = -1;

            //不合法時全部載入 不用管comboBOx內容
            if (!validTechID)
            {
                // TechID 不合法時，直接載入全部工單
                MessageBox.Show("師傅ID無效，顯示全部工單資料");
                this.workOrderTableAdapter.FillByAllWorkOrderWithTechnicians(this.t_ACDataSet1.WorkOrder);
                return;
            }

            //有師傅ID情況下
            if (workTypeID == 0)
            {
                // 全部工單（該師傅所有訂單）
                // 只用 TechID
                this.workOrderTableAdapter.FillByCertainTechAllWorkOrders(this.t_ACDataSet1.WorkOrder, inputTechID);
            }
            else
            {
                // 該師傅 + 特定工作類型
                this.workOrderTableAdapter.FillByTechnicianIDAndWorkTypeID(this.t_ACDataSet1.WorkOrder, inputTechID, workTypeID);
            }

            // ✅ 這裡就是你要插入提示的地方：
            if (this.t_ACDataSet1.WorkOrder.Rows.Count == 0)
            {
                MessageBox.Show("查無符合的訂單資料。");
            }
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

        private void workOrderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.workOrderlabel.Text = $"{this.workOrderBindingSource.Position + 1} / {this.workOrderBindingSource.Count}";
        }
    }
}