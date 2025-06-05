namespace prjAircondition.Repair
{
    partial class R_ucMaterialUsage
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
            this.RE_lblSearchTitle = new System.Windows.Forms.Label();
            this.RE_lblMember = new System.Windows.Forms.Label();
            this.RE_txtMemberID = new System.Windows.Forms.TextBox();
            this.RE_lblDateFrom = new System.Windows.Forms.Label();
            this.RE_dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.RE_dtpTo = new System.Windows.Forms.DateTimePicker();
            this.RE_lblDateTo = new System.Windows.Forms.Label();
            this.RE_btnSearch = new System.Windows.Forms.Button();
            this.RE_lblCoolingTotal = new System.Windows.Forms.Label();
            this.RE_lblMaterialTotal = new System.Windows.Forms.Label();
            this.RE_lblTotalLoss = new System.Windows.Forms.Label();
            this.RE_dgvOrderLoss = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RE_dgvOrderLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // RE_lblSearchTitle
            // 
            this.RE_lblSearchTitle.AutoSize = true;
            this.RE_lblSearchTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblSearchTitle.Location = new System.Drawing.Point(61, 75);
            this.RE_lblSearchTitle.Name = "RE_lblSearchTitle";
            this.RE_lblSearchTitle.Size = new System.Drawing.Size(112, 22);
            this.RE_lblSearchTitle.TabIndex = 0;
            this.RE_lblSearchTitle.Text = "訂單損耗查詢";
            // 
            // RE_lblMember
            // 
            this.RE_lblMember.AutoSize = true;
            this.RE_lblMember.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblMember.Location = new System.Drawing.Point(61, 123);
            this.RE_lblMember.Name = "RE_lblMember";
            this.RE_lblMember.Size = new System.Drawing.Size(78, 22);
            this.RE_lblMember.TabIndex = 0;
            this.RE_lblMember.Text = "會員帳號";
            // 
            // RE_txtMemberID
            // 
            this.RE_txtMemberID.Location = new System.Drawing.Point(145, 120);
            this.RE_txtMemberID.Name = "RE_txtMemberID";
            this.RE_txtMemberID.Size = new System.Drawing.Size(100, 25);
            this.RE_txtMemberID.TabIndex = 1;
            // 
            // RE_lblDateFrom
            // 
            this.RE_lblDateFrom.AutoSize = true;
            this.RE_lblDateFrom.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblDateFrom.Location = new System.Drawing.Point(267, 123);
            this.RE_lblDateFrom.Name = "RE_lblDateFrom";
            this.RE_lblDateFrom.Size = new System.Drawing.Size(78, 22);
            this.RE_lblDateFrom.TabIndex = 0;
            this.RE_lblDateFrom.Text = "起始日期";
            // 
            // RE_dtpFrom
            // 
            this.RE_dtpFrom.Location = new System.Drawing.Point(351, 123);
            this.RE_dtpFrom.Name = "RE_dtpFrom";
            this.RE_dtpFrom.Size = new System.Drawing.Size(200, 25);
            this.RE_dtpFrom.TabIndex = 2;
            // 
            // RE_dtpTo
            // 
            this.RE_dtpTo.Location = new System.Drawing.Point(655, 126);
            this.RE_dtpTo.Name = "RE_dtpTo";
            this.RE_dtpTo.Size = new System.Drawing.Size(200, 25);
            this.RE_dtpTo.TabIndex = 2;
            // 
            // RE_lblDateTo
            // 
            this.RE_lblDateTo.AutoSize = true;
            this.RE_lblDateTo.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblDateTo.Location = new System.Drawing.Point(571, 126);
            this.RE_lblDateTo.Name = "RE_lblDateTo";
            this.RE_lblDateTo.Size = new System.Drawing.Size(78, 22);
            this.RE_lblDateTo.TabIndex = 0;
            this.RE_lblDateTo.Text = "結束日期";
            // 
            // RE_btnSearch
            // 
            this.RE_btnSearch.Location = new System.Drawing.Point(872, 126);
            this.RE_btnSearch.Name = "RE_btnSearch";
            this.RE_btnSearch.Size = new System.Drawing.Size(92, 29);
            this.RE_btnSearch.TabIndex = 3;
            this.RE_btnSearch.Text = "查詢";
            this.RE_btnSearch.UseVisualStyleBackColor = true;
            // 
            // RE_lblCoolingTotal
            // 
            this.RE_lblCoolingTotal.AutoSize = true;
            this.RE_lblCoolingTotal.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblCoolingTotal.Location = new System.Drawing.Point(200, 179);
            this.RE_lblCoolingTotal.Name = "RE_lblCoolingTotal";
            this.RE_lblCoolingTotal.Size = new System.Drawing.Size(95, 22);
            this.RE_lblCoolingTotal.TabIndex = 0;
            this.RE_lblCoolingTotal.Text = "冷氣總金額";
            // 
            // RE_lblMaterialTotal
            // 
            this.RE_lblMaterialTotal.AutoSize = true;
            this.RE_lblMaterialTotal.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblMaterialTotal.Location = new System.Drawing.Point(397, 179);
            this.RE_lblMaterialTotal.Name = "RE_lblMaterialTotal";
            this.RE_lblMaterialTotal.Size = new System.Drawing.Size(95, 22);
            this.RE_lblMaterialTotal.TabIndex = 0;
            this.RE_lblMaterialTotal.Text = "材料總金額";
            // 
            // RE_lblTotalLoss
            // 
            this.RE_lblTotalLoss.AutoSize = true;
            this.RE_lblTotalLoss.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblTotalLoss.Location = new System.Drawing.Point(621, 179);
            this.RE_lblTotalLoss.Name = "RE_lblTotalLoss";
            this.RE_lblTotalLoss.Size = new System.Drawing.Size(44, 22);
            this.RE_lblTotalLoss.TabIndex = 0;
            this.RE_lblTotalLoss.Text = "合計";
            // 
            // RE_dgvOrderLoss
            // 
            this.RE_dgvOrderLoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RE_dgvOrderLoss.Location = new System.Drawing.Point(65, 244);
            this.RE_dgvOrderLoss.Name = "RE_dgvOrderLoss";
            this.RE_dgvOrderLoss.RowHeadersWidth = 51;
            this.RE_dgvOrderLoss.RowTemplate.Height = 27;
            this.RE_dgvOrderLoss.Size = new System.Drawing.Size(899, 366);
            this.RE_dgvOrderLoss.TabIndex = 4;
            // 
            // R_ucMaterialUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RE_dgvOrderLoss);
            this.Controls.Add(this.RE_btnSearch);
            this.Controls.Add(this.RE_dtpTo);
            this.Controls.Add(this.RE_dtpFrom);
            this.Controls.Add(this.RE_txtMemberID);
            this.Controls.Add(this.RE_lblTotalLoss);
            this.Controls.Add(this.RE_lblMaterialTotal);
            this.Controls.Add(this.RE_lblCoolingTotal);
            this.Controls.Add(this.RE_lblDateTo);
            this.Controls.Add(this.RE_lblDateFrom);
            this.Controls.Add(this.RE_lblMember);
            this.Controls.Add(this.RE_lblSearchTitle);
            this.Name = "R_ucMaterialUsage";
            this.Size = new System.Drawing.Size(1004, 697);
            ((System.ComponentModel.ISupportInitialize)(this.RE_dgvOrderLoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RE_lblSearchTitle;
        private System.Windows.Forms.Label RE_lblMember;
        private System.Windows.Forms.TextBox RE_txtMemberID;
        private System.Windows.Forms.Label RE_lblDateFrom;
        private System.Windows.Forms.DateTimePicker RE_dtpFrom;
        private System.Windows.Forms.DateTimePicker RE_dtpTo;
        private System.Windows.Forms.Label RE_lblDateTo;
        private System.Windows.Forms.Button RE_btnSearch;
        private System.Windows.Forms.Label RE_lblCoolingTotal;
        private System.Windows.Forms.Label RE_lblMaterialTotal;
        private System.Windows.Forms.Label RE_lblTotalLoss;
        private System.Windows.Forms.DataGridView RE_dgvOrderLoss;
    }
}
