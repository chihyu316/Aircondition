namespace prjAircondition
{
    partial class FormOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderDetails));
            System.Windows.Forms.Label detailIDLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label coolingProductIDLabel;
            System.Windows.Forms.Label materialIDLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label shipmentTrackingLabel;
            System.Windows.Forms.Label workOrderIDLabel;
            System.Windows.Forms.Label paymentRecordLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedTimeLabel;
            System.Windows.Forms.Label updatedByLabel;
            this.s_DOrderProcessing = new prjAircondition.Shop.DataSet.S_DOrderProcessing();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new prjAircondition.Shop.DataSet.S_DOrderProcessingTableAdapters.OrderDetailsTableAdapter();
            this.tableAdapterManager = new prjAircondition.Shop.DataSet.S_DOrderProcessingTableAdapters.TableAdapterManager();
            this.orderDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.detailIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.coolingProductIDTextBox = new System.Windows.Forms.TextBox();
            this.materialIDTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.shipmentTrackingTextBox = new System.Windows.Forms.TextBox();
            this.workOrderIDTextBox = new System.Windows.Forms.TextBox();
            this.paymentRecordTextBox = new System.Windows.Forms.TextBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updatedByTextBox = new System.Windows.Forms.TextBox();
            detailIDLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            coolingProductIDLabel = new System.Windows.Forms.Label();
            materialIDLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            shipmentTrackingLabel = new System.Windows.Forms.Label();
            workOrderIDLabel = new System.Windows.Forms.Label();
            paymentRecordLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            updatedTimeLabel = new System.Windows.Forms.Label();
            updatedByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.s_DOrderProcessing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).BeginInit();
            this.orderDetailsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // s_DOrderProcessing
            // 
            this.s_DOrderProcessing.DataSetName = "S_DOrderProcessing";
            this.s_DOrderProcessing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.s_DOrderProcessing;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderDetailsTableAdapter = this.orderDetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjAircondition.Shop.DataSet.S_DOrderProcessingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderDetailsBindingNavigator
            // 
            this.orderDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderDetailsBindingNavigator.BindingSource = this.orderDetailsBindingSource;
            this.orderDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.orderDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderDetailsBindingNavigatorSaveItem});
            this.orderDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderDetailsBindingNavigator.Name = "orderDetailsBindingNavigator";
            this.orderDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderDetailsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.orderDetailsBindingNavigator.TabIndex = 0;
            this.orderDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 19);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // orderDetailsBindingNavigatorSaveItem
            // 
            this.orderDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderDetailsBindingNavigatorSaveItem.Image")));
            this.orderDetailsBindingNavigatorSaveItem.Name = "orderDetailsBindingNavigatorSaveItem";
            this.orderDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orderDetailsBindingNavigatorSaveItem.Text = "儲存資料";
            this.orderDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderDetailsBindingNavigatorSaveItem_Click_2);
            // 
            // detailIDLabel
            // 
            detailIDLabel.AutoSize = true;
            detailIDLabel.Location = new System.Drawing.Point(240, 47);
            detailIDLabel.Name = "detailIDLabel";
            detailIDLabel.Size = new System.Drawing.Size(71, 15);
            detailIDLabel.TabIndex = 1;
            detailIDLabel.Text = "明細編號:";
            // 
            // detailIDTextBox
            // 
            this.detailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "DetailID", true));
            this.detailIDTextBox.Location = new System.Drawing.Point(369, 44);
            this.detailIDTextBox.Name = "detailIDTextBox";
            this.detailIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.detailIDTextBox.TabIndex = 2;
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(240, 78);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(67, 15);
            orderIDLabel.TabIndex = 3;
            orderIDLabel.Text = "訂單編號";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(369, 75);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.orderIDTextBox.TabIndex = 4;
            // 
            // coolingProductIDLabel
            // 
            coolingProductIDLabel.AutoSize = true;
            coolingProductIDLabel.Location = new System.Drawing.Point(240, 109);
            coolingProductIDLabel.Name = "coolingProductIDLabel";
            coolingProductIDLabel.Size = new System.Drawing.Size(97, 15);
            coolingProductIDLabel.TabIndex = 5;
            coolingProductIDLabel.Text = "冷氣商品編號";
            // 
            // coolingProductIDTextBox
            // 
            this.coolingProductIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "CoolingProductID", true));
            this.coolingProductIDTextBox.Location = new System.Drawing.Point(369, 106);
            this.coolingProductIDTextBox.Name = "coolingProductIDTextBox";
            this.coolingProductIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.coolingProductIDTextBox.TabIndex = 6;
            // 
            // materialIDLabel
            // 
            materialIDLabel.AutoSize = true;
            materialIDLabel.Location = new System.Drawing.Point(240, 140);
            materialIDLabel.Name = "materialIDLabel";
            materialIDLabel.Size = new System.Drawing.Size(97, 15);
            materialIDLabel.TabIndex = 7;
            materialIDLabel.Text = "材料商品編號";
            // 
            // materialIDTextBox
            // 
            this.materialIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "MaterialID", true));
            this.materialIDTextBox.Location = new System.Drawing.Point(369, 137);
            this.materialIDTextBox.Name = "materialIDTextBox";
            this.materialIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.materialIDTextBox.TabIndex = 8;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(240, 171);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(37, 15);
            unitPriceLabel.TabIndex = 9;
            unitPriceLabel.Text = "單價";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(369, 168);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(200, 25);
            this.unitPriceTextBox.TabIndex = 10;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(240, 202);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(37, 15);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "數量";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(369, 199);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 25);
            this.quantityTextBox.TabIndex = 12;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(240, 233);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(37, 15);
            subtotalLabel.TabIndex = 13;
            subtotalLabel.Text = "小計";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "Subtotal", true));
            this.subtotalTextBox.Location = new System.Drawing.Point(369, 230);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(200, 25);
            this.subtotalTextBox.TabIndex = 14;
            // 
            // shipmentTrackingLabel
            // 
            shipmentTrackingLabel.AutoSize = true;
            shipmentTrackingLabel.Location = new System.Drawing.Point(240, 264);
            shipmentTrackingLabel.Name = "shipmentTrackingLabel";
            shipmentTrackingLabel.Size = new System.Drawing.Size(82, 15);
            shipmentTrackingLabel.TabIndex = 15;
            shipmentTrackingLabel.Text = "出貨追蹤表";
            // 
            // shipmentTrackingTextBox
            // 
            this.shipmentTrackingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "ShipmentTracking", true));
            this.shipmentTrackingTextBox.Location = new System.Drawing.Point(369, 261);
            this.shipmentTrackingTextBox.Name = "shipmentTrackingTextBox";
            this.shipmentTrackingTextBox.Size = new System.Drawing.Size(200, 25);
            this.shipmentTrackingTextBox.TabIndex = 16;
            // 
            // workOrderIDLabel
            // 
            workOrderIDLabel.AutoSize = true;
            workOrderIDLabel.Location = new System.Drawing.Point(240, 295);
            workOrderIDLabel.Name = "workOrderIDLabel";
            workOrderIDLabel.Size = new System.Drawing.Size(67, 15);
            workOrderIDLabel.TabIndex = 17;
            workOrderIDLabel.Text = "工單編號";
            // 
            // workOrderIDTextBox
            // 
            this.workOrderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "WorkOrderID", true));
            this.workOrderIDTextBox.Location = new System.Drawing.Point(369, 292);
            this.workOrderIDTextBox.Name = "workOrderIDTextBox";
            this.workOrderIDTextBox.Size = new System.Drawing.Size(200, 25);
            this.workOrderIDTextBox.TabIndex = 18;
            // 
            // paymentRecordLabel
            // 
            paymentRecordLabel.AutoSize = true;
            paymentRecordLabel.Location = new System.Drawing.Point(240, 326);
            paymentRecordLabel.Name = "paymentRecordLabel";
            paymentRecordLabel.Size = new System.Drawing.Size(67, 15);
            paymentRecordLabel.TabIndex = 19;
            paymentRecordLabel.Text = "付款紀錄";
            // 
            // paymentRecordTextBox
            // 
            this.paymentRecordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "PaymentRecord", true));
            this.paymentRecordTextBox.Location = new System.Drawing.Point(369, 323);
            this.paymentRecordTextBox.Name = "paymentRecordTextBox";
            this.paymentRecordTextBox.Size = new System.Drawing.Size(200, 25);
            this.paymentRecordTextBox.TabIndex = 20;
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(240, 358);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(67, 15);
            createdTimeLabel.TabIndex = 21;
            createdTimeLabel.Text = "建立時間";
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderDetailsBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(369, 354);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.createdTimeDateTimePicker.TabIndex = 22;
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(240, 388);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(52, 15);
            createdByLabel.TabIndex = 23;
            createdByLabel.Text = "建立人";
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "CreatedBy", true));
            this.createdByTextBox.Location = new System.Drawing.Point(369, 385);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.Size = new System.Drawing.Size(200, 25);
            this.createdByTextBox.TabIndex = 24;
            // 
            // updatedTimeLabel
            // 
            updatedTimeLabel.AutoSize = true;
            updatedTimeLabel.Location = new System.Drawing.Point(240, 420);
            updatedTimeLabel.Name = "updatedTimeLabel";
            updatedTimeLabel.Size = new System.Drawing.Size(67, 15);
            updatedTimeLabel.TabIndex = 25;
            updatedTimeLabel.Text = "修改時間";
            // 
            // updatedTimeDateTimePicker
            // 
            this.updatedTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderDetailsBindingSource, "UpdatedTime", true));
            this.updatedTimeDateTimePicker.Location = new System.Drawing.Point(369, 416);
            this.updatedTimeDateTimePicker.Name = "updatedTimeDateTimePicker";
            this.updatedTimeDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.updatedTimeDateTimePicker.TabIndex = 26;
            // 
            // updatedByLabel
            // 
            updatedByLabel.AutoSize = true;
            updatedByLabel.Location = new System.Drawing.Point(240, 450);
            updatedByLabel.Name = "updatedByLabel";
            updatedByLabel.Size = new System.Drawing.Size(52, 15);
            updatedByLabel.TabIndex = 27;
            updatedByLabel.Text = "修改人";
            // 
            // updatedByTextBox
            // 
            this.updatedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "UpdatedBy", true));
            this.updatedByTextBox.Location = new System.Drawing.Point(369, 447);
            this.updatedByTextBox.Name = "updatedByTextBox";
            this.updatedByTextBox.Size = new System.Drawing.Size(200, 25);
            this.updatedByTextBox.TabIndex = 28;
            // 
            // FormOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(detailIDLabel);
            this.Controls.Add(this.detailIDTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(coolingProductIDLabel);
            this.Controls.Add(this.coolingProductIDTextBox);
            this.Controls.Add(materialIDLabel);
            this.Controls.Add(this.materialIDTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(shipmentTrackingLabel);
            this.Controls.Add(this.shipmentTrackingTextBox);
            this.Controls.Add(workOrderIDLabel);
            this.Controls.Add(this.workOrderIDTextBox);
            this.Controls.Add(paymentRecordLabel);
            this.Controls.Add(this.paymentRecordTextBox);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.createdTimeDateTimePicker);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(updatedTimeLabel);
            this.Controls.Add(this.updatedTimeDateTimePicker);
            this.Controls.Add(updatedByLabel);
            this.Controls.Add(this.updatedByTextBox);
            this.Controls.Add(this.orderDetailsBindingNavigator);
            this.Name = "FormOrderDetails";
            this.Text = "付款紀錄";
            this.Load += new System.EventHandler(this.FormOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s_DOrderProcessing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).EndInit();
            this.orderDetailsBindingNavigator.ResumeLayout(false);
            this.orderDetailsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shop.DataSet.S_DOrderProcessing s_DOrderProcessing;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private Shop.DataSet.S_DOrderProcessingTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private Shop.DataSet.S_DOrderProcessingTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orderDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox detailIDTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox coolingProductIDTextBox;
        private System.Windows.Forms.TextBox materialIDTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox shipmentTrackingTextBox;
        private System.Windows.Forms.TextBox workOrderIDTextBox;
        private System.Windows.Forms.TextBox paymentRecordTextBox;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.DateTimePicker updatedTimeDateTimePicker;
        private System.Windows.Forms.TextBox updatedByTextBox;
    }
}