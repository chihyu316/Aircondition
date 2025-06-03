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
            this.D_button1 = new System.Windows.Forms.Button();
            this.D_groupBox1 = new System.Windows.Forms.GroupBox();
            this.D_label2 = new System.Windows.Forms.Label();
            this.D_label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.D_textTitleT = new System.Windows.Forms.TextBox();
            this.D_button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.D_textUserT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.D_PostdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.D_ListContextT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.D_ListUserT = new System.Windows.Forms.TextBox();
            this.D_ListSortT = new System.Windows.Forms.TextBox();
            this.D_ListTitleT = new System.Windows.Forms.TextBox();
            this.D_label5 = new System.Windows.Forms.Label();
            this.D_label4 = new System.Windows.Forms.Label();
            this.D_label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.d_ACDataSet1 = new prjAircondition.Dicuss.DataSet.D_ACDataSet();
            this.postsMainTableAdapter1 = new prjAircondition.Dicuss.DataSet.D_ACDataSetTableAdapters.PostsMainTableAdapter();
            this.D_groupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_PostdataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // D_button1
            // 
            this.D_button1.Location = new System.Drawing.Point(375, 42);
            this.D_button1.Name = "D_button1";
            this.D_button1.Size = new System.Drawing.Size(97, 32);
            this.D_button1.TabIndex = 0;
            this.D_button1.Text = "查詢";
            this.D_button1.UseVisualStyleBackColor = true;
            this.D_button1.Click += new System.EventHandler(this.D_button1_Click);
            // 
            // D_groupBox1
            // 
            this.D_groupBox1.Controls.Add(this.D_label2);
            this.D_groupBox1.Controls.Add(this.D_label1);
            this.D_groupBox1.Controls.Add(this.comboBox2);
            this.D_groupBox1.Controls.Add(this.comboBox1);
            this.D_groupBox1.Controls.Add(this.D_button1);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(195, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 32);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.D_textTitleT);
            this.groupBox1.Controls.Add(this.D_button2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文章標題查詢";
            // 
            // D_textTitleT
            // 
            this.D_textTitleT.Location = new System.Drawing.Point(22, 42);
            this.D_textTitleT.Name = "D_textTitleT";
            this.D_textTitleT.Size = new System.Drawing.Size(337, 33);
            this.D_textTitleT.TabIndex = 1;
            // 
            // D_button2
            // 
            this.D_button2.Location = new System.Drawing.Point(375, 42);
            this.D_button2.Name = "D_button2";
            this.D_button2.Size = new System.Drawing.Size(97, 32);
            this.D_button2.TabIndex = 0;
            this.D_button2.Text = "查詢";
            this.D_button2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.D_textUserT);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 104);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "發文者查詢";
            // 
            // D_textUserT
            // 
            this.D_textUserT.Location = new System.Drawing.Point(22, 42);
            this.D_textUserT.Name = "D_textUserT";
            this.D_textUserT.Size = new System.Drawing.Size(337, 33);
            this.D_textUserT.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // D_PostdataGridView
            // 
            this.D_PostdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_PostdataGridView.Location = new System.Drawing.Point(3, 371);
            this.D_PostdataGridView.Name = "D_PostdataGridView";
            this.D_PostdataGridView.RowTemplate.Height = 24;
            this.D_PostdataGridView.Size = new System.Drawing.Size(731, 313);
            this.D_PostdataGridView.TabIndex = 5;
            this.D_PostdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.D_ListContextT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.D_ListUserT);
            this.groupBox3.Controls.Add(this.D_ListSortT);
            this.groupBox3.Controls.Add(this.D_ListTitleT);
            this.groupBox3.Controls.Add(this.D_label5);
            this.groupBox3.Controls.Add(this.D_label4);
            this.groupBox3.Controls.Add(this.D_label3);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(740, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 673);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文章詳細資料";
            // 
            // D_ListContextT
            // 
            this.D_ListContextT.Location = new System.Drawing.Point(10, 244);
            this.D_ListContextT.Multiline = true;
            this.D_ListContextT.Name = "D_ListContextT";
            this.D_ListContextT.Size = new System.Drawing.Size(483, 423);
            this.D_ListContextT.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "文章內容:";
            // 
            // D_ListUserT
            // 
            this.D_ListUserT.Location = new System.Drawing.Point(105, 141);
            this.D_ListUserT.Name = "D_ListUserT";
            this.D_ListUserT.Size = new System.Drawing.Size(388, 33);
            this.D_ListUserT.TabIndex = 9;
            // 
            // D_ListSortT
            // 
            this.D_ListSortT.Location = new System.Drawing.Point(105, 95);
            this.D_ListSortT.Name = "D_ListSortT";
            this.D_ListSortT.Size = new System.Drawing.Size(388, 33);
            this.D_ListSortT.TabIndex = 8;
            // 
            // D_ListTitleT
            // 
            this.D_ListTitleT.Location = new System.Drawing.Point(105, 45);
            this.D_ListTitleT.Name = "D_ListTitleT";
            this.D_ListTitleT.Size = new System.Drawing.Size(388, 33);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(641, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(641, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(641, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "刪除";
            this.button4.UseVisualStyleBackColor = true;
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
            // D_DisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.D_PostdataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.D_groupBox1);
            this.Name = "D_DisControl";
            this.Size = new System.Drawing.Size(1266, 687);
            this.D_groupBox1.ResumeLayout(false);
            this.D_groupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D_PostdataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_ACDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button D_button1;
        private System.Windows.Forms.GroupBox D_groupBox1;
        private System.Windows.Forms.Label D_label2;
        private System.Windows.Forms.Label D_label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox D_textTitleT;
        private System.Windows.Forms.Button D_button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox D_textUserT;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DataSet.D_ACDataSet d_ACDataSet1;
        private DataSet.D_ACDataSetTableAdapters.PostsMainTableAdapter postsMainTableAdapter1;
    }
}
