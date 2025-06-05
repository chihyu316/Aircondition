namespace prjAircondition.Repair
{
    partial class R_ucWorkOrder
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
            this.RE_lblCount = new System.Windows.Forms.Label();
            this.RE_btnNew = new System.Windows.Forms.Button();
            this.RE_update = new System.Windows.Forms.Button();
            this.ER_btnSelect = new System.Windows.Forms.Button();
            this.RE_btndele = new System.Windows.Forms.Button();
            this.RE_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RE_cob = new System.Windows.Forms.ComboBox();
            this.RE_SearchT = new System.Windows.Forms.TextBox();
            this.RE_lblSelect = new System.Windows.Forms.Label();
            this.RE_lblInf = new System.Windows.Forms.Label();
            this.RE_btnupd = new System.Windows.Forms.Button();
            this.d_ACDataSet1 = new prjAircondition.Dicuss.DataSet.D_ACDataSet();
            this.r_ReapairDataSet1 = new prjAircondition.Repair.DataSet.R_ReapairDataSet();
            this.workOrderTableAdapter1 = new prjAircondition.Repair.DataSet.R_ReapairDataSetTableAdapters.WorkOrderTableAdapter();
            this.RE_lbl = new System.Windows.Forms.Label();
            this.RE_lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RE_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ReapairDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // RE_lblCount
            // 
            this.RE_lblCount.AutoSize = true;
            this.RE_lblCount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblCount.Location = new System.Drawing.Point(72, 325);
            this.RE_lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RE_lblCount.Name = "RE_lblCount";
            this.RE_lblCount.Size = new System.Drawing.Size(99, 36);
            this.RE_lblCount.TabIndex = 0;
            this.RE_lblCount.Text = "總件數";
            // 
            // RE_btnNew
            // 
            this.RE_btnNew.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnNew.Location = new System.Drawing.Point(307, 244);
            this.RE_btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_btnNew.Name = "RE_btnNew";
            this.RE_btnNew.Size = new System.Drawing.Size(128, 56);
            this.RE_btnNew.TabIndex = 1;
            this.RE_btnNew.Text = "新增工單";
            this.RE_btnNew.UseVisualStyleBackColor = true;
            this.RE_btnNew.Click += new System.EventHandler(this.RE_btnNew_Click);
            // 
            // RE_update
            // 
            this.RE_update.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_update.Location = new System.Drawing.Point(495, 244);
            this.RE_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_update.Name = "RE_update";
            this.RE_update.Size = new System.Drawing.Size(127, 56);
            this.RE_update.TabIndex = 2;
            this.RE_update.Text = "Fill Work";
            this.RE_update.UseVisualStyleBackColor = true;
            this.RE_update.Click += new System.EventHandler(this.RE_update_Click_1);
            // 
            // ER_btnSelect
            // 
            this.ER_btnSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ER_btnSelect.Location = new System.Drawing.Point(867, 62);
            this.ER_btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ER_btnSelect.Name = "ER_btnSelect";
            this.ER_btnSelect.Size = new System.Drawing.Size(128, 59);
            this.ER_btnSelect.TabIndex = 3;
            this.ER_btnSelect.Text = "查詢";
            this.ER_btnSelect.UseVisualStyleBackColor = true;
            this.ER_btnSelect.Click += new System.EventHandler(this.ER_btnSelect_Click);
            // 
            // RE_btndele
            // 
            this.RE_btndele.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btndele.Location = new System.Drawing.Point(867, 244);
            this.RE_btndele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_btndele.Name = "RE_btndele";
            this.RE_btndele.Size = new System.Drawing.Size(131, 59);
            this.RE_btndele.TabIndex = 4;
            this.RE_btndele.Text = "刪除";
            this.RE_btndele.UseVisualStyleBackColor = true;
            this.RE_btndele.Click += new System.EventHandler(this.RE_btndele_Click);
            // 
            // RE_dataGridView1
            // 
            this.RE_dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RE_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RE_dataGridView1.Location = new System.Drawing.Point(61, 374);
            this.RE_dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_dataGridView1.Name = "RE_dataGridView1";
            this.RE_dataGridView1.RowHeadersWidth = 51;
            this.RE_dataGridView1.RowTemplate.Height = 24;
            this.RE_dataGridView1.Size = new System.Drawing.Size(1257, 341);
            this.RE_dataGridView1.TabIndex = 5;
            // 
            // RE_cob
            // 
            this.RE_cob.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_cob.FormattingEnabled = true;
            this.RE_cob.Items.AddRange(new object[] {
            "工作類型",
            "師傅名稱",
            "會員名稱",
            "工單建立日期",
            "工單狀態",
            "付款方式",
            "施工地址"});
            this.RE_cob.Location = new System.Drawing.Point(414, 62);
            this.RE_cob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_cob.Name = "RE_cob";
            this.RE_cob.Size = new System.Drawing.Size(160, 24);
            this.RE_cob.TabIndex = 6;
            // 
            // RE_SearchT
            // 
            this.RE_SearchT.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_SearchT.Location = new System.Drawing.Point(674, 65);
            this.RE_SearchT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_SearchT.Name = "RE_SearchT";
            this.RE_SearchT.Size = new System.Drawing.Size(159, 23);
            this.RE_SearchT.TabIndex = 7;
            // 
            // RE_lblSelect
            // 
            this.RE_lblSelect.AutoSize = true;
            this.RE_lblSelect.Location = new System.Drawing.Point(323, 65);
            this.RE_lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RE_lblSelect.Name = "RE_lblSelect";
            this.RE_lblSelect.Size = new System.Drawing.Size(71, 15);
            this.RE_lblSelect.TabIndex = 8;
            this.RE_lblSelect.Text = "搜尋欄位:";
            // 
            // RE_lblInf
            // 
            this.RE_lblInf.AutoSize = true;
            this.RE_lblInf.Location = new System.Drawing.Point(583, 65);
            this.RE_lblInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RE_lblInf.Name = "RE_lblInf";
            this.RE_lblInf.Size = new System.Drawing.Size(71, 15);
            this.RE_lblInf.TabIndex = 9;
            this.RE_lblInf.Text = "輸入資料:";
            // 
            // RE_btnupd
            // 
            this.RE_btnupd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnupd.Location = new System.Drawing.Point(685, 244);
            this.RE_btnupd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_btnupd.Name = "RE_btnupd";
            this.RE_btnupd.Size = new System.Drawing.Size(127, 56);
            this.RE_btnupd.TabIndex = 2;
            this.RE_btnupd.Text = "修改/儲存";
            this.RE_btnupd.UseVisualStyleBackColor = true;
            this.RE_btnupd.Click += new System.EventHandler(this.RE_update_Click);
            // 
            // d_ACDataSet1
            // 
            this.d_ACDataSet1.DataSetName = "D_ACDataSet";
            this.d_ACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r_ReapairDataSet1
            // 
            this.r_ReapairDataSet1.DataSetName = "R_ReapairDataSet";
            this.r_ReapairDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workOrderTableAdapter1
            // 
            this.workOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // RE_lbl
            // 
            this.RE_lbl.AutoSize = true;
            this.RE_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE_lbl.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lbl.Location = new System.Drawing.Point(175, 14);
            this.RE_lbl.Name = "RE_lbl";
            this.RE_lbl.Size = new System.Drawing.Size(139, 40);
            this.RE_lbl.TabIndex = 10;
            this.RE_lbl.Text = "條件查詢";
            // 
            // RE_lbl1
            // 
            this.RE_lbl1.AutoSize = true;
            this.RE_lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE_lbl1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lbl1.Location = new System.Drawing.Point(175, 183);
            this.RE_lbl1.Name = "RE_lbl1";
            this.RE_lbl1.Size = new System.Drawing.Size(139, 40);
            this.RE_lbl1.TabIndex = 10;
            this.RE_lbl1.Text = "工單操作";
            // 
            // R_ucWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RE_lbl1);
            this.Controls.Add(this.RE_lbl);
            this.Controls.Add(this.RE_lblInf);
            this.Controls.Add(this.RE_lblSelect);
            this.Controls.Add(this.RE_SearchT);
            this.Controls.Add(this.RE_cob);
            this.Controls.Add(this.RE_dataGridView1);
            this.Controls.Add(this.RE_btndele);
            this.Controls.Add(this.ER_btnSelect);
            this.Controls.Add(this.RE_btnupd);
            this.Controls.Add(this.RE_update);
            this.Controls.Add(this.RE_btnNew);
            this.Controls.Add(this.RE_lblCount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "R_ucWorkOrder";
            this.Size = new System.Drawing.Size(1384, 858);
            ((System.ComponentModel.ISupportInitialize)(this.RE_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ReapairDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RE_lblCount;
        private System.Windows.Forms.Button RE_btnNew;
        private System.Windows.Forms.Button RE_update;
        private System.Windows.Forms.Button ER_btnSelect;
        private System.Windows.Forms.Button RE_btndele;
        private System.Windows.Forms.DataGridView RE_dataGridView1;
        private DataSet.R_ReapairDataSet r_ReapairDataSet1;
        private System.Windows.Forms.ComboBox RE_cob;
        private System.Windows.Forms.TextBox RE_SearchT;
        private System.Windows.Forms.Label RE_lblSelect;
        private System.Windows.Forms.Label RE_lblInf;
        private System.Windows.Forms.Button RE_btnupd;
        private DataSet.R_ReapairDataSetTableAdapters.WorkOrderTableAdapter workOrderTableAdapter1;
        private Dicuss.DataSet.D_ACDataSet d_ACDataSet1;
        private System.Windows.Forms.Label RE_lbl;
        private System.Windows.Forms.Label RE_lbl1;
    }
}
