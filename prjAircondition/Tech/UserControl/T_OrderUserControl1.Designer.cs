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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_OrderUserControl1));
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkOrderTechIDtextBox = new System.Windows.Forms.TextBox();
            this.workOrderlabel = new System.Windows.Forms.Label();
            this.WorkOrderbutton4 = new System.Windows.Forms.Button();
            this.WorkOrderbutton2 = new System.Windows.Forms.Button();
            this.WorkOrderbutton3 = new System.Windows.Forms.Button();
            this.WorkOrderbutton1 = new System.Windows.Forms.Button();
            this.WorkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.labelTechNameInWorkOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workOrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.workOrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.workOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.workTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ACDataSet1 = new prjAircondition.Tech.DataSet.T_ACDataSet1();
            this.workOrderTableAdapter = new prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters.WorkOrderTableAdapter();
            this.tableAdapterManager = new prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters.TableAdapterManager();
            this.techniciansTableAdapter1 = new prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters.TechniciansTableAdapter();
            this.workTypeTableAdapter1 = new prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters.WorkTypeTableAdapter();
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingNavigator)).BeginInit();
            this.workOrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchButton.Location = new System.Drawing.Point(559, 262);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 42);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "師傅id:";
            // 
            // WorkOrderTechIDtextBox
            // 
            this.WorkOrderTechIDtextBox.Location = new System.Drawing.Point(705, 163);
            this.WorkOrderTechIDtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkOrderTechIDtextBox.Name = "WorkOrderTechIDtextBox";
            this.WorkOrderTechIDtextBox.Size = new System.Drawing.Size(105, 36);
            this.WorkOrderTechIDtextBox.TabIndex = 30;
            // 
            // workOrderlabel
            // 
            this.workOrderlabel.AutoSize = true;
            this.workOrderlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workOrderlabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workOrderlabel.Location = new System.Drawing.Point(424, 381);
            this.workOrderlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workOrderlabel.Name = "workOrderlabel";
            this.workOrderlabel.Size = new System.Drawing.Size(91, 39);
            this.workOrderlabel.TabIndex = 29;
            this.workOrderlabel.Text = "1/10";
            // 
            // WorkOrderbutton4
            // 
            this.WorkOrderbutton4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkOrderbutton4.Location = new System.Drawing.Point(738, 369);
            this.WorkOrderbutton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkOrderbutton4.Name = "WorkOrderbutton4";
            this.WorkOrderbutton4.Size = new System.Drawing.Size(150, 67);
            this.WorkOrderbutton4.TabIndex = 25;
            this.WorkOrderbutton4.Text = "最後一筆";
            this.WorkOrderbutton4.UseVisualStyleBackColor = true;
            this.WorkOrderbutton4.Click += new System.EventHandler(this.WorkOrderbutton4_Click);
            // 
            // WorkOrderbutton2
            // 
            this.WorkOrderbutton2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkOrderbutton2.Location = new System.Drawing.Point(229, 369);
            this.WorkOrderbutton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkOrderbutton2.Name = "WorkOrderbutton2";
            this.WorkOrderbutton2.Size = new System.Drawing.Size(150, 67);
            this.WorkOrderbutton2.TabIndex = 26;
            this.WorkOrderbutton2.Text = "上一筆";
            this.WorkOrderbutton2.UseVisualStyleBackColor = true;
            this.WorkOrderbutton2.Click += new System.EventHandler(this.WorkOrderbutton2_Click);
            // 
            // WorkOrderbutton3
            // 
            this.WorkOrderbutton3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkOrderbutton3.Location = new System.Drawing.Point(559, 369);
            this.WorkOrderbutton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkOrderbutton3.Name = "WorkOrderbutton3";
            this.WorkOrderbutton3.Size = new System.Drawing.Size(150, 67);
            this.WorkOrderbutton3.TabIndex = 27;
            this.WorkOrderbutton3.Text = "下一筆";
            this.WorkOrderbutton3.UseVisualStyleBackColor = true;
            this.WorkOrderbutton3.Click += new System.EventHandler(this.WorkOrderbutton3_Click);
            // 
            // WorkOrderbutton1
            // 
            this.WorkOrderbutton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkOrderbutton1.Location = new System.Drawing.Point(43, 369);
            this.WorkOrderbutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkOrderbutton1.Name = "WorkOrderbutton1";
            this.WorkOrderbutton1.Size = new System.Drawing.Size(150, 67);
            this.WorkOrderbutton1.TabIndex = 28;
            this.WorkOrderbutton1.Text = "第一筆";
            this.WorkOrderbutton1.UseVisualStyleBackColor = true;
            this.WorkOrderbutton1.Click += new System.EventHandler(this.WorkOrderbutton1_Click);
            // 
            // WorkTypeComboBox
            // 
            this.WorkTypeComboBox.FormattingEnabled = true;
            this.WorkTypeComboBox.Location = new System.Drawing.Point(266, 268);
            this.WorkTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WorkTypeComboBox.Name = "WorkTypeComboBox";
            this.WorkTypeComboBox.Size = new System.Drawing.Size(247, 36);
            this.WorkTypeComboBox.TabIndex = 24;
            this.WorkTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.WorkTypeComboBox_SelectedIndexChanged);
            // 
            // labelTechNameInWorkOrder
            // 
            this.labelTechNameInWorkOrder.AutoSize = true;
            this.labelTechNameInWorkOrder.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTechNameInWorkOrder.Location = new System.Drawing.Point(283, 160);
            this.labelTechNameInWorkOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTechNameInWorkOrder.Name = "labelTechNameInWorkOrder";
            this.labelTechNameInWorkOrder.Size = new System.Drawing.Size(165, 37);
            this.labelTechNameInWorkOrder.TabIndex = 20;
            this.labelTechNameInWorkOrder.Text = "師傅名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "師傅:";
            // 
            // workType
            // 
            this.workType.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workType.Location = new System.Drawing.Point(45, 268);
            this.workType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.workType.Name = "workType";
            this.workType.Size = new System.Drawing.Size(238, 58);
            this.workType.TabIndex = 22;
            this.workType.Text = "工作類型:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "訂單資料";
            // 
            // workOrderBindingNavigator
            // 
            this.workOrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workOrderBindingNavigator.BindingSource = this.workOrderBindingSource;
            this.workOrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workOrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workOrderBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.workOrderBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.workOrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.workOrderBindingNavigatorSaveItem});
            this.workOrderBindingNavigator.Location = new System.Drawing.Point(43, 94);
            this.workOrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workOrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workOrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workOrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workOrderBindingNavigator.Name = "workOrderBindingNavigator";
            this.workOrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workOrderBindingNavigator.Size = new System.Drawing.Size(368, 38);
            this.workOrderBindingNavigator.TabIndex = 34;
            this.workOrderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 33);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // workOrderBindingNavigatorSaveItem
            // 
            this.workOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workOrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workOrderBindingNavigatorSaveItem.Image")));
            this.workOrderBindingNavigatorSaveItem.Name = "workOrderBindingNavigatorSaveItem";
            this.workOrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.workOrderBindingNavigatorSaveItem.Text = "儲存資料";
            this.workOrderBindingNavigatorSaveItem.Click += new System.EventHandler(this.workOrderBindingNavigatorSaveItem_Click);
            // 
            // workOrderDataGridView
            // 
            this.workOrderDataGridView.AutoGenerateColumns = false;
            this.workOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
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
            this.dataGridViewTextBoxColumn14});
            this.workOrderDataGridView.DataSource = this.workOrderBindingSource;
            this.workOrderDataGridView.Location = new System.Drawing.Point(43, 460);
            this.workOrderDataGridView.Name = "workOrderDataGridView";
            this.workOrderDataGridView.RowHeadersWidth = 62;
            this.workOrderDataGridView.RowTemplate.Height = 31;
            this.workOrderDataGridView.Size = new System.Drawing.Size(1381, 592);
            this.workOrderDataGridView.TabIndex = 34;
            this.workOrderDataGridView.SelectionChanged += new System.EventHandler(this.workOrderDataGridView_SelectionChanged);
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataMember = "WorkOrder";
            this.workOrderBindingSource.DataSource = this.t_ACDataSet1;
            this.workOrderBindingSource.CurrentChanged += new System.EventHandler(this.workOrderBindingSource_CurrentChanged);
            // 
            // t_ACDataSet1
            // 
            this.t_ACDataSet1.DataSetName = "T_ACDataSet1";
            this.t_ACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workOrderTableAdapter
            // 
            this.workOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.licensesTableAdapter = null;
            this.tableAdapterManager.TechniciansTableAdapter = this.techniciansTableAdapter1;
            this.tableAdapterManager.UpdateOrder = prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkOrderTableAdapter = this.workOrderTableAdapter;
            this.tableAdapterManager.WorkTypeTableAdapter = this.workTypeTableAdapter1;
            // 
            // techniciansTableAdapter1
            // 
            this.techniciansTableAdapter1.ClearBeforeFill = true;
            // 
            // workTypeTableAdapter1
            // 
            this.workTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "Technicians";
            this.techniciansBindingSource.DataSource = this.t_ACDataSet1;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AddressDetail";
            this.dataGridViewTextBoxColumn14.HeaderText = "地址細項";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "AreaID";
            this.dataGridViewTextBoxColumn13.HeaderText = "地區ID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn12.HeaderText = "城市ID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn11.HeaderText = "會員ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "PaymentType";
            this.dataGridViewCheckBoxColumn1.HeaderText = "付款型態";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CompletedDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "完成時間";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderStatus";
            this.dataGridViewTextBoxColumn9.HeaderText = "工單狀態";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "創立時間";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SerialNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "型號";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ModelName";
            this.dataGridViewTextBoxColumn6.HeaderText = "型號名稱";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClosingTechnicianID";
            this.dataGridViewTextBoxColumn5.HeaderText = "完成師傅ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TechnicianID";
            this.dataGridViewTextBoxColumn4.HeaderText = "會員ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WorkTypeID";
            this.dataGridViewTextBoxColumn3.HeaderText = "工作類型ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DetailID";
            this.dataGridViewTextBoxColumn2.HeaderText = "細節ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WorkOrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "安裝單ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TechnicianName";
            this.dataGridViewTextBoxColumn15.HeaderText = "師傅名字";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // T_OrderUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.workOrderDataGridView);
            this.Controls.Add(this.workOrderBindingNavigator);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WorkOrderTechIDtextBox);
            this.Controls.Add(this.workOrderlabel);
            this.Controls.Add(this.WorkOrderbutton4);
            this.Controls.Add(this.WorkOrderbutton2);
            this.Controls.Add(this.WorkOrderbutton3);
            this.Controls.Add(this.WorkOrderbutton1);
            this.Controls.Add(this.WorkTypeComboBox);
            this.Controls.Add(this.labelTechNameInWorkOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "T_OrderUserControl1";
            this.Size = new System.Drawing.Size(1797, 1500);
            this.Load += new System.EventHandler(this.T_OrderUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingNavigator)).EndInit();
            this.workOrderBindingNavigator.ResumeLayout(false);
            this.workOrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WorkOrderTechIDtextBox;
        private System.Windows.Forms.Label workOrderlabel;
        private System.Windows.Forms.Button WorkOrderbutton4;
        private System.Windows.Forms.Button WorkOrderbutton2;
        private System.Windows.Forms.Button WorkOrderbutton3;
        private System.Windows.Forms.Button WorkOrderbutton1;
        private System.Windows.Forms.ComboBox WorkTypeComboBox;
        private System.Windows.Forms.Label labelTechNameInWorkOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label workType;
        private System.Windows.Forms.Label label1;
        private DataSet.T_ACDataSet1 t_ACDataSet1;
        private System.Windows.Forms.BindingSource workOrderBindingSource;
        private DataSet.T_ACDataSet1TableAdapters.WorkOrderTableAdapter workOrderTableAdapter;
        private DataSet.T_ACDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workOrderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton workOrderBindingNavigatorSaveItem;
        private DataSet.T_ACDataSet1TableAdapters.TechniciansTableAdapter techniciansTableAdapter1;
        private DataSet.T_ACDataSet1TableAdapters.WorkTypeTableAdapter workTypeTableAdapter1;
        private System.Windows.Forms.DataGridView workOrderDataGridView;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private System.Windows.Forms.BindingSource workTypeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
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
    }
}
