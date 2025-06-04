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
            this.ER_lblCount = new System.Windows.Forms.Label();
            this.RE_btnNew = new System.Windows.Forms.Button();
            this.RE_update = new System.Windows.Forms.Button();
            this.ER_btnSelect = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RE_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.r_ReapairDataSet1 = new prjAircondition.Repair.DataSet.R_ReapairDataSet();
            this.RE_cob = new System.Windows.Forms.ComboBox();
            this.RE_SearchT = new System.Windows.Forms.TextBox();
            this.RE_lblSelect = new System.Windows.Forms.Label();
            this.RE_lblInf = new System.Windows.Forms.Label();
            this.RE_lblType = new System.Windows.Forms.Label();
            this.RE_txtType = new System.Windows.Forms.TextBox();
            this.RE_txtmod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RE_txtMem = new System.Windows.Forms.TextBox();
            this.RE_lblMem = new System.Windows.Forms.Label();
            this.RE_txtaddre = new System.Windows.Forms.TextBox();
            this.RE_lbladdr = new System.Windows.Forms.Label();
            this.RE_btnupd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RE_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ReapairDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ER_lblCount
            // 
            this.ER_lblCount.AutoSize = true;
            this.ER_lblCount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ER_lblCount.Location = new System.Drawing.Point(54, 260);
            this.ER_lblCount.Name = "ER_lblCount";
            this.ER_lblCount.Size = new System.Drawing.Size(99, 36);
            this.ER_lblCount.TabIndex = 0;
            this.ER_lblCount.Text = "總件數";
            // 
            // RE_btnNew
            // 
            this.RE_btnNew.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnNew.Location = new System.Drawing.Point(855, 93);
            this.RE_btnNew.Name = "RE_btnNew";
            this.RE_btnNew.Size = new System.Drawing.Size(96, 45);
            this.RE_btnNew.TabIndex = 1;
            this.RE_btnNew.Text = "新增工單";
            this.RE_btnNew.UseVisualStyleBackColor = true;
            this.RE_btnNew.Click += new System.EventHandler(this.RE_btnNew_Click);
            // 
            // RE_update
            // 
            this.RE_update.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_update.Location = new System.Drawing.Point(855, 144);
            this.RE_update.Name = "RE_update";
            this.RE_update.Size = new System.Drawing.Size(95, 45);
            this.RE_update.TabIndex = 2;
            this.RE_update.Text = "Fill";
            this.RE_update.UseVisualStyleBackColor = true;
            this.RE_update.Click += new System.EventHandler(this.RE_update_Click);
            // 
            // ER_btnSelect
            // 
            this.ER_btnSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ER_btnSelect.Location = new System.Drawing.Point(856, 6);
            this.ER_btnSelect.Name = "ER_btnSelect";
            this.ER_btnSelect.Size = new System.Drawing.Size(96, 47);
            this.ER_btnSelect.TabIndex = 3;
            this.ER_btnSelect.Text = "查詢";
            this.ER_btnSelect.UseVisualStyleBackColor = true;
            this.ER_btnSelect.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(855, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "刪除";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RE_dataGridView1
            // 
            this.RE_dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RE_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RE_dataGridView1.Location = new System.Drawing.Point(46, 299);
            this.RE_dataGridView1.Name = "RE_dataGridView1";
            this.RE_dataGridView1.RowHeadersWidth = 51;
            this.RE_dataGridView1.RowTemplate.Height = 24;
            this.RE_dataGridView1.Size = new System.Drawing.Size(943, 273);
            this.RE_dataGridView1.TabIndex = 5;
            // 
            // r_ReapairDataSet1
            // 
            this.r_ReapairDataSet1.DataSetName = "R_ReapairDataSet";
            this.r_ReapairDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.RE_cob.Location = new System.Drawing.Point(345, 14);
            this.RE_cob.Name = "RE_cob";
            this.RE_cob.Size = new System.Drawing.Size(121, 24);
            this.RE_cob.TabIndex = 6;
            // 
            // RE_SearchT
            // 
            this.RE_SearchT.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_SearchT.Location = new System.Drawing.Point(540, 17);
            this.RE_SearchT.Name = "RE_SearchT";
            this.RE_SearchT.Size = new System.Drawing.Size(120, 23);
            this.RE_SearchT.TabIndex = 7;
            // 
            // RE_lblSelect
            // 
            this.RE_lblSelect.AutoSize = true;
            this.RE_lblSelect.Location = new System.Drawing.Point(277, 17);
            this.RE_lblSelect.Name = "RE_lblSelect";
            this.RE_lblSelect.Size = new System.Drawing.Size(62, 13);
            this.RE_lblSelect.TabIndex = 8;
            this.RE_lblSelect.Text = "搜尋欄位:";
            // 
            // RE_lblInf
            // 
            this.RE_lblInf.AutoSize = true;
            this.RE_lblInf.Location = new System.Drawing.Point(472, 17);
            this.RE_lblInf.Name = "RE_lblInf";
            this.RE_lblInf.Size = new System.Drawing.Size(62, 13);
            this.RE_lblInf.TabIndex = 9;
            this.RE_lblInf.Text = "輸入資料:";
            // 
            // RE_lblType
            // 
            this.RE_lblType.AutoSize = true;
            this.RE_lblType.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblType.Location = new System.Drawing.Point(194, 102);
            this.RE_lblType.Name = "RE_lblType";
            this.RE_lblType.Size = new System.Drawing.Size(84, 17);
            this.RE_lblType.TabIndex = 8;
            this.RE_lblType.Text = "工作類型 :";
            // 
            // RE_txtType
            // 
            this.RE_txtType.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_txtType.Location = new System.Drawing.Point(280, 102);
            this.RE_txtType.Name = "RE_txtType";
            this.RE_txtType.Size = new System.Drawing.Size(120, 23);
            this.RE_txtType.TabIndex = 7;
            // 
            // RE_txtmod
            // 
            this.RE_txtmod.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_txtmod.Location = new System.Drawing.Point(485, 102);
            this.RE_txtmod.Name = "RE_txtmod";
            this.RE_txtmod.Size = new System.Drawing.Size(120, 23);
            this.RE_txtmod.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(429, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "機型 :";
            // 
            // RE_txtMem
            // 
            this.RE_txtMem.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_txtMem.Location = new System.Drawing.Point(689, 107);
            this.RE_txtMem.Name = "RE_txtMem";
            this.RE_txtMem.Size = new System.Drawing.Size(120, 23);
            this.RE_txtMem.TabIndex = 7;
            // 
            // RE_lblMem
            // 
            this.RE_lblMem.AutoSize = true;
            this.RE_lblMem.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblMem.Location = new System.Drawing.Point(633, 108);
            this.RE_lblMem.Name = "RE_lblMem";
            this.RE_lblMem.Size = new System.Drawing.Size(50, 17);
            this.RE_lblMem.TabIndex = 8;
            this.RE_lblMem.Text = "會員 :";
            // 
            // RE_txtaddre
            // 
            this.RE_txtaddre.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_txtaddre.Location = new System.Drawing.Point(250, 183);
            this.RE_txtaddre.Name = "RE_txtaddre";
            this.RE_txtaddre.Size = new System.Drawing.Size(355, 23);
            this.RE_txtaddre.TabIndex = 7;
            // 
            // RE_lbladdr
            // 
            this.RE_lbladdr.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.RE_lbladdr.AutoSize = true;
            this.RE_lbladdr.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lbladdr.Location = new System.Drawing.Point(194, 184);
            this.RE_lbladdr.Name = "RE_lbladdr";
            this.RE_lbladdr.Size = new System.Drawing.Size(50, 17);
            this.RE_lbladdr.TabIndex = 8;
            this.RE_lbladdr.Text = "會員 :";
            // 
            // RE_btnupd
            // 
            this.RE_btnupd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnupd.Location = new System.Drawing.Point(856, 195);
            this.RE_btnupd.Name = "RE_btnupd";
            this.RE_btnupd.Size = new System.Drawing.Size(95, 45);
            this.RE_btnupd.TabIndex = 2;
            this.RE_btnupd.Text = "修改/儲存";
            this.RE_btnupd.UseVisualStyleBackColor = true;
            this.RE_btnupd.Click += new System.EventHandler(this.RE_update_Click);
            // 
            // R_ucWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RE_lblInf);
            this.Controls.Add(this.RE_lbladdr);
            this.Controls.Add(this.RE_lblMem);
            this.Controls.Add(this.RE_txtaddre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RE_txtMem);
            this.Controls.Add(this.RE_lblType);
            this.Controls.Add(this.RE_txtmod);
            this.Controls.Add(this.RE_lblSelect);
            this.Controls.Add(this.RE_txtType);
            this.Controls.Add(this.RE_SearchT);
            this.Controls.Add(this.RE_cob);
            this.Controls.Add(this.RE_dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ER_btnSelect);
            this.Controls.Add(this.RE_btnupd);
            this.Controls.Add(this.RE_update);
            this.Controls.Add(this.RE_btnNew);
            this.Controls.Add(this.ER_lblCount);
            this.Name = "R_ucWorkOrder";
            this.Size = new System.Drawing.Size(1038, 686);
            ((System.ComponentModel.ISupportInitialize)(this.RE_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ReapairDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ER_lblCount;
        private System.Windows.Forms.Button RE_btnNew;
        private System.Windows.Forms.Button RE_update;
        private System.Windows.Forms.Button ER_btnSelect;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView RE_dataGridView1;
        private DataSet.R_ReapairDataSet r_ReapairDataSet1;
        private System.Windows.Forms.ComboBox RE_cob;
        private System.Windows.Forms.TextBox RE_SearchT;
        private System.Windows.Forms.Label RE_lblSelect;
        private System.Windows.Forms.Label RE_lblInf;
        private System.Windows.Forms.Label RE_lblType;
        private System.Windows.Forms.TextBox RE_txtType;
        private System.Windows.Forms.TextBox RE_txtmod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RE_txtMem;
        private System.Windows.Forms.Label RE_lblMem;
        private System.Windows.Forms.TextBox RE_txtaddre;
        private System.Windows.Forms.Label RE_lbladdr;
        private System.Windows.Forms.Button RE_btnupd;
    }
}
