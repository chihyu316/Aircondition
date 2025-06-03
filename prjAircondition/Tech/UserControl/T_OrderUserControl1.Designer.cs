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
<<<<<<< HEAD
            this.WorkOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.WorkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.labelTechName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
=======
            this.WorkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.labelTechNameInWorkOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkOrdertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.workOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new prjAircondition.Tech.DataSet.T_ACDataSetTableAdapters.TableAdapterManager();
            this.workOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDataGridView)).BeginInit();
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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
<<<<<<< HEAD
=======
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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
<<<<<<< HEAD
=======
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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
<<<<<<< HEAD
=======
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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
<<<<<<< HEAD
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
=======
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
            // 
            // WorkTypeComboBox
            // 
            this.WorkTypeComboBox.FormattingEnabled = true;
            this.WorkTypeComboBox.Location = new System.Drawing.Point(210, 181);
            this.WorkTypeComboBox.Name = "WorkTypeComboBox";
<<<<<<< HEAD
            this.WorkTypeComboBox.Size = new System.Drawing.Size(306, 26);
            this.WorkTypeComboBox.TabIndex = 11;
            // 
            // labelTechName
            // 
            this.labelTechName.AutoSize = true;
            this.labelTechName.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTechName.Location = new System.Drawing.Point(201, 108);
            this.labelTechName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTechName.Name = "labelTechName";
            this.labelTechName.Size = new System.Drawing.Size(165, 37);
            this.labelTechName.TabIndex = 6;
            this.labelTechName.Text = "師傅名稱";
=======
            this.WorkTypeComboBox.Size = new System.Drawing.Size(306, 36);
            this.WorkTypeComboBox.TabIndex = 11;
            this.WorkTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.WorkTypeComboBox_SelectedIndexChanged_1);
            // 
            // labelTechNameInWorkOrder
            // 
            this.labelTechNameInWorkOrder.AutoSize = true;
            this.labelTechNameInWorkOrder.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTechNameInWorkOrder.Location = new System.Drawing.Point(203, 108);
            this.labelTechNameInWorkOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTechNameInWorkOrder.Name = "labelTechNameInWorkOrder";
            this.labelTechNameInWorkOrder.Size = new System.Drawing.Size(165, 37);
            this.labelTechNameInWorkOrder.TabIndex = 6;
            this.labelTechNameInWorkOrder.Text = "師傅名稱";
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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
<<<<<<< HEAD
            // T_OrderUserControl1
            // 
            this.BackColor = System.Drawing.Color.SeaShell;
=======
            // WorkOrdertextBox
            // 
            this.WorkOrdertextBox.Location = new System.Drawing.Point(582, 108);
            this.WorkOrdertextBox.Name = "WorkOrdertextBox";
            this.WorkOrdertextBox.Size = new System.Drawing.Size(228, 36);
            this.WorkOrdertextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "師傅id:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchButton.Location = new System.Drawing.Point(556, 177);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(169, 36);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // workOrderBindingSource1
            // 
            this.workOrderBindingSource1.DataMember = "WorkOrder";
            this.workOrderBindingSource1.DataSource = this.t_ACDataSet1;
            this.workOrderBindingSource1.CurrentChanged += new System.EventHandler(this.workOrderBindingSource1_CurrentChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.licensesTableAdapter = null;
            this.tableAdapterManager.TechniciansTableAdapter = this.techniciansTableAdapter1;
            this.tableAdapterManager.UpdateOrder = prjAircondition.Tech.DataSet.T_ACDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkOrderTableAdapter = this.workOrderTableAdapter1;
            this.tableAdapterManager.WorkTypeTableAdapter = this.workTypeTableAdapter1;
            // 
            // workOrderDataGridView
            // 
            this.workOrderDataGridView.AutoGenerateColumns = false;
            this.workOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.workOrderDataGridView.DataSource = this.workOrderBindingSource1;
            this.workOrderDataGridView.Location = new System.Drawing.Point(37, 335);
            this.workOrderDataGridView.Name = "workOrderDataGridView";
            this.workOrderDataGridView.RowHeadersWidth = 62;
            this.workOrderDataGridView.RowTemplate.Height = 31;
            this.workOrderDataGridView.Size = new System.Drawing.Size(1016, 608);
            this.workOrderDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WorkOrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "WorkOrderID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DetailID";
            this.dataGridViewTextBoxColumn2.HeaderText = "DetailID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WorkTypeID";
            this.dataGridViewTextBoxColumn3.HeaderText = "WorkTypeID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TechnicianID";
            this.dataGridViewTextBoxColumn4.HeaderText = "TechnicianID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClosingTechnicianID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ClosingTechnicianID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ModelName";
            this.dataGridViewTextBoxColumn6.HeaderText = "ModelName";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SerialNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "SerialNumber";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderStatus";
            this.dataGridViewTextBoxColumn9.HeaderText = "OrderStatus";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CompletedDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "CompletedDate";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "PaymentType";
            this.dataGridViewCheckBoxColumn1.HeaderText = "PaymentType";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn11.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn12.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "AreaID";
            this.dataGridViewTextBoxColumn13.HeaderText = "AreaID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AddressDetail";
            this.dataGridViewTextBoxColumn14.HeaderText = "AddressDetail";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TechnicianName";
            this.dataGridViewTextBoxColumn15.HeaderText = "TechnicianName";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // T_OrderUserControl1
            // 
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.workOrderDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WorkOrdertextBox);
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
            this.Controls.Add(this.workOrderlabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
<<<<<<< HEAD
            this.Controls.Add(this.WorkOrderDataGridView);
            this.Controls.Add(this.WorkTypeComboBox);
            this.Controls.Add(this.labelTechName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workType);
            this.Controls.Add(this.label1);
            this.Name = "T_OrderUserControl1";
            this.Size = new System.Drawing.Size(1215, 1075);
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
=======
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
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDataGridView)).EndInit();
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
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
<<<<<<< HEAD
        private System.Windows.Forms.DataGridView WorkOrderDataGridView;
        private System.Windows.Forms.ComboBox WorkTypeComboBox;
        private System.Windows.Forms.Label labelTechName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label workType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource workOrderBindingSource;
=======
        private System.Windows.Forms.ComboBox WorkTypeComboBox;
        private System.Windows.Forms.Label labelTechNameInWorkOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label workType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WorkOrdertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource workOrderBindingSource1;
        private DataSet.T_ACDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView workOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
>>>>>>> 65eefd30698b50c161f2eac48b28623d4a4330e5
    }
}   