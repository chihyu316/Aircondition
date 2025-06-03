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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ER_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RE_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.r_ReapairDataSet1 = new prjAircondition.Repair.DataSet.R_ReapairDataSet();
            this.ER_comboBox1 = new System.Windows.Forms.ComboBox();
            this.ER_SearchT = new System.Windows.Forms.TextBox();
            this.ER_label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RE_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ReapairDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ER_lblCount
            // 
            this.ER_lblCount.AutoSize = true;
            this.ER_lblCount.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ER_lblCount.Location = new System.Drawing.Point(424, 258);
            this.ER_lblCount.Name = "ER_lblCount";
            this.ER_lblCount.Size = new System.Drawing.Size(99, 36);
            this.ER_lblCount.TabIndex = 0;
            this.ER_lblCount.Text = "總件數";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "新增工單";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ER_btn
            // 
            this.ER_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ER_btn.Location = new System.Drawing.Point(652, 66);
            this.ER_btn.Name = "ER_btn";
            this.ER_btn.Size = new System.Drawing.Size(96, 47);
            this.ER_btn.TabIndex = 3;
            this.ER_btn.Text = "查詢";
            this.ER_btn.UseVisualStyleBackColor = true;
            this.ER_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 47);
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
            // ER_comboBox1
            // 
            this.ER_comboBox1.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ER_comboBox1.FormattingEnabled = true;
            this.ER_comboBox1.Items.AddRange(new object[] {
            "工作類型",
            "師傅名稱",
            "會員名稱",
            "工單建立日期",
            "工單狀態",
            "付款方式",
            "施工地址"});
            this.ER_comboBox1.Location = new System.Drawing.Point(331, 80);
            this.ER_comboBox1.Name = "ER_comboBox1";
            this.ER_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.ER_comboBox1.TabIndex = 6;
            this.ER_comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ER_SearchT
            // 
            this.ER_SearchT.Font = new System.Drawing.Font("微軟正黑體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ER_SearchT.Location = new System.Drawing.Point(526, 83);
            this.ER_SearchT.Name = "ER_SearchT";
            this.ER_SearchT.Size = new System.Drawing.Size(120, 23);
            this.ER_SearchT.TabIndex = 7;
            // 
            // ER_label2
            // 
            this.ER_label2.AutoSize = true;
            this.ER_label2.Location = new System.Drawing.Point(263, 83);
            this.ER_label2.Name = "ER_label2";
            this.ER_label2.Size = new System.Drawing.Size(62, 13);
            this.ER_label2.TabIndex = 8;
            this.ER_label2.Text = "搜尋欄位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "輸入資料:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(867, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // R_ucWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ER_label2);
            this.Controls.Add(this.ER_SearchT);
            this.Controls.Add(this.ER_comboBox1);
            this.Controls.Add(this.RE_dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ER_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ER_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView RE_dataGridView1;
        private DataSet.R_ReapairDataSet r_ReapairDataSet1;
        private System.Windows.Forms.ComboBox ER_comboBox1;
        private System.Windows.Forms.TextBox ER_SearchT;
        private System.Windows.Forms.Label ER_label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
