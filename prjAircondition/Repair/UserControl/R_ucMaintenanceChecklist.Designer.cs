namespace prjAircondition.Repair
{
    partial class R_ucMaintenanceChecklist
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
            this.dgvWorkOrder = new System.Windows.Forms.DataGridView();
            this.RE_lblCount = new System.Windows.Forms.Label();
            this.RE_btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.r_ReapairDataSet1 = new prjAircondition.Repair.DataSet.R_ReapairDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ReapairDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkOrder
            // 
            this.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrder.Location = new System.Drawing.Point(0, 249);
            this.dgvWorkOrder.Name = "dgvWorkOrder";
            this.dgvWorkOrder.RowHeadersWidth = 51;
            this.dgvWorkOrder.RowTemplate.Height = 27;
            this.dgvWorkOrder.Size = new System.Drawing.Size(1004, 449);
            this.dgvWorkOrder.TabIndex = 0;
            // 
            // RE_lblCount
            // 
            this.RE_lblCount.AutoSize = true;
            this.RE_lblCount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblCount.Location = new System.Drawing.Point(3, 210);
            this.RE_lblCount.Name = "RE_lblCount";
            this.RE_lblCount.Size = new System.Drawing.Size(71, 36);
            this.RE_lblCount.TabIndex = 1;
            this.RE_lblCount.Text = "筆數";
            // 
            // RE_btnAdd
            // 
            this.RE_btnAdd.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnAdd.Location = new System.Drawing.Point(241, 124);
            this.RE_btnAdd.Name = "RE_btnAdd";
            this.RE_btnAdd.Size = new System.Drawing.Size(117, 48);
            this.RE_btnAdd.TabIndex = 2;
            this.RE_btnAdd.Text = "新增";
            this.RE_btnAdd.UseVisualStyleBackColor = true;
            this.RE_btnAdd.Click += new System.EventHandler(this.RE_btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(669, 124);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(163, 49);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "修改/儲存";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // r_ReapairDataSet1
            // 
            this.r_ReapairDataSet1.DataSetName = "R_ReapairDataSet";
            this.r_ReapairDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // R_ucMaintenanceChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.RE_btnAdd);
            this.Controls.Add(this.RE_lblCount);
            this.Controls.Add(this.dgvWorkOrder);
            this.Name = "R_ucMaintenanceChecklist";
            this.Size = new System.Drawing.Size(1007, 701);
            this.Load += new System.EventHandler(this.R_ucMaintenanceChecklist_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ReapairDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkOrder;
        private System.Windows.Forms.Label RE_lblCount;
        private System.Windows.Forms.Button RE_btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private DataSet.R_ReapairDataSet r_ReapairDataSet1;
    }
}
