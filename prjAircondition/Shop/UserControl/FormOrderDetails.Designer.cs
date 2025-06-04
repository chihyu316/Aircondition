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
            System.Windows.Forms.Label PriceLable;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label shipmentTrackingLabel;
            System.Windows.Forms.Label workOrderIDLabel;
            System.Windows.Forms.Label paymentRecordLabel;
            this.s_DProductImage = new prjAircondition.Shop.DataSet.S_DProductImage();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new prjAircondition.Shop.DataSet.S_DProductImageTableAdapters.OrderDetailsTableAdapter();
            this.tableAdapterManager = new prjAircondition.Shop.DataSet.S_DProductImageTableAdapters.TableAdapterManager();
            this.orderDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orderDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.detailIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.txtCoolingProductID = new System.Windows.Forms.TextBox();
            this.txtMaterialID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.shipmentTrackingTextBox = new System.Windows.Forms.TextBox();
            this.workOrderIDTextBox = new System.Windows.Forms.TextBox();
            this.paymentRecordTextBox = new System.Windows.Forms.TextBox();
            detailIDLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            coolingProductIDLabel = new System.Windows.Forms.Label();
            materialIDLabel = new System.Windows.Forms.Label();
            PriceLable = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            shipmentTrackingLabel = new System.Windows.Forms.Label();
            workOrderIDLabel = new System.Windows.Forms.Label();
            paymentRecordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.s_DProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).BeginInit();
            this.orderDetailsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // s_DProductImage
            // 
            this.s_DProductImage.DataSetName = "S_DProductImage";
            this.s_DProductImage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.s_DProductImage;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = this.orderDetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjAircondition.Shop.DataSet.S_DProductImageTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.orderDetailsBindingNavigator.Size = new System.Drawing.Size(766, 31);
            this.orderDetailsBindingNavigator.TabIndex = 0;
            this.orderDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // orderDetailsBindingNavigatorSaveItem
            // 
            this.orderDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderDetailsBindingNavigatorSaveItem.Image")));
            this.orderDetailsBindingNavigatorSaveItem.Name = "orderDetailsBindingNavigatorSaveItem";
            this.orderDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.orderDetailsBindingNavigatorSaveItem.Text = "儲存資料";
            this.orderDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderDetailsBindingNavigatorSaveItem_Click);
            // 
            // detailIDLabel
            // 
            detailIDLabel.AutoSize = true;
            detailIDLabel.Location = new System.Drawing.Point(41, 78);
            detailIDLabel.Name = "detailIDLabel";
            detailIDLabel.Size = new System.Drawing.Size(67, 15);
            detailIDLabel.TabIndex = 1;
            detailIDLabel.Text = "明細編號";
            // 
            // detailIDTextBox
            // 
            this.detailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "DetailID", true));
            this.detailIDTextBox.Location = new System.Drawing.Point(170, 75);
            this.detailIDTextBox.Name = "detailIDTextBox";
            this.detailIDTextBox.Size = new System.Drawing.Size(250, 25);
            this.detailIDTextBox.TabIndex = 2;
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(41, 109);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(67, 15);
            orderIDLabel.TabIndex = 3;
            orderIDLabel.Text = "訂單編號";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(170, 106);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(250, 25);
            this.orderIDTextBox.TabIndex = 4;
            // 
            // coolingProductIDLabel
            // 
            coolingProductIDLabel.AutoSize = true;
            coolingProductIDLabel.Location = new System.Drawing.Point(41, 140);
            coolingProductIDLabel.Name = "coolingProductIDLabel";
            coolingProductIDLabel.Size = new System.Drawing.Size(97, 15);
            coolingProductIDLabel.TabIndex = 5;
            coolingProductIDLabel.Text = "冷氣商品編號";
            // 
            // txtCoolingProductID
            // 
            this.txtCoolingProductID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "CoolingProductID", true));
            this.txtCoolingProductID.Location = new System.Drawing.Point(170, 137);
            this.txtCoolingProductID.Name = "txtCoolingProductID";
            this.txtCoolingProductID.Size = new System.Drawing.Size(250, 25);
            this.txtCoolingProductID.TabIndex = 6;
            this.txtCoolingProductID.TextChanged += new System.EventHandler(this.txtCoolingProductID_TextChanged);
            this.txtCoolingProductID.Leave += new System.EventHandler(this.txtCoolingProductID_Leave);
            // 
            // materialIDLabel
            // 
            materialIDLabel.AutoSize = true;
            materialIDLabel.Location = new System.Drawing.Point(41, 171);
            materialIDLabel.Name = "materialIDLabel";
            materialIDLabel.Size = new System.Drawing.Size(97, 15);
            materialIDLabel.TabIndex = 7;
            materialIDLabel.Text = "材料商品編號";
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "MaterialID", true));
            this.txtMaterialID.Location = new System.Drawing.Point(170, 168);
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(250, 25);
            this.txtMaterialID.TabIndex = 8;
            this.txtMaterialID.Leave += new System.EventHandler(this.txtMaterialID_Leave);
            // 
            // PriceLable
            // 
            PriceLable.AutoSize = true;
            PriceLable.Location = new System.Drawing.Point(41, 202);
            PriceLable.Name = "PriceLable";
            PriceLable.Size = new System.Drawing.Size(37, 15);
            PriceLable.TabIndex = 9;
            PriceLable.Text = "單價";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "UnitPrice", true));
            this.txtUnitPrice.Location = new System.Drawing.Point(170, 199);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(250, 25);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(41, 233);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(37, 15);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "數量";
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "Quantity", true));
            this.txtQuantity.Location = new System.Drawing.Point(170, 230);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(250, 25);
            this.txtQuantity.TabIndex = 12;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(41, 264);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(37, 15);
            subtotalLabel.TabIndex = 13;
            subtotalLabel.Text = "小計";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "Subtotal", true));
            this.txtSubtotal.Location = new System.Drawing.Point(170, 261);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(250, 25);
            this.txtSubtotal.TabIndex = 14;
            // 
            // shipmentTrackingLabel
            // 
            shipmentTrackingLabel.AutoSize = true;
            shipmentTrackingLabel.Location = new System.Drawing.Point(41, 295);
            shipmentTrackingLabel.Name = "shipmentTrackingLabel";
            shipmentTrackingLabel.Size = new System.Drawing.Size(82, 15);
            shipmentTrackingLabel.TabIndex = 15;
            shipmentTrackingLabel.Text = "出貨追蹤表";
            // 
            // shipmentTrackingTextBox
            // 
            this.shipmentTrackingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "ShipmentTracking", true));
            this.shipmentTrackingTextBox.Location = new System.Drawing.Point(170, 292);
            this.shipmentTrackingTextBox.Name = "shipmentTrackingTextBox";
            this.shipmentTrackingTextBox.Size = new System.Drawing.Size(250, 25);
            this.shipmentTrackingTextBox.TabIndex = 16;
            // 
            // workOrderIDLabel
            // 
            workOrderIDLabel.AutoSize = true;
            workOrderIDLabel.Location = new System.Drawing.Point(41, 326);
            workOrderIDLabel.Name = "workOrderIDLabel";
            workOrderIDLabel.Size = new System.Drawing.Size(67, 15);
            workOrderIDLabel.TabIndex = 17;
            workOrderIDLabel.Text = "工單編號";
            // 
            // workOrderIDTextBox
            // 
            this.workOrderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "WorkOrderID", true));
            this.workOrderIDTextBox.Location = new System.Drawing.Point(170, 323);
            this.workOrderIDTextBox.Name = "workOrderIDTextBox";
            this.workOrderIDTextBox.Size = new System.Drawing.Size(250, 25);
            this.workOrderIDTextBox.TabIndex = 18;
            // 
            // paymentRecordLabel
            // 
            paymentRecordLabel.AutoSize = true;
            paymentRecordLabel.Location = new System.Drawing.Point(41, 357);
            paymentRecordLabel.Name = "paymentRecordLabel";
            paymentRecordLabel.Size = new System.Drawing.Size(67, 15);
            paymentRecordLabel.TabIndex = 19;
            paymentRecordLabel.Text = "付款紀錄";
            // 
            // paymentRecordTextBox
            // 
            this.paymentRecordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "PaymentRecord", true));
            this.paymentRecordTextBox.Location = new System.Drawing.Point(170, 354);
            this.paymentRecordTextBox.Name = "paymentRecordTextBox";
            this.paymentRecordTextBox.Size = new System.Drawing.Size(250, 25);
            this.paymentRecordTextBox.TabIndex = 20;
            // 
            // FormOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 513);
            this.Controls.Add(detailIDLabel);
            this.Controls.Add(this.detailIDTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(coolingProductIDLabel);
            this.Controls.Add(this.txtCoolingProductID);
            this.Controls.Add(materialIDLabel);
            this.Controls.Add(this.txtMaterialID);
            this.Controls.Add(PriceLable);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(shipmentTrackingLabel);
            this.Controls.Add(this.shipmentTrackingTextBox);
            this.Controls.Add(workOrderIDLabel);
            this.Controls.Add(this.workOrderIDTextBox);
            this.Controls.Add(paymentRecordLabel);
            this.Controls.Add(this.paymentRecordTextBox);
            this.Controls.Add(this.orderDetailsBindingNavigator);
            this.Name = "FormOrderDetails";
            this.Text = "FormOrderDetails";
            this.Load += new System.EventHandler(this.FormOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s_DProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingNavigator)).EndInit();
            this.orderDetailsBindingNavigator.ResumeLayout(false);
            this.orderDetailsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shop.DataSet.S_DProductImage s_DProductImage;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private Shop.DataSet.S_DProductImageTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private Shop.DataSet.S_DProductImageTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox txtCoolingProductID;
        private System.Windows.Forms.TextBox txtMaterialID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox shipmentTrackingTextBox;
        private System.Windows.Forms.TextBox workOrderIDTextBox;
        private System.Windows.Forms.TextBox paymentRecordTextBox;
    }
}