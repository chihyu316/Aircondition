namespace prjAircondition.Repair
{
    partial class R_ucPhotoUpload
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
            this.RE_dgvPhotoList = new System.Windows.Forms.DataGridView();
            this.RE_pbPreview = new System.Windows.Forms.PictureBox();
            this.RE_btnUpload = new System.Windows.Forms.Button();
            this.RE_btnDelete = new System.Windows.Forms.Button();
            this.RE_txtDescription = new System.Windows.Forms.TextBox();
            this.RE_lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RE_dgvPhotoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RE_pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // RE_dgvPhotoList
            // 
            this.RE_dgvPhotoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RE_dgvPhotoList.Location = new System.Drawing.Point(171, 343);
            this.RE_dgvPhotoList.Name = "RE_dgvPhotoList";
            this.RE_dgvPhotoList.RowHeadersWidth = 51;
            this.RE_dgvPhotoList.RowTemplate.Height = 24;
            this.RE_dgvPhotoList.Size = new System.Drawing.Size(701, 313);
            this.RE_dgvPhotoList.TabIndex = 0;
            this.RE_dgvPhotoList.SelectionChanged += new System.EventHandler(this.RE_dgvPhotoList_SelectionChanged);
            // 
            // RE_pbPreview
            // 
            this.RE_pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE_pbPreview.Location = new System.Drawing.Point(171, 29);
            this.RE_pbPreview.Name = "RE_pbPreview";
            this.RE_pbPreview.Size = new System.Drawing.Size(701, 174);
            this.RE_pbPreview.TabIndex = 1;
            this.RE_pbPreview.TabStop = false;
            // 
            // RE_btnUpload
            // 
            this.RE_btnUpload.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnUpload.Location = new System.Drawing.Point(264, 225);
            this.RE_btnUpload.Name = "RE_btnUpload";
            this.RE_btnUpload.Size = new System.Drawing.Size(98, 38);
            this.RE_btnUpload.TabIndex = 2;
            this.RE_btnUpload.Text = "上傳";
            this.RE_btnUpload.UseVisualStyleBackColor = true;
            this.RE_btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // RE_btnDelete
            // 
            this.RE_btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnDelete.Location = new System.Drawing.Point(260, 281);
            this.RE_btnDelete.Name = "RE_btnDelete";
            this.RE_btnDelete.Size = new System.Drawing.Size(102, 38);
            this.RE_btnDelete.TabIndex = 2;
            this.RE_btnDelete.Text = "刪除選擇";
            this.RE_btnDelete.UseVisualStyleBackColor = true;
            this.RE_btnDelete.Click += new System.EventHandler(this.RE_btnDelete_Click);
            // 
            // RE_txtDescription
            // 
            this.RE_txtDescription.Location = new System.Drawing.Point(611, 225);
            this.RE_txtDescription.Name = "RE_txtDescription";
            this.RE_txtDescription.Size = new System.Drawing.Size(100, 22);
            this.RE_txtDescription.TabIndex = 3;
            // 
            // RE_lblCount
            // 
            this.RE_lblCount.AutoSize = true;
            this.RE_lblCount.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblCount.Location = new System.Drawing.Point(626, 281);
            this.RE_lblCount.Name = "RE_lblCount";
            this.RE_lblCount.Size = new System.Drawing.Size(85, 34);
            this.RE_lblCount.TabIndex = 4;
            this.RE_lblCount.Text = "筆數";
            // 
            // R_ucPhotoUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RE_lblCount);
            this.Controls.Add(this.RE_txtDescription);
            this.Controls.Add(this.RE_btnDelete);
            this.Controls.Add(this.RE_btnUpload);
            this.Controls.Add(this.RE_pbPreview);
            this.Controls.Add(this.RE_dgvPhotoList);
            this.Name = "R_ucPhotoUpload";
            this.Size = new System.Drawing.Size(1017, 699);
            ((System.ComponentModel.ISupportInitialize)(this.RE_dgvPhotoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RE_pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RE_dgvPhotoList;
        private System.Windows.Forms.PictureBox RE_pbPreview;
        private System.Windows.Forms.Button RE_btnUpload;
        private System.Windows.Forms.Button RE_btnDelete;
        private System.Windows.Forms.TextBox RE_txtDescription;
        private System.Windows.Forms.Label RE_lblCount;
    }
}
