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
        //傳進來的師傅編號
        public string TechAccount { get; set; }

        //要配對的師傅id
        public int techID;

        //不過這邊要用id判斷訂單資料
        public T_OrderUserControl1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void OrderUserControl1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TechAccount))
            {
                //先取得那 師傅資料欄位中的id 再來做載入訂單動作
                techID = GetTechnicianIDByAccount(TechAccount);
                //載入師傅的訂單
                LoadOrders(techID);

                // 先把 離線 師傅資料表 以帳號叫出來
                //把欄位name抓出來給labelTechName.Text
                this.techniciansTableAdapter1.FillByAccount(this.t_ACDataSet1.Technicians, TechAccount);
                if (this.t_ACDataSet1.Technicians.Rows.Count > 0)
                {
                    string techName = this.t_ACDataSet1.Technicians[0].name;
                    labelTechName.Text = techName;
                }
            }

            //串好workOrder中介點
            // 先在 Form_Load (UserControl_Load) 中做綁定：

            this.workOrderBindingSource.DataSource = this.t_ACDataSet1.WorkOrder;
            this.WorkOrderDataGridView.DataSource = this.workOrderBindingSource;

            //載入工作類型資料表
            // 這裡是把 WorkTypes 資料撈進 DataSet
            this.workTypeTableAdapter1.Fill(this.t_ACDataSet1.WorkType);
=======
        private void T_OrderUserControl1_Load(object sender, EventArgs e)
        {
            // 預設顯示全部
            // 串好workOrder中介點
            // 先在 Form_Load (UserControl_Load) 中做綁定：
            this.workOrderBindingSource1.DataSource = this.t_ACDataSet1.WorkOrder;
            this.workOrderDataGridView.DataSource = this.workOrderBindingSource1;
            this.workOrderTableAdapter1.FillByAllWorkOrderWithTechnicians(this.t_ACDataSet1.WorkOrder);

            //綁定UI
            this.labelTechNameInWorkOrder.DataBindings.Add("Text", workOrderBindingSource1, "TechnicianName");
            this.WorkOrdertextBox.DataBindings.Add("Text", workOrderBindingSource1, "TechnicianID");

            // 載入工作類型資料表
            // 這裡是把 WorkTypes 資料撈進 DataSet
            this.workTypeTableAdapter1.Fill(this.t_ACDataSet1.WorkType);
            //把所有資料撈出來
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5

            //設定binding
            BindWorkTypeComboBox();
        }

<<<<<<< HEAD
=======
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.WorkOrdertextBox.Text, out int techID))
            {
                // 只用師傅ID先撈全部
                this.workOrderTableAdapter1.FillByCertainTechAllWorkOrders(this.t_ACDataSet1.WorkOrder, techID);
            }
            else
            {
                MessageBox.Show("請輸入有效的師傅ID");
                this.t_ACDataSet1.WorkOrder.Clear();
            }
        }

>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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
<<<<<<< HEAD
            // 給使用者看的文字 比如 1-維修 2-安裝
=======
            // 給使用者看的文字 比如 1-維修 2-安裝 顯示欄位
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
            this.WorkTypeComboBox.DisplayMember = "WorkType";
            //實際上拿到的是ID
            WorkTypeComboBox.ValueMember = "WorkTypeID";      // 實際代表的值 (當 SelectedValue 取出時拿到的是 WorkTypeID)
        }

        //去撈索引 comboBox去撈對應的工單類型資料
<<<<<<< HEAD
        private void WorkTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkTypeComboBox.SelectedValue != null)
            {
=======
        //重新讀取目前 UI 上的 WorkOrdertextBoxWorkOrdertextBox

        private void WorkTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (WorkTypeComboBox.SelectedValue != null)
            {
                if (!int.TryParse(this.WorkOrdertextBox.Text, out int techID))
                {
                    // 沒有有效師傅ID → 清空
                    this.t_ACDataSet1.WorkOrder.Clear();
                    return;
                }

>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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

<<<<<<< HEAD
                if (workTypeID == 0)
                {
                    // 如果選擇全部 -> 撈取該技師的所有訂單
                    this.workOrderTableAdapter1.FillByTechnicianID(this.t_ACDataSet1.WorkOrder, techID);
                }
                else
                {
                    // 否則正常按照 typeID 去撈
                    this.workOrderTableAdapter1.FillByTechnicianIDAndWorkTypeID(this.t_ACDataSet1.WorkOrder, techID, workTypeID);
=======
                int.TryParse(this.WorkOrdertextBox.Text, out int currentTechID);
                if (workTypeID == 0)
                {
                    //全部工單（依照技師ID是否有值）
                    if (techID > 0)
                        this.workOrderTableAdapter1.FillByCertainTechAllWorkOrders(this.t_ACDataSet1.WorkOrder, currentTechID);
                    else
                        this.workOrderTableAdapter1.FillByAllWorkOrderWithTechnicians(this.t_ACDataSet1.WorkOrder);
                }
                else
                {
                    // 交叉篩選：有技師ID與工單類型ID才做篩選
                    if (currentTechID > 0)
                    {
                        this.workOrderTableAdapter1.FillByTechnicianIDAndWorkTypeID(this.t_ACDataSet1.WorkOrder, currentTechID, workTypeID);
                    }
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
                }
            }
        }

<<<<<<< HEAD
        private int GetTechnicianIDByAccount(string account)
        {
            int id = -1;

            // 直接使用設計器裡拉好的物件，不用new
            this.techniciansTableAdapter1.FillByAccount(this.t_ACDataSet1.Technicians, account);

            if (this.t_ACDataSet1.Technicians.Rows.Count > 0)
            {
                //把我要的師傅id撈出來
                id = this.t_ACDataSet1.Technicians[0].T_id;
            }

            return id;
        }

        //再從訂單表 用T_id撈對應的訂單資料 先載入所有資料包含所有工單類型
        private void LoadOrders(int techID)
        {
            //把ID傳入到workOrder 把order資料撈出來
            this.workOrderTableAdapter1.FillByTechnicianID(this.t_ACDataSet1.WorkOrder, techID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workOrderBindingSource.Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.workOrderBindingSource.Position -= 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.workOrderBindingSource.Position += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //最後一筆資料
            this.workOrderBindingSource.Position = this.workOrderBindingSource.Count - 1;
        }

=======
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
        // 綁定在 BindingSource 物件的事件。
        // 當 BindingSource 目前所指向的「目前那一筆資料」改變時，會觸發 CurrentChanged 事件。
        // 也就是說：只要資料指標 (Position) 改變，CurrentChanged 就會被觸發。
        // 例如：按按鈕改變 Position、或是滑鼠直接點選 DataGridView 其他列，都會觸發此事件。
        // 注意：如果只是修改目前那筆資料的內容，但 Position 沒有改變，則不會觸發此事件。
        // 只負責監聽位置移動 (Position 改變)
<<<<<<< HEAD
        private void workOrderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //設定好label 顯示 第幾筆/ 共有幾筆
            this.workOrderlabel.Text = $"{this.workOrderBindingSource.Position + 1} / {this.workOrderBindingSource.Count}";
=======

        private void workOrderBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            //設定好label 顯示 第幾筆/ 共有幾筆
            this.workOrderlabel.Text = $"{this.workOrderBindingSource1.Position + 1} / {this.workOrderBindingSource1.Count}";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.workOrderBindingSource1.Position += 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.workOrderBindingSource1.Position = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.workOrderBindingSource1.Position -= 1;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //最後一筆資料
            this.workOrderBindingSource1.Position = this.workOrderBindingSource1.Count - 1;
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
        }
    }
}