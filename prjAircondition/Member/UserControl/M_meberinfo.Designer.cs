namespace prjAircondition.Member
{
    partial class M_meberinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_meberinfo));
            this.SaveBTN = new System.Windows.Forms.Button();
            this.ShowPasswordBTN = new System.Windows.Forms.Button();
            this.Accountlbl = new System.Windows.Forms.Label();
            this.NicknameTXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumberTXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassWordTXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AvatarBOX = new System.Windows.Forms.PictureBox();
            this.MemberListV = new System.Windows.Forms.ListView();
            this.memberTableAdapter1 = new prjAircondition.Member.DataSet.M_MemberDatasetTableAdapters.MemberTableAdapter();
            this.m_MemberDataset1 = new prjAircondition.Member.DataSet.M_MemberDataset();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MemberDataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(945, 357);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(83, 39);
            this.SaveBTN.TabIndex = 39;
            this.SaveBTN.Text = "儲存變更";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // ShowPasswordBTN
            // 
            this.ShowPasswordBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordBTN.BackgroundImage")));
            this.ShowPasswordBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordBTN.Location = new System.Drawing.Point(886, 161);
            this.ShowPasswordBTN.Name = "ShowPasswordBTN";
            this.ShowPasswordBTN.Size = new System.Drawing.Size(29, 31);
            this.ShowPasswordBTN.TabIndex = 38;
            this.ShowPasswordBTN.Text = "\r\n";
            this.ShowPasswordBTN.UseVisualStyleBackColor = true;
            this.ShowPasswordBTN.Click += new System.EventHandler(this.ShowPasswordBTN_Click);
            // 
            // Accountlbl
            // 
            this.Accountlbl.AutoSize = true;
            this.Accountlbl.Font = new System.Drawing.Font("新細明體", 15F);
            this.Accountlbl.Location = new System.Drawing.Point(728, 103);
            this.Accountlbl.Name = "Accountlbl";
            this.Accountlbl.Size = new System.Drawing.Size(0, 20);
            this.Accountlbl.TabIndex = 37;
            // 
            // NicknameTXB
            // 
            this.NicknameTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.NicknameTXB.Location = new System.Drawing.Point(715, 366);
            this.NicknameTXB.Name = "NicknameTXB";
            this.NicknameTXB.Size = new System.Drawing.Size(175, 31);
            this.NicknameTXB.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F);
            this.label5.Location = new System.Drawing.Point(593, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "暱稱";
            // 
            // FemaleCheckBox
            // 
            this.FemaleCheckBox.AutoSize = true;
            this.FemaleCheckBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.FemaleCheckBox.Location = new System.Drawing.Point(800, 227);
            this.FemaleCheckBox.Name = "FemaleCheckBox";
            this.FemaleCheckBox.Size = new System.Drawing.Size(48, 24);
            this.FemaleCheckBox.TabIndex = 34;
            this.FemaleCheckBox.Text = "女";
            this.FemaleCheckBox.UseVisualStyleBackColor = true;
            this.FemaleCheckBox.CheckedChanged += new System.EventHandler(this.FemaleCheckBox_CheckedChanged);
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.MaleCheckBox.Location = new System.Drawing.Point(732, 227);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(48, 24);
            this.MaleCheckBox.TabIndex = 33;
            this.MaleCheckBox.Text = "男";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            this.MaleCheckBox.CheckedChanged += new System.EventHandler(this.MaleCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(593, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "性別:";
            // 
            // PhoneNumberTXB
            // 
            this.PhoneNumberTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.PhoneNumberTXB.Location = new System.Drawing.Point(715, 288);
            this.PhoneNumberTXB.Name = "PhoneNumberTXB";
            this.PhoneNumberTXB.Size = new System.Drawing.Size(175, 31);
            this.PhoneNumberTXB.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(577, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "電話號碼:";
            // 
            // PassWordTXB
            // 
            this.PassWordTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.PassWordTXB.Location = new System.Drawing.Point(715, 161);
            this.PassWordTXB.Name = "PassWordTXB";
            this.PassWordTXB.PasswordChar = '●';
            this.PassWordTXB.Size = new System.Drawing.Size(175, 31);
            this.PassWordTXB.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(593, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "密碼:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(593, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "帳號:";
            // 
            // AvatarBOX
            // 
            this.AvatarBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarBOX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AvatarBOX.Location = new System.Drawing.Point(247, 98);
            this.AvatarBOX.Name = "AvatarBOX";
            this.AvatarBOX.Size = new System.Drawing.Size(312, 298);
            this.AvatarBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarBOX.TabIndex = 26;
            this.AvatarBOX.TabStop = false;
            // 
            // MemberListV
            // 
            this.MemberListV.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberListV.HideSelection = false;
            this.MemberListV.Location = new System.Drawing.Point(34, 98);
            this.MemberListV.Name = "MemberListV";
            this.MemberListV.Size = new System.Drawing.Size(166, 302);
            this.MemberListV.TabIndex = 40;
            this.MemberListV.UseCompatibleStateImageBehavior = false;
            this.MemberListV.View = System.Windows.Forms.View.Details;
            this.MemberListV.SelectedIndexChanged += new System.EventHandler(this.MemberListV_SelectedIndexChanged);
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // m_MemberDataset1
            // 
            this.m_MemberDataset1.DataSetName = "M_MemberDataset";
            this.m_MemberDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(945, 288);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(83, 31);
            this.DeleteBtn.TabIndex = 41;
            this.DeleteBtn.Text = "刪除帳號";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // M_meberinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.MemberListV);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.ShowPasswordBTN);
            this.Controls.Add(this.Accountlbl);
            this.Controls.Add(this.NicknameTXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FemaleCheckBox);
            this.Controls.Add(this.MaleCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumberTXB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassWordTXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvatarBOX);
            this.Name = "M_meberinfo";
            this.Size = new System.Drawing.Size(1052, 594);
            this.Load += new System.EventHandler(this.M_meberinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MemberDataset1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button ShowPasswordBTN;
        private System.Windows.Forms.Label Accountlbl;
        private System.Windows.Forms.TextBox NicknameTXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox FemaleCheckBox;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumberTXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassWordTXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AvatarBOX;
        private System.Windows.Forms.ListView MemberListV;
        private DataSet.M_MemberDatasetTableAdapters.MemberTableAdapter memberTableAdapter1;
        private DataSet.M_MemberDataset m_MemberDataset1;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
