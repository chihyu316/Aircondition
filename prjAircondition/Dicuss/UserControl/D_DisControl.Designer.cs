namespace prjAircondition.Dicuss
{
    partial class D_DisControl
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
            this.components = new System.ComponentModel.Container();
            this.D_buttonSearchDate = new System.Windows.Forms.Button();
            this.D_groupBox1 = new System.Windows.Forms.GroupBox();
            this.D_label2 = new System.Windows.Forms.Label();
            this.D_label1 = new System.Windows.Forms.Label();
            this.D_comboBox2 = new System.Windows.Forms.ComboBox();
            this.D_comboBox1 = new System.Windows.Forms.ComboBox();
            this.D_groupBox2 = new System.Windows.Forms.GroupBox();
            this.D_textTitleT = new System.Windows.Forms.TextBox();
            this.D_buttonSearchTitle = new System.Windows.Forms.Button();
            this.D_groupbox3 = new System.Windows.Forms.GroupBox();
            this.D_textUserT = new System.Windows.Forms.TextBox();
            this.D_buttoserchuser = new System.Windows.Forms.Button();
            this.D_PostdataGridView = new System.Windows.Forms.DataGridView();
            this.D_groupBox4 = new System.Windows.Forms.GroupBox();
            this.D_ListContextT = new System.Windows.Forms.TextBox();
            this.D_LabelPostMain = new System.Windows.Forms.Label();
            this.D_ListUserT = new System.Windows.Forms.TextBox();
            this.D_ListSortT = new System.Windows.Forms.TextBox();
            this.D_ListTitleT = new System.Windows.Forms.TextBox();
            this.D_label5 = new System.Windows.Forms.Label();
            this.D_label4 = new System.Windows.Forms.Label();
            this.D_label3 = new System.Windows.Forms.Label();
            this.D_buttoninsert = new System.Windows.Forms.Button();
            this.D_buttonUpdate = new System.Windows.Forms.Button();
            this.D_buttondelete = new System.Windows.Forms.Button();
            this.d_ACDataSet1 = new prjAircondition.Dicuss.DataSet.D_ACDataSet();
            this.D_postsMainTableAdapter1 = new prjAircondition.Dicuss.DataSet.D_ACDataSetTableAdapters.PostsMainTableAdapter();
            this.D_bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.D_groupBox1.SuspendLayout();
            this.D_groupBox2.SuspendLayout();
            this.D_groupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_PostdataGridView)).BeginInit();
            this.D_groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // D_buttonSearchDate
            // 
            this.D_buttonSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D_buttonSearchDate.Location = new System.Drawing.Point(375, 42);
            this.D_buttonSearchDate.Name = "D_buttonSearchDate";
            this.D_buttonSearchDate.Size = new System.Drawing.Size(97, 32);
            this.D_buttonSearchDate.TabIndex = 0;
            this.D_buttonSearchDate.Text = "查詢";
            this.D_buttonSearchDate.UseVisualStyleBackColor = true;
            this.D_buttonSearchDate.Click += new System.EventHandler(this.D_button1_Click);
            // 
            // D_groupBox1
            // 
            this.D_groupBox1.Controls.Add(this.D_label2);
            this.D_groupBox1.Controls.Add(this.D_label1);
            this.D_groupBox1.Controls.Add(this.D_comboBox2);
            this.D_groupBox1.Controls.Add(this.D_comboBox1);
            this.D_groupBox1.Controls.Add(this.D_buttonSearchDate);
            this.D_groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_groupBox1.Location = new System.Drawing.Point(12, 261);
            this.D_groupBox1.Name = "D_groupBox1";
            this.D_groupBox1.Size = new System.Drawing.Size(507, 104);
            this.D_groupBox1.TabIndex = 1;
            this.D_groupBox1.TabStop = false;
            this.D_groupBox1.Text = "文章日期查詢";
            // 
            // D_label2
            // 
            this.D_label2.AutoSize = true;
            this.D_label2.Location = new System.Drawing.Point(330, 46);
            this.D_label2.Name = "D_label2";
            this.D_label2.Size = new System.Drawing.Size(29, 24);
            this.D_label2.TabIndex = 4;
            this.D_label2.Text = "月";
            // 
            // D_label1
            // 
            this.D_label1.AutoSize = true;
            this.D_label1.Location = new System.Drawing.Point(154, 47);
            this.D_label1.Name = "D_label1";
            this.D_label1.Size = new System.Drawing.Size(29, 24);
            this.D_label1.TabIndex = 3;
            this.D_label1.Text = "年";
            // 
            // D_comboBox2
            // 
            this.D_comboBox2.FormattingEnabled = true;
            this.D_comboBox2.Location = new System.Drawing.Point(195, 42);
            this.D_comboBox2.Name = "D_comboBox2";
            this.D_comboBox2.Size = new System.Drawing.Size(121, 32);
            this.D_comboBox2.TabIndex = 2;
            // 
            // D_comboBox1
            // 
            this.D_comboBox1.FormattingEnabled = true;
            this.D_comboBox1.Location = new System.Drawing.Point(22, 42);
            this.D_comboBox1.Name = "D_comboBox1";
            this.D_comboBox1.Size = new System.Drawing.Size(121, 32);
            this.D_comboBox1.TabIndex = 1;
            // 
            // D_groupBox2
            // 
            this.D_groupBox2.Controls.Add(this.D_textTitleT);
            this.D_groupBox2.Controls.Add(this.D_buttonSearchTitle);
            this.D_groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_groupBox2.Location = new System.Drawing.Point(12, 139);
            this.D_groupBox2.Name = "D_groupBox2";
            this.D_groupBox2.Size = new System.Drawing.Size(507, 104);
            this.D_groupBox2.TabIndex = 2;
            this.D_groupBox2.TabStop = false;
            this.D_groupBox2.Text = "文章標題查詢";
            // 
            // D_textTitleT
            // 
            this.D_textTitleT.Location = new System.Drawing.Point(22, 42);
            this.D_textTitleT.Name = "D_textTitleT";
            this.D_textTitleT.Size = new System.Drawing.Size(337, 33);
            this.D_textTitleT.TabIndex = 1;
            // 
            // D_buttonSearchTitle
            // 
            this.D_buttonSearchTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D_buttonSearchTitle.Location = new System.Drawing.Point(375, 42);
            this.D_buttonSearchTitle.Name = "D_buttonSearchTitle";
            this.D_buttonSearchTitle.Size = new System.Drawing.Size(97, 32);
            this.D_buttonSearchTitle.TabIndex = 0;
            this.D_buttonSearchTitle.Text = "查詢";
            this.D_buttonSearchTitle.UseVisualStyleBackColor = true;
            // 
            // D_groupbox3
            // 
            this.D_groupbox3.Controls.Add(this.D_textUserT);
            this.D_groupbox3.Controls.Add(this.D_buttoserchuser);
            this.D_groupbox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_groupbox3.Location = new System.Drawing.Point(12, 17);
            this.D_groupbox3.Name = "D_groupbox3";
            this.D_groupbox3.Size = new System.Drawing.Size(507, 104);
            this.D_groupbox3.TabIndex = 4;
            this.D_groupbox3.TabStop = false;
            this.D_groupbox3.Text = "發文者查詢";
            // 
            // D_textUserT
            // 
            this.D_textUserT.Location = new System.Drawing.Point(22, 42);
            this.D_textUserT.Name = "D_textUserT";
            this.D_textUserT.Size = new System.Drawing.Size(337, 33);
            this.D_textUserT.TabIndex = 1;
            // 
            // D_buttoserchuser
            // 
            this.D_buttoserchuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D_buttoserchuser.Location = new System.Drawing.Point(375, 42);
            this.D_buttoserchuser.Name = "D_buttoserchuser";
            this.D_buttoserchuser.Size = new System.Drawing.Size(97, 32);
            this.D_buttoserchuser.TabIndex = 0;
            this.D_buttoserchuser.Text = "查詢";
            this.D_buttoserchuser.UseVisualStyleBackColor = true;
            this.D_buttoserchuser.Click += new System.EventHandler(this.D_buttoserchuser_Click);
            // 
            // D_PostdataGridView
            // 
            this.D_PostdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_PostdataGridView.Location = new System.Drawing.Point(3, 371);
            this.D_PostdataGridView.Name = "D_PostdataGridView";
            this.D_PostdataGridView.RowTemplate.Height = 24;
            this.D_PostdataGridView.Size = new System.Drawing.Size(516, 258);
            this.D_PostdataGridView.TabIndex = 5;
            this.D_PostdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // D_groupBox4
            // 
            this.D_groupBox4.Controls.Add(this.D_ListContextT);
            this.D_groupBox4.Controls.Add(this.D_LabelPostMain);
            this.D_groupBox4.Controls.Add(this.D_ListUserT);
            this.D_groupBox4.Controls.Add(this.D_ListSortT);
            this.D_groupBox4.Controls.Add(this.D_ListTitleT);
            this.D_groupBox4.Controls.Add(this.D_label5);
            this.D_groupBox4.Controls.Add(this.D_label4);
            this.D_groupBox4.Controls.Add(this.D_label3);
            this.D_groupBox4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.D_groupBox4.Location = new System.Drawing.Point(624, 17);
            this.D_groupBox4.Name = "D_groupBox4";
            this.D_groupBox4.Size = new System.Drawing.Size(400, 615);
            this.D_groupBox4.TabIndex = 6;
            this.D_groupBox4.TabStop = false;
            this.D_groupBox4.Text = "文章異動";
            // 
            // D_ListContextT
            // 
            this.D_ListContextT.Location = new System.Drawing.Point(10, 244);
            this.D_ListContextT.Multiline = true;
            this.D_ListContextT.Name = "D_ListContextT";
            this.D_ListContextT.Size = new System.Drawing.Size(379, 368);
            this.D_ListContextT.TabIndex = 11;
            // 
            // D_LabelPostMain
            // 
            this.D_LabelPostMain.AutoSize = true;
            this.D_LabelPostMain.Location = new System.Drawing.Point(6, 202);
            this.D_LabelPostMain.Name = "D_LabelPostMain";
            this.D_LabelPostMain.Size = new System.Drawing.Size(91, 24);
            this.D_LabelPostMain.TabIndex = 10;
            this.D_LabelPostMain.Text = "文章內容:";
            // 
            // D_ListUserT
            // 
            this.D_ListUserT.Location = new System.Drawing.Point(105, 144);
            this.D_ListUserT.Name = "D_ListUserT";
            this.D_ListUserT.Size = new System.Drawing.Size(284, 33);
            this.D_ListUserT.TabIndex = 9;
            // 
            // D_ListSortT
            // 
            this.D_ListSortT.Location = new System.Drawing.Point(105, 95);
            this.D_ListSortT.Name = "D_ListSortT";
            this.D_ListSortT.Size = new System.Drawing.Size(284, 33);
            this.D_ListSortT.TabIndex = 8;
            // 
            // D_ListTitleT
            // 
            this.D_ListTitleT.Location = new System.Drawing.Point(105, 45);
            this.D_ListTitleT.Name = "D_ListTitleT";
            this.D_ListTitleT.Size = new System.Drawing.Size(284, 33);
            this.D_ListTitleT.TabIndex = 7;
            // 
            // D_label5
            // 
            this.D_label5.AutoSize = true;
            this.D_label5.Location = new System.Drawing.Point(27, 144);
            this.D_label5.Name = "D_label5";
            this.D_label5.Size = new System.Drawing.Size(72, 24);
            this.D_label5.TabIndex = 6;
            this.D_label5.Text = "發文者:";
            // 
            // D_label4
            // 
            this.D_label4.AutoSize = true;
            this.D_label4.Location = new System.Drawing.Point(8, 98);
            this.D_label4.Name = "D_label4";
            this.D_label4.Size = new System.Drawing.Size(91, 24);
            this.D_label4.TabIndex = 5;
            this.D_label4.Text = "文章類型:";
            // 
            // D_label3
            // 
            this.D_label3.AutoSize = true;
            this.D_label3.Location = new System.Drawing.Point(8, 51);
            this.D_label3.Name = "D_label3";
            this.D_label3.Size = new System.Drawing.Size(91, 24);
            this.D_label3.TabIndex = 4;
            this.D_label3.Text = "文章標題:";
            // 
            // D_buttoninsert
            // 
            this.D_buttoninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D_buttoninsert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.D_buttoninsert.Location = new System.Drawing.Point(525, 36);
            this.D_buttoninsert.Name = "D_buttoninsert";
            this.D_buttoninsert.Size = new System.Drawing.Size(93, 33);
            this.D_buttoninsert.TabIndex = 7;
            this.D_buttoninsert.Text = "新增";
            this.D_buttoninsert.UseVisualStyleBackColor = true;
            // 
            // D_buttonUpdate
            // 
            this.D_buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D_buttonUpdate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.D_buttonUpdate.Location = new System.Drawing.Point(525, 88);
            this.D_buttonUpdate.Name = "D_buttonUpdate";
            this.D_buttonUpdate.Size = new System.Drawing.Size(93, 33);
            this.D_buttonUpdate.TabIndex = 8;
            this.D_buttonUpdate.Text = "修改";
            this.D_buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // D_buttondelete
            // 
            this.D_buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D_buttondelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.D_buttondelete.Location = new System.Drawing.Point(525, 139);
            this.D_buttondelete.Name = "D_buttondelete";
            this.D_buttondelete.Size = new System.Drawing.Size(93, 33);
            this.D_buttondelete.TabIndex = 9;
            this.D_buttondelete.Text = "刪除";
            this.D_buttondelete.UseVisualStyleBackColor = true;
            // 
            // d_ACDataSet1
            // 
            this.d_ACDataSet1.DataSetName = "D_ACDataSet";
            this.d_ACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // D_postsMainTableAdapter1
            // 
            this.D_postsMainTableAdapter1.ClearBeforeFill = true;
            // 
            // D_DisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.D_buttondelete);
            this.Controls.Add(this.D_buttonUpdate);
            this.Controls.Add(this.D_buttoninsert);
            this.Controls.Add(this.D_groupBox4);
            this.Controls.Add(this.D_PostdataGridView);
            this.Controls.Add(this.D_groupbox3);
            this.Controls.Add(this.D_groupBox2);
            this.Controls.Add(this.D_groupBox1);
            this.Name = "D_DisControl";
            this.Size = new System.Drawing.Size(1025, 632);
            this.D_groupBox1.ResumeLayout(false);
            this.D_groupBox1.PerformLayout();
            this.D_groupBox2.ResumeLayout(false);
            this.D_groupBox2.PerformLayout();
            this.D_groupbox3.ResumeLayout(false);
            this.D_groupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_PostdataGridView)).EndInit();
            this.D_groupBox4.ResumeLayout(false);
            this.D_groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button D_buttonSearchDate;
        private System.Windows.Forms.GroupBox D_groupBox1;
        private System.Windows.Forms.Label D_label2;
        private System.Windows.Forms.Label D_label1;
        private System.Windows.Forms.ComboBox D_comboBox2;
        private System.Windows.Forms.ComboBox D_comboBox1;
        private System.Windows.Forms.GroupBox D_groupBox2;
        private System.Windows.Forms.TextBox D_textTitleT;
        private System.Windows.Forms.Button D_buttonSearchTitle;
        private System.Windows.Forms.GroupBox D_groupbox3;
        private System.Windows.Forms.TextBox D_textUserT;
        private System.Windows.Forms.Button D_buttoserchuser;
        private System.Windows.Forms.DataGridView D_PostdataGridView;
        private System.Windows.Forms.GroupBox D_groupBox4;
        private System.Windows.Forms.Label D_label3;
        private System.Windows.Forms.Label D_label5;
        private System.Windows.Forms.Label D_label4;
        private System.Windows.Forms.TextBox D_ListSortT;
        private System.Windows.Forms.TextBox D_ListTitleT;
        private System.Windows.Forms.TextBox D_ListUserT;
        private System.Windows.Forms.Label D_LabelPostMain;
        private System.Windows.Forms.TextBox D_ListContextT;
        private System.Windows.Forms.Button D_buttoninsert;
        private System.Windows.Forms.Button D_buttonUpdate;
        private System.Windows.Forms.Button D_buttondelete;
        private DataSet.D_ACDataSet d_ACDataSet1;
        private DataSet.D_ACDataSetTableAdapters.PostsMainTableAdapter D_postsMainTableAdapter1;
        private System.Windows.Forms.BindingSource D_bindingSource1;
    }
}
