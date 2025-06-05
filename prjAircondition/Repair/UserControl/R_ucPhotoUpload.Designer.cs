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
            this.RE_btnSave = new System.Windows.Forms.Button();
            this.RE_btnDelete = new System.Windows.Forms.Button();
            this.RE_txtDescription = new System.Windows.Forms.TextBox();
            this.RE_lblCount = new System.Windows.Forms.Label();
            this.RE_lab10 = new System.Windows.Forms.Label();
            this.RE_btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RE_dgvPhotoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RE_pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // RE_dgvPhotoList
            // 
            this.RE_dgvPhotoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RE_dgvPhotoList.Location = new System.Drawing.Point(228, 429);
            this.RE_dgvPhotoList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_dgvPhotoList.Name = "RE_dgvPhotoList";
            this.RE_dgvPhotoList.RowHeadersWidth = 51;
            this.RE_dgvPhotoList.RowTemplate.Height = 24;
            this.RE_dgvPhotoList.Size = new System.Drawing.Size(935, 391);
            this.RE_dgvPhotoList.TabIndex = 0;
            this.RE_dgvPhotoList.SelectionChanged += new System.EventHandler(this.RE_dgvPhotoList_SelectionChanged);
            // 
            // RE_pbPreview
            // 
            this.RE_pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE_pbPreview.Location = new System.Drawing.Point(228, 36);
            this.RE_pbPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_pbPreview.Name = "RE_pbPreview";
            this.RE_pbPreview.Size = new System.Drawing.Size(934, 217);
            this.RE_pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RE_pbPreview.TabIndex = 1;
            this.RE_pbPreview.TabStop = false;
            // 
            // RE_btnSave
            // 
            this.RE_btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnSave.Location = new System.Drawing.Point(352, 281);
            this.RE_btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_btnSave.Name = "RE_btnSave";
            this.RE_btnSave.Size = new System.Drawing.Size(131, 48);
            this.RE_btnSave.TabIndex = 2;
            this.RE_btnSave.Text = "上傳圖片";
            this.RE_btnSave.UseVisualStyleBackColor = true;
            this.RE_btnSave.Click += new System.EventHandler(this.RE_btnSave_Click);
            // 
            // RE_btnDelete
            // 
            this.RE_btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnDelete.Location = new System.Drawing.Point(347, 351);
            this.RE_btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_btnDelete.Name = "RE_btnDelete";
            this.RE_btnDelete.Size = new System.Drawing.Size(136, 48);
            this.RE_btnDelete.TabIndex = 2;
            this.RE_btnDelete.Text = "刪除選擇";
            this.RE_btnDelete.UseVisualStyleBackColor = true;
            this.RE_btnDelete.Click += new System.EventHandler(this.RE_btnDelete_Click);
            // 
            // RE_txtDescription
            // 
            this.RE_txtDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_txtDescription.Location = new System.Drawing.Point(791, 294);
            this.RE_txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RE_txtDescription.Name = "RE_txtDescription";
            this.RE_txtDescription.Size = new System.Drawing.Size(347, 34);
            this.RE_txtDescription.TabIndex = 3;
            // 
            // RE_lblCount
            // 
            this.RE_lblCount.AutoSize = true;
            this.RE_lblCount.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lblCount.Location = new System.Drawing.Point(1052, 384);
            this.RE_lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RE_lblCount.Name = "RE_lblCount";
            this.RE_lblCount.Size = new System.Drawing.Size(83, 33);
            this.RE_lblCount.TabIndex = 4;
            this.RE_lblCount.Text = "筆數";
            // 
            // RE_lab10
            // 
            this.RE_lab10.AutoSize = true;
            this.RE_lab10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_lab10.Location = new System.Drawing.Point(647, 298);
            this.RE_lab10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RE_lab10.Name = "RE_lab10";
            this.RE_lab10.Size = new System.Drawing.Size(102, 25);
            this.RE_lab10.TabIndex = 5;
            this.RE_lab10.Text = "輸入敘述 :";
            // 
            // RE_btnSelect
            // 
            this.RE_btnSelect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RE_btnSelect.Location = new System.Drawing.Point(213, 281);
            this.RE_btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.RE_btnSelect.Name = "RE_btnSelect";
            this.RE_btnSelect.Size = new System.Drawing.Size(131, 48);
            this.RE_btnSelect.TabIndex = 2;
            this.RE_btnSelect.Text = "選擇圖片";
            this.RE_btnSelect.UseVisualStyleBackColor = true;
            this.RE_btnSelect.Click += new System.EventHandler(this.RE_btnSelect_Click);
            // 
            // R_ucPhotoUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RE_lab10);
            this.Controls.Add(this.RE_lblCount);
            this.Controls.Add(this.RE_txtDescription);
            this.Controls.Add(this.RE_btnDelete);
            this.Controls.Add(this.RE_btnSelect);
            this.Controls.Add(this.RE_btnSave);
            this.Controls.Add(this.RE_pbPreview);
            this.Controls.Add(this.RE_dgvPhotoList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "R_ucPhotoUpload";
            this.Size = new System.Drawing.Size(1356, 874);
            ((System.ComponentModel.ISupportInitialize)(this.RE_dgvPhotoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RE_pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RE_dgvPhotoList;
        private System.Windows.Forms.PictureBox RE_pbPreview;
        private System.Windows.Forms.Button RE_btnSave;
        private System.Windows.Forms.Button RE_btnDelete;
        private System.Windows.Forms.TextBox RE_txtDescription;
        private System.Windows.Forms.Label RE_lblCount;
        private System.Windows.Forms.Label RE_lab10;
        private System.Windows.Forms.Button RE_btnSelect;
    }
}
