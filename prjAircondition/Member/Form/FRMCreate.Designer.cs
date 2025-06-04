namespace prjAircondition.Member
{
    partial class FRMCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCreate));
            this.TorNOT = new System.Windows.Forms.CheckBox();
            this.ResetAvatarBTN = new System.Windows.Forms.Button();
            this.SearchFileBTN = new System.Windows.Forms.Button();
            this.ShowPasswordBTN = new System.Windows.Forms.Button();
            this.FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NickNameTXB = new System.Windows.Forms.TextBox();
            this.PhoneNumberTXB = new System.Windows.Forms.TextBox();
            this.EmailTXB = new System.Windows.Forms.TextBox();
            this.PassWordTXB = new System.Windows.Forms.TextBox();
            this.AvatarPicturebox = new System.Windows.Forms.PictureBox();
            this.AccountTXB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MemberopenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // TorNOT
            // 
            this.TorNOT.AutoSize = true;
            this.TorNOT.Font = new System.Drawing.Font("新細明體", 15F);
            this.TorNOT.Location = new System.Drawing.Point(466, 312);
            this.TorNOT.Name = "TorNOT";
            this.TorNOT.Size = new System.Drawing.Size(208, 24);
            this.TorNOT.TabIndex = 39;
            this.TorNOT.Text = "是否以師傅身分註冊";
            this.TorNOT.UseVisualStyleBackColor = true;
            // 
            // ResetAvatarBTN
            // 
            this.ResetAvatarBTN.Location = new System.Drawing.Point(232, 307);
            this.ResetAvatarBTN.Name = "ResetAvatarBTN";
            this.ResetAvatarBTN.Size = new System.Drawing.Size(89, 36);
            this.ResetAvatarBTN.TabIndex = 38;
            this.ResetAvatarBTN.Text = "使用預設圖片";
            this.ResetAvatarBTN.UseVisualStyleBackColor = true;
            this.ResetAvatarBTN.Click += new System.EventHandler(this.ResetAvatarBTN_Click_1);
            // 
            // SearchFileBTN
            // 
            this.SearchFileBTN.Location = new System.Drawing.Point(38, 307);
            this.SearchFileBTN.Name = "SearchFileBTN";
            this.SearchFileBTN.Size = new System.Drawing.Size(103, 36);
            this.SearchFileBTN.TabIndex = 37;
            this.SearchFileBTN.Text = "選擇...";
            this.SearchFileBTN.UseVisualStyleBackColor = true;
            this.SearchFileBTN.Click += new System.EventHandler(this.SearchFileBTN_Click_1);
            // 
            // ShowPasswordBTN
            // 
            this.ShowPasswordBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordBTN.BackgroundImage")));
            this.ShowPasswordBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordBTN.Location = new System.Drawing.Point(733, 68);
            this.ShowPasswordBTN.Name = "ShowPasswordBTN";
            this.ShowPasswordBTN.Size = new System.Drawing.Size(29, 31);
            this.ShowPasswordBTN.TabIndex = 36;
            this.ShowPasswordBTN.Text = "\r\n";
            this.ShowPasswordBTN.UseVisualStyleBackColor = true;
            this.ShowPasswordBTN.Click += new System.EventHandler(this.ShowPasswordBTN_Click);
            // 
            // FemaleCheckBox
            // 
            this.FemaleCheckBox.AutoSize = true;
            this.FemaleCheckBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.FemaleCheckBox.Location = new System.Drawing.Point(635, 119);
            this.FemaleCheckBox.Name = "FemaleCheckBox";
            this.FemaleCheckBox.Size = new System.Drawing.Size(48, 24);
            this.FemaleCheckBox.TabIndex = 35;
            this.FemaleCheckBox.Text = "女";
            this.FemaleCheckBox.UseVisualStyleBackColor = true;
            this.FemaleCheckBox.CheckedChanged += new System.EventHandler(this.FemaleCheckBox_CheckedChanged);
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.MaleCheckBox.Location = new System.Drawing.Point(537, 119);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(48, 24);
            this.MaleCheckBox.TabIndex = 34;
            this.MaleCheckBox.Text = "男";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            this.MaleCheckBox.CheckedChanged += new System.EventHandler(this.MaleCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F);
            this.label6.Location = new System.Drawing.Point(379, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "暱稱:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F);
            this.label5.Location = new System.Drawing.Point(352, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "電話號碼:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(379, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(379, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "性別:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(379, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "密碼:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(379, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "帳號:";
            // 
            // NickNameTXB
            // 
            this.NickNameTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.NickNameTXB.Location = new System.Drawing.Point(481, 254);
            this.NickNameTXB.MaxLength = 10;
            this.NickNameTXB.Name = "NickNameTXB";
            this.NickNameTXB.Size = new System.Drawing.Size(245, 31);
            this.NickNameTXB.TabIndex = 27;
            // 
            // PhoneNumberTXB
            // 
            this.PhoneNumberTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.PhoneNumberTXB.Location = new System.Drawing.Point(481, 206);
            this.PhoneNumberTXB.MaxLength = 10;
            this.PhoneNumberTXB.Name = "PhoneNumberTXB";
            this.PhoneNumberTXB.Size = new System.Drawing.Size(245, 31);
            this.PhoneNumberTXB.TabIndex = 26;
            // 
            // EmailTXB
            // 
            this.EmailTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.EmailTXB.Location = new System.Drawing.Point(481, 156);
            this.EmailTXB.Name = "EmailTXB";
            this.EmailTXB.Size = new System.Drawing.Size(245, 31);
            this.EmailTXB.TabIndex = 25;
            // 
            // PassWordTXB
            // 
            this.PassWordTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.PassWordTXB.Location = new System.Drawing.Point(481, 68);
            this.PassWordTXB.Name = "PassWordTXB";
            this.PassWordTXB.PasswordChar = '●';
            this.PassWordTXB.Size = new System.Drawing.Size(245, 31);
            this.PassWordTXB.TabIndex = 24;
            // 
            // AvatarPicturebox
            // 
            this.AvatarPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPicturebox.Image")));
            this.AvatarPicturebox.Location = new System.Drawing.Point(38, 45);
            this.AvatarPicturebox.Name = "AvatarPicturebox";
            this.AvatarPicturebox.Size = new System.Drawing.Size(283, 243);
            this.AvatarPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarPicturebox.TabIndex = 23;
            this.AvatarPicturebox.TabStop = false;
            // 
            // AccountTXB
            // 
            this.AccountTXB.Font = new System.Drawing.Font("新細明體", 15F);
            this.AccountTXB.Location = new System.Drawing.Point(481, 17);
            this.AccountTXB.MaxLength = 10;
            this.AccountTXB.Name = "AccountTXB";
            this.AccountTXB.Size = new System.Drawing.Size(245, 31);
            this.AccountTXB.TabIndex = 22;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(596, 374);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(130, 60);
            this.CancelBTN.TabIndex = 21;
            this.CancelBTN.Text = "取消";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 60);
            this.button1.TabIndex = 20;
            this.button1.Text = "創建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemberopenFileDialog1
            // 
            this.MemberopenFileDialog1.FileName = "MemberopenFileDialog1";
            // 
            // FRMCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TorNOT);
            this.Controls.Add(this.ResetAvatarBTN);
            this.Controls.Add(this.SearchFileBTN);
            this.Controls.Add(this.ShowPasswordBTN);
            this.Controls.Add(this.FemaleCheckBox);
            this.Controls.Add(this.MaleCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NickNameTXB);
            this.Controls.Add(this.PhoneNumberTXB);
            this.Controls.Add(this.EmailTXB);
            this.Controls.Add(this.PassWordTXB);
            this.Controls.Add(this.AvatarPicturebox);
            this.Controls.Add(this.AccountTXB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.button1);
            this.Name = "FRMCreate";
            this.Text = "FRMCreate";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TorNOT;
        private System.Windows.Forms.Button ResetAvatarBTN;
        private System.Windows.Forms.Button SearchFileBTN;
        private System.Windows.Forms.Button ShowPasswordBTN;
        private System.Windows.Forms.CheckBox FemaleCheckBox;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NickNameTXB;
        private System.Windows.Forms.TextBox PhoneNumberTXB;
        private System.Windows.Forms.TextBox EmailTXB;
        private System.Windows.Forms.TextBox PassWordTXB;
        private System.Windows.Forms.PictureBox AvatarPicturebox;
        private System.Windows.Forms.TextBox AccountTXB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog MemberopenFileDialog1;
    }
}