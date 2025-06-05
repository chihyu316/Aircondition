namespace prjAircondition
{
    partial class D_ReplyControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NickNameT = new System.Windows.Forms.TextBox();
            this.TitleT = new System.Windows.Forms.TextBox();
            this.ContextT = new System.Windows.Forms.TextBox();
            this.Insert_Post = new System.Windows.Forms.Button();
            this.PostSortCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增文章";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(104, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "文章標題:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(104, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "文章分類:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(104, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "文章內容:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(104, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "發文者:";
            // 
            // NickNameT
            // 
            this.NickNameT.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.NickNameT.Location = new System.Drawing.Point(202, 91);
            this.NickNameT.Name = "NickNameT";
            this.NickNameT.ReadOnly = true;
            this.NickNameT.Size = new System.Drawing.Size(282, 33);
            this.NickNameT.TabIndex = 5;
            // 
            // TitleT
            // 
            this.TitleT.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.TitleT.Location = new System.Drawing.Point(201, 172);
            this.TitleT.Name = "TitleT";
            this.TitleT.Size = new System.Drawing.Size(283, 33);
            this.TitleT.TabIndex = 6;
            // 
            // ContextT
            // 
            this.ContextT.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.ContextT.Location = new System.Drawing.Point(201, 212);
            this.ContextT.Multiline = true;
            this.ContextT.Name = "ContextT";
            this.ContextT.Size = new System.Drawing.Size(283, 206);
            this.ContextT.TabIndex = 8;
            // 
            // Insert_Post
            // 
            this.Insert_Post.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Insert_Post.Location = new System.Drawing.Point(247, 458);
            this.Insert_Post.Name = "Insert_Post";
            this.Insert_Post.Size = new System.Drawing.Size(122, 36);
            this.Insert_Post.TabIndex = 9;
            this.Insert_Post.Text = "新增文章";
            this.Insert_Post.UseVisualStyleBackColor = true;
            this.Insert_Post.Click += new System.EventHandler(this.Insert_Post_Click);
            // 
            // PostSortCombo
            // 
            this.PostSortCombo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.PostSortCombo.FormattingEnabled = true;
            this.PostSortCombo.Items.AddRange(new object[] {
            "版務規定",
            "閒聊討論",
            "疑難雜症",
            "心得分享"});
            this.PostSortCombo.Location = new System.Drawing.Point(201, 131);
            this.PostSortCombo.Name = "PostSortCombo";
            this.PostSortCombo.Size = new System.Drawing.Size(283, 32);
            this.PostSortCombo.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-45, 690);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 97);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // D_ReplyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PostSortCombo);
            this.Controls.Add(this.Insert_Post);
            this.Controls.Add(this.ContextT);
            this.Controls.Add(this.TitleT);
            this.Controls.Add(this.NickNameT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "D_ReplyControl";
            this.Size = new System.Drawing.Size(600, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NickNameT;
        private System.Windows.Forms.TextBox TitleT;
        private System.Windows.Forms.TextBox ContextT;
        private System.Windows.Forms.Button Insert_Post;
        private System.Windows.Forms.ComboBox PostSortCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
