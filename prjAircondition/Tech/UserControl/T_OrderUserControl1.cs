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
            // 檢查 DataGridView 是否已經有 WorkTypeName 欄位，避免重複加入
            if (!workOrderDataGridView.Columns.Contains("WorkTypeName"))
            {
                DataGridViewTextBoxColumn workTypeNameColumn = new DataGridViewTextBoxColumn();
                workTypeNameColumn.DataPropertyName = "WorkTypeName"; // 資料來源欄位名
                workTypeNameColumn.HeaderText = "工作類型";            // 顯示在表頭
                workOrderDataGridView.Columns.Add(workTypeNameColumn);
            }

            // 先載入師傅資料 (供Label用)
            this.techniciansTableAdapter1.Fill(this.t_ACDataSet1.Technicians);
            this.techniciansBindingSource.DataSource = this.t_ACDataSet1.Technicians;

            // 讓Label自動綁定師傅名稱
            this.labelTechNameInWorkOrder.DataBindings.Add("Text", techniciansBindingSource, "name");

            // 預設顯示全部工單資料
            // 串好workOrder中介點
            // 先在 Form_Load (UserControl_Load) 中做綁定：
            this.workOrderBindingSource.DataSource = this.t_ACDataSet1.WorkOrder;
            this.workOrderDataGridView.DataSource = this.workOrderBindingSource;

            //先載入欄位資料 再進行綁定binding source才不會報錯
            this.workOrderTableAdapter.FillByAllWorkOrderWithTechnicians(this.t_ACDataSet1.WorkOrder);

            //綁定UI

            // 載入工作類型資料表
            // 這裡是把 WorkTypes 資料撈進 DataSet
            this.workTypeTableAdapter1.Fill(this.t_ACDataSet1.WorkType);

            //設定binding
            BindWorkTypeComboBox();
        }

        private void BindWorkTypeComboBox()
        {
            // 只在資料表為空時插入「全部」選項到comboBox

            // 檢查是否有 全部這個選項
            // AsEnumerable Linq寫法傳回 可列舉的DataRow物件
            bool hasAllItem = this.t_ACDataSet1.WorkType.AsEnumerable().Any(row => Convert.ToInt32(row["WorkTypeID"]) == 0);

            if (!hasAllItem)
            {
                //先在comboBox加入全部選項
                // 先在資料載入後插入一筆「全部」
                DataRow newRow = this.t_ACDataSet1.WorkType.NewRow();
                //增加一筆 資料含有這兩個欄位到這個資料表
                newRow["WorkTypeID"] = 0;  // 0 代表全部
                newRow["WorkType"] = "全部";
                //這筆資料插入第一筆
                this.t_ACDataSet1.WorkType.Rows.InsertAt(newRow, 0);
            }

            //先綁好資料表
            this.workTypeBindingSource1.DataSource = this.t_ACDataSet1.WorkType;

            // 讓 ComboBox 綁定離線 這個資料中界點
            WorkTypeComboBox.DataSource = this.workTypeBindingSource1;
            // 給使用者看的文字 比如 1-維修 2-安裝 顯示欄位  給使用者看到的名稱
            this.WorkTypeComboBox.DisplayMember = "WorkType";
            //實際上定的是ID TODO
            WorkTypeComboBox.ValueMember = "WorkTypeID";
        }

        private void WorkOrdertextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void WorkTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterWorkOrders();
        }

        //重載全部訂單
        private void ReloadAllOrders()
        {
            this.workOrderTableAdapter.FillByAllWorkOrderWithTechnicians(this.t_ACDataSet1.WorkOrder);
        }

        private void FilterWorkOrders()
        {
            if (!int.TryParse(this.WorkOrderTechIDtextBox.Text.Trim(), out int inputTechID))
            {
                // 基本上已在 TextChanged 做過檢查，理論上不會進來這段
                ReloadAllOrders();
                return;
            }
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

            //有師傅ID情況下
            if (workTypeID == 0)
            {
                // 全部工單（該師傅所有訂單）
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
                MessageBox.Show("師傅沒有這類型的訂單");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string input = this.WorkOrderTechIDtextBox.Text.Trim();

            //查看輸入格式是空白或是非數字

            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int inputTechID))
            {
                MessageBox.Show("輸入格式不得為空白或是數字以外的其他字元，重新載入全部訂單");
                ReloadAllOrders();
                WorkOrderTechIDtextBox.Clear(); //清空id
                return;
            }

            // 師傅是否存在 找不到時為-1
            int pos = techniciansBindingSource.Find("T_id", inputTechID);
            if (pos < 0)
            {
                MessageBox.Show("查無此師傅資料，請重新輸入有效id，已重新載入全部訂單");
                ReloadAllOrders();

                return;
            }

            // 找到師傅，移動 BindingSource
            this.techniciansBindingSource.Position = pos;
            // 正常篩選
            FilterWorkOrders();
        }

        //去撈索引 comboBox去撈對應的工單類型資料

        //textBox變化 id變化時 重新比對  WorkTypeComboBox內容(0全部時) 和這個 WorkOrdertextBox
        //直接進行資料篩選

        //更新資料
        private void UpdateTechnicianNameByID(int techID)
        {
            int pos = techniciansBindingSource.Find("T_id", techID);
            techniciansBindingSource.Position = (pos >= 0) ? pos : -1;
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

        private void workOrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (workOrderBindingSource.Current is DataRowView drv)
            {
                // 從目前選取的訂單資料中取得 TechnicianID
                int technicianID = drv["TechnicianID"] != DBNull.Value ? Convert.ToInt32(drv["TechnicianID"]) : -1;

                // 在 techniciansBindingSource 裡尋找對應師傅
                int pos = techniciansBindingSource.Find("T_id", technicianID);

                if (pos >= 0)
                {
                    // 取得師傅名字
                    DataRowView techRow = (DataRowView)techniciansBindingSource[pos];
                    string technicianName = techRow["name"].ToString();

                    labelTechNameInWorkOrder.Text = technicianName;
                }
                else
                {
                    labelTechNameInWorkOrder.Text = "(未知師傅)";
                }
            }
            else
            {
                labelTechNameInWorkOrder.Text = "(無資料)";
            }
        }
    }
}