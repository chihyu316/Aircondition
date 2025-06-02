using prjAircondition.Tech.DataSet;

namespace prjAircondition.Tech
{
    partial class T_OrderUserControl1
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t_ACDataSet1 = new prjAircondition.Tech.DataSet.T_ACDataSet();
            this.workTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansTableAdapter1 = new prjAircondition.Tech.DataSet.T_ACDataSetTableAdapters.TechniciansTableAdapter();
            this.workTypeTableAdapter1 = new prjAircondition.Tech.DataSet.T_ACDataSetTableAdapters.WorkTypeTableAdapter();
            this.workOrderTableAdapter1 = new prjAircondition.Tech.DataSet.T_ACDataSetTableAdapters.WorkOrderTableAdapter();
            this.workOrderlabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WorkOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.WorkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.labelTechNameInWorkOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t_ACDataSet1
            // 
            this.t_ACDataSet1.DataSetName = "T_ACDataSet";
            this.t_ACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techniciansTableAdapter1
            // 
            this.techniciansTableAdapter1.ClearBeforeFill = true;
            // 
            // workTypeTableAdapter1
            // 
            this.workTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // workOrderTableAdapter1
            // 
            this.workOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // workOrderlabel
            // 
            this.workOrderlabel.AutoSize = true;
            this.workOrderlabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workOrderlabel.Location = new System.Drawing.Point(297, 249);
            this.workOrderlabel.Name = "workOrderlabel";
            this.workOrderlabel.Size = new System.Drawing.Size(64, 28);
            this.workOrderlabel.TabIndex = 16;
            this.workOrderlabel.Text = "1/10";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(518, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(163, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(394, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WorkOrderDataGridView
            // 
            this.WorkOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkOrderDataGridView.Location = new System.Drawing.Point(30, 324);
            this.WorkOrderDataGridView.Name = "WorkOrderDataGridView";
            this.WorkOrderDataGridView.RowHeadersWidth = 62;
            this.WorkOrderDataGridView.RowTemplate.Height = 31;
            this.WorkOrderDataGridView.Size = new System.Drawing.Size(801, 531);
            this.WorkOrderDataGridView.TabIndex = 10;
            // 
            // WorkTypeComboBox
            // 
            this.WorkTypeComboBox.FormattingEnabled = true;
            this.WorkTypeComboBox.Location = new System.Drawing.Point(210, 181);
            this.WorkTypeComboBox.Name = "WorkTypeComboBox";
            this.WorkTypeComboBox.Size = new System.Drawing.Size(306, 36);
            this.WorkTypeComboBox.TabIndex = 11;
            // 
            // labelTechNameInWorkOrder
            // 
            this.labelTechNameInWorkOrder.AutoSize = true;
            this.labelTechNameInWorkOrder.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTechNameInWorkOrder.Location = new System.Drawing.Point(201, 108);
            this.labelTechNameInWorkOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTechNameInWorkOrder.Name = "labelTechNameInWorkOrder";
            this.labelTechNameInWorkOrder.Size = new System.Drawing.Size(165, 37);
            this.labelTechNameInWorkOrder.TabIndex = 6;
            this.labelTechNameInWorkOrder.Text = "師傅名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "師傅:";
            // 
            // workType
            // 
            this.workType.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workType.Location = new System.Drawing.Point(38, 177);
            this.workType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workType.Name = "workType";
            this.workType.Size = new System.Drawing.Size(165, 37);
            this.workType.TabIndex = 8;
            this.workType.Text = "工作類型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "訂單資料";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // T_OrderUserControl1
            // 
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.workOrderlabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WorkOrderDataGridView);
            this.Controls.Add(this.WorkTypeComboBox);
            this.Controls.Add(this.labelTechNameInWorkOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "T_OrderUserControl1";
            this.Size = new System.Drawing.Size(1215, 1075);
            this.Load += new System.EventHandler(this.T_OrderUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private T_ACDataSet t_ACDataSet1;
        private System.Windows.Forms.BindingSource workTypeBindingSource1;
        private DataSet.T_ACDataSetTableAdapters.TechniciansTableAdapter techniciansTableAdapter1;
        private DataSet.T_ACDataSetTableAdapters.WorkTypeTableAdapter workTypeTableAdapter1;
        private DataSet.T_ACDataSetTableAdapters.WorkOrderTableAdapter workOrderTableAdapter1;
        private System.Windows.Forms.Label workOrderlabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView WorkOrderDataGridView;
        private System.Windows.Forms.ComboBox WorkTypeComboBox;
        private System.Windows.Forms.Label labelTechNameInWorkOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label workType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource workOrderBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}   