namespace prjAircondition.Repair
{
    partial class R_ucInstallationChecklist
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
            this.RE_checklist = new System.Windows.Forms.DataGridView();
            this.RE_btnNew1 = new System.Windows.Forms.Button();
            this.RE_btnupdate = new System.Windows.Forms.Button();
            this.RE_delet = new System.Windows.Forms.Button();
            this.RE_ref = new System.Windows.Forms.Button();
            this.RE_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RE_checklist)).BeginInit();
            this.SuspendLayout();
            // 
            // RE_checklist
            // 
            this.RE_checklist.AllowUserToAddRows = false;
            this.RE_checklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RE_checklist.Location = new System.Drawing.Point(55, 151);
            this.RE_checklist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_checklist.Name = "RE_checklist";
            this.RE_checklist.RowHeadersWidth = 51;
            this.RE_checklist.RowTemplate.Height = 24;
            this.RE_checklist.Size = new System.Drawing.Size(1028, 489);
            this.RE_checklist.TabIndex = 0;
            // 
            // RE_btnNew1
            // 
            this.RE_btnNew1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnNew1.Location = new System.Drawing.Point(501, 98);
            this.RE_btnNew1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_btnNew1.Name = "RE_btnNew1";
            this.RE_btnNew1.Size = new System.Drawing.Size(136, 46);
            this.RE_btnNew1.TabIndex = 1;
            this.RE_btnNew1.Text = "新增";
            this.RE_btnNew1.UseVisualStyleBackColor = true;
            this.RE_btnNew1.Click += new System.EventHandler(this.RE_btnNew1_Click);
            // 
            // RE_btnupdate
            // 
            this.RE_btnupdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnupdate.Location = new System.Drawing.Point(645, 98);
            this.RE_btnupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_btnupdate.Name = "RE_btnupdate";
            this.RE_btnupdate.Size = new System.Drawing.Size(136, 46);
            this.RE_btnupdate.TabIndex = 2;
            this.RE_btnupdate.Text = "儲存";
            this.RE_btnupdate.UseVisualStyleBackColor = true;
            this.RE_btnupdate.Click += new System.EventHandler(this.RE_btnupdate_Click);
            // 
            // RE_delet
            // 
            this.RE_delet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_delet.Location = new System.Drawing.Point(939, 98);
            this.RE_delet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_delet.Name = "RE_delet";
            this.RE_delet.Size = new System.Drawing.Size(129, 50);
            this.RE_delet.TabIndex = 2;
            this.RE_delet.Text = "刪除";
            this.RE_delet.UseVisualStyleBackColor = true;
            this.RE_delet.Click += new System.EventHandler(this.RE_delet_Click);
            // 
            // RE_ref
            // 
            this.RE_ref.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_ref.Location = new System.Drawing.Point(789, 98);
            this.RE_ref.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_ref.Name = "RE_ref";
            this.RE_ref.Size = new System.Drawing.Size(141, 49);
            this.RE_ref.TabIndex = 2;
            this.RE_ref.Text = "重新整理";
            this.RE_ref.UseVisualStyleBackColor = true;
            this.RE_ref.Click += new System.EventHandler(this.RE_ref_Click);
            // 
            // RE_lbl
            // 
            this.RE_lbl.AutoSize = true;
            this.RE_lbl.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lbl.Location = new System.Drawing.Point(79, 95);
            this.RE_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RE_lbl.Name = "RE_lbl";
            this.RE_lbl.Size = new System.Drawing.Size(59, 29);
            this.RE_lbl.TabIndex = 4;
            this.RE_lbl.Text = "筆數";
            // 
            // R_ucInstallationChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RE_lbl);
            this.Controls.Add(this.RE_ref);
            this.Controls.Add(this.RE_delet);
            this.Controls.Add(this.RE_btnupdate);
            this.Controls.Add(this.RE_btnNew1);
            this.Controls.Add(this.RE_checklist);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "R_ucInstallationChecklist";
            this.Size = new System.Drawing.Size(1140, 668);
            this.Load += new System.EventHandler(this.R_ucInstallationChecklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RE_checklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RE_checklist;
        private System.Windows.Forms.Button RE_btnNew1;
        private System.Windows.Forms.Button RE_btnupdate;
        private System.Windows.Forms.Button RE_delet;
        private System.Windows.Forms.Button RE_ref;
        private System.Windows.Forms.Label RE_lbl;
    }
}
