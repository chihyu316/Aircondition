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
            this.D_label2 = new System.Windows.Forms.Label();
            this.D_label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.D_textTitleT = new System.Windows.Forms.TextBox();
            this.D_Btn_Date = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.D_textUserT = new System.Windows.Forms.TextBox();
            this.D_PostdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.D_PL_Combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.D_ListContextT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.D_ListUserT = new System.Windows.Forms.TextBox();
            this.D_ListSortT = new System.Windows.Forms.TextBox();
            this.D_ListTitleT = new System.Windows.Forms.TextBox();
            this.D_label5 = new System.Windows.Forms.Label();
            this.D_label4 = new System.Windows.Forms.Label();
            this.D_label3 = new System.Windows.Forms.Label();
            this.D_BTN_Update = new System.Windows.Forms.Button();
            this.D_BTN_Delete = new System.Windows.Forms.Button();
            this.d_ACDataSet1 = new prjAircondition.Dicuss.DataSet.D_ACDataSet();
            this.postsMainTableAdapter1 = new prjAircondition.Dicuss.DataSet.D_ACDataSetTableAdapters.PostsMainTableAdapter();
            this.D_L_Data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D_PostdataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // D_label2
            // 
            this.D_label2.AutoSize = true;
            this.D_label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_label2.Location = new System.Drawing.Point(823, 18);
            this.D_label2.Name = "D_label2";
            this.D_label2.Size = new System.Drawing.Size(26, 21);
            this.D_label2.TabIndex = 4;
            this.D_label2.Text = "月";
            // 
            // D_label1
            // 
            this.D_label1.AutoSize = true;
            this.D_label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_label1.Location = new System.Drawing.Point(707, 18);
            this.D_label1.Name = "D_label1";
            this.D_label1.Size = new System.Drawing.Size(26, 21);
            this.D_label1.TabIndex = 3;
            this.D_label1.Text = "年";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownWidth = 72;
            this.comboBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(739, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 29);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(629, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // D_textTitleT
            // 
            this.D_textTitleT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_textTitleT.Location = new System.Drawing.Point(115, 15);
            this.D_textTitleT.Name = "D_textTitleT";
            this.D_textTitleT.Size = new System.Drawing.Size(182, 29);
            this.D_textTitleT.TabIndex = 1;
            // 
            // D_Btn_Date
            // 
            this.D_Btn_Date.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_Btn_Date.Location = new System.Drawing.Point(855, 15);
            this.D_Btn_Date.Name = "D_Btn_Date";
            this.D_Btn_Date.Size = new System.Drawing.Size(97, 29);
            this.D_Btn_Date.TabIndex = 0;
            this.D_Btn_Date.Text = "查詢";
            this.D_Btn_Date.UseVisualStyleBackColor = true;
            this.D_Btn_Date.Click += new System.EventHandler(this.D_Btn_Date_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // D_textUserT
            // 
            this.D_textUserT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_textUserT.Location = new System.Drawing.Point(403, 15);
            this.D_textUserT.Name = "D_textUserT";
            this.D_textUserT.Size = new System.Drawing.Size(140, 29);
            this.D_textUserT.TabIndex = 1;
            // 
            // D_PostdataGridView
            // 
            this.D_PostdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_PostdataGridView.Location = new System.Drawing.Point(8, 118);
            this.D_PostdataGridView.Name = "D_PostdataGridView";
            this.D_PostdataGridView.RowTemplate.Height = 24;
            this.D_PostdataGridView.Size = new System.Drawing.Size(526, 455);
            this.D_PostdataGridView.TabIndex = 5;
            this.D_PostdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.D_PostdataGridView.SelectionChanged += new System.EventHandler(this.PostMaindataGridView_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.D_PL_Combobox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.D_ListContextT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.D_ListUserT);
            this.groupBox3.Controls.Add(this.D_ListSortT);
            this.groupBox3.Controls.Add(this.D_ListTitleT);
            this.groupBox3.Controls.Add(this.D_label5);
            this.groupBox3.Controls.Add(this.D_label4);
            this.groupBox3.Controls.Add(this.D_label3);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(577, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 506);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文章詳細資料";
            // 
            // D_PL_Combobox
            // 
            this.D_PL_Combobox.DropDownWidth = 72;
            this.D_PL_Combobox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_PL_Combobox.FormattingEnabled = true;
            this.D_PL_Combobox.Items.AddRange(new object[] {
            "精華",
            "置頂",
            "一般"});
            this.D_PL_Combobox.Location = new System.Drawing.Point(103, 180);
            this.D_PL_Combobox.Name = "D_PL_Combobox";
            this.D_PL_Combobox.Size = new System.Drawing.Size(84, 29);
            this.D_PL_Combobox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "文章狀態:";
            // 
            // D_ListContextT
            // 
            this.D_ListContextT.Location = new System.Drawing.Point(10, 281);
            this.D_ListContextT.Multiline = true;
            this.D_ListContextT.Name = "D_ListContextT";
            this.D_ListContextT.ReadOnly = true;
            this.D_ListContextT.Size = new System.Drawing.Size(399, 225);
            this.D_ListContextT.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "文章內容:";
            // 
            // D_ListUserT
            // 
            this.D_ListUserT.Location = new System.Drawing.Point(105, 26);
            this.D_ListUserT.Name = "D_ListUserT";
            this.D_ListUserT.ReadOnly = true;
            this.D_ListUserT.Size = new System.Drawing.Size(304, 33);
            this.D_ListUserT.TabIndex = 9;
            // 
            // D_ListSortT
            // 
            this.D_ListSortT.Location = new System.Drawing.Point(105, 123);
            this.D_ListSortT.Name = "D_ListSortT";
            this.D_ListSortT.ReadOnly = true;
            this.D_ListSortT.Size = new System.Drawing.Size(304, 33);
            this.D_ListSortT.TabIndex = 8;
            // 
            // D_ListTitleT
            // 
            this.D_ListTitleT.Location = new System.Drawing.Point(105, 73);
            this.D_ListTitleT.Name = "D_ListTitleT";
            this.D_ListTitleT.ReadOnly = true;
            this.D_ListTitleT.Size = new System.Drawing.Size(304, 33);
            this.D_ListTitleT.TabIndex = 7;
            // 
            // D_label5
            // 
            this.D_label5.AutoSize = true;
            this.D_label5.Location = new System.Drawing.Point(27, 29);
            this.D_label5.Name = "D_label5";
            this.D_label5.Size = new System.Drawing.Size(72, 24);
            this.D_label5.TabIndex = 6;
            this.D_label5.Text = "發文者:";
            // 
            // D_label4
            // 
            this.D_label4.AutoSize = true;
            this.D_label4.Location = new System.Drawing.Point(8, 126);
            this.D_label4.Name = "D_label4";
            this.D_label4.Size = new System.Drawing.Size(91, 24);
            this.D_label4.TabIndex = 5;
            this.D_label4.Text = "文章類型:";
            // 
            // D_label3
            // 
            this.D_label3.AutoSize = true;
            this.D_label3.Location = new System.Drawing.Point(8, 79);
            this.D_label3.Name = "D_label3";
            this.D_label3.Size = new System.Drawing.Size(91, 24);
            this.D_label3.TabIndex = 4;
            this.D_label3.Text = "文章標題:";
            // 
            // D_BTN_Update
            // 
            this.D_BTN_Update.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.D_BTN_Update.Location = new System.Drawing.Point(115, 67);
            this.D_BTN_Update.Name = "D_BTN_Update";
            this.D_BTN_Update.Size = new System.Drawing.Size(93, 33);
            this.D_BTN_Update.TabIndex = 8;
            this.D_BTN_Update.Text = "修改";
            this.D_BTN_Update.UseVisualStyleBackColor = true;
            this.D_BTN_Update.Click += new System.EventHandler(this.D_BTN_Update_Click);
            // 
            // D_BTN_Delete
            // 
            this.D_BTN_Delete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.D_BTN_Delete.Location = new System.Drawing.Point(214, 67);
            this.D_BTN_Delete.Name = "D_BTN_Delete";
            this.D_BTN_Delete.Size = new System.Drawing.Size(93, 33);
            this.D_BTN_Delete.TabIndex = 9;
            this.D_BTN_Delete.Text = "刪除";
            this.D_BTN_Delete.UseVisualStyleBackColor = true;
            this.D_BTN_Delete.Click += new System.EventHandler(this.D_BTN_Delete_Click);
            // 
            // d_ACDataSet1
            // 
            this.d_ACDataSet1.DataSetName = "D_ACDataSet";
            this.d_ACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsMainTableAdapter1
            // 
            this.postsMainTableAdapter1.ClearBeforeFill = true;
            // 
            // D_L_Data
            // 
            this.D_L_Data.AutoSize = true;
            this.D_L_Data.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.D_L_Data.Location = new System.Drawing.Point(545, 18);
            this.D_L_Data.Name = "D_L_Data";
            this.D_L_Data.Size = new System.Drawing.Size(78, 21);
            this.D_L_Data.TabIndex = 10;
            this.D_L_Data.Text = "日期查詢:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(303, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "發文者查詢:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "標題查詢:";
            // 
            // D_DisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.D_label2);
            this.Controls.Add(this.D_textUserT);
            this.Controls.Add(this.D_label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.D_L_Data);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.D_Btn_Date);
            this.Controls.Add(this.D_textTitleT);
            this.Controls.Add(this.D_BTN_Delete);
            this.Controls.Add(this.D_BTN_Update);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.D_PostdataGridView);
            this.Name = "D_DisControl";
            this.Size = new System.Drawing.Size(1006, 583);
            ((System.ComponentModel.ISupportInitialize)(this.D_PostdataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label D_label2;
        private System.Windows.Forms.Label D_label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox D_textTitleT;
        private System.Windows.Forms.Button D_Btn_Date;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox D_textUserT;
        private System.Windows.Forms.DataGridView D_PostdataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label D_label3;
        private System.Windows.Forms.Label D_label5;
        private System.Windows.Forms.Label D_label4;
        private System.Windows.Forms.TextBox D_ListSortT;
        private System.Windows.Forms.TextBox D_ListTitleT;
        private System.Windows.Forms.TextBox D_ListUserT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox D_ListContextT;
        private System.Windows.Forms.Button D_BTN_Update;
        private System.Windows.Forms.Button D_BTN_Delete;
        private DataSet.D_ACDataSet d_ACDataSet1;
        private DataSet.D_ACDataSetTableAdapters.PostsMainTableAdapter postsMainTableAdapter1;
        private System.Windows.Forms.Label D_L_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox D_PL_Combobox;
    }
}
