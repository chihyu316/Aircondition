namespace prjAircondition
{
    partial class FormTech
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTech));
            this.cmdGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updatedAtPicker = new System.Windows.Forms.DateTimePicker();
            this.createdAtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAddTemp = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.techAccountTextBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.NickNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.t_ACDataSet11 = new prjAircondition.Tech.DataSet.T_ACDataSet1();
            this.techbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansTableAdapter1 = new prjAircondition.Tech.DataSet.T_ACDataSet1TableAdapters.TechniciansTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techbindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGender
            // 
            this.cmdGender.FormattingEnabled = true;
            this.cmdGender.Location = new System.Drawing.Point(343, 552);
            this.cmdGender.Name = "cmdGender";
            this.cmdGender.Size = new System.Drawing.Size(172, 36);
            this.cmdGender.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 37);
            this.label4.TabIndex = 45;
            this.label4.Text = "電話號碼:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updatedAtPicker
            // 
            this.updatedAtPicker.Location = new System.Drawing.Point(343, 692);
            this.updatedAtPicker.Name = "updatedAtPicker";
            this.updatedAtPicker.Size = new System.Drawing.Size(378, 36);
            this.updatedAtPicker.TabIndex = 57;
            this.updatedAtPicker.Visible = false;
            // 
            // createdAtPicker
            // 
            this.createdAtPicker.Location = new System.Drawing.Point(343, 623);
            this.createdAtPicker.Name = "createdAtPicker";
            this.createdAtPicker.Size = new System.Drawing.Size(378, 36);
            this.createdAtPicker.TabIndex = 58;
            this.createdAtPicker.Visible = false;
            // 
            // btnAddTemp
            // 
            this.btnAddTemp.ForeColor = System.Drawing.Color.Black;
            this.btnAddTemp.Location = new System.Drawing.Point(81, 783);
            this.btnAddTemp.Name = "btnAddTemp";
            this.btnAddTemp.Size = new System.Drawing.Size(290, 71);
            this.btnAddTemp.TabIndex = 56;
            this.btnAddTemp.Text = "建立暫存";
            this.btnAddTemp.UseVisualStyleBackColor = true;
            this.btnAddTemp.Click += new System.EventHandler(this.btnAddTemp_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.ForeColor = System.Drawing.Color.Black;
            this.btnSaveData.Location = new System.Drawing.Point(431, 783);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(290, 71);
            this.btnSaveData.TabIndex = 55;
            this.btnSaveData.Text = "Update back DB";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(343, 479);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(378, 36);
            this.emailTextBox.TabIndex = 48;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(343, 428);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(378, 36);
            this.AddresstextBox.TabIndex = 49;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(343, 365);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(378, 36);
            this.PasswordtextBox.TabIndex = 50;
            // 
            // techAccountTextBox
            // 
            this.techAccountTextBox.Location = new System.Drawing.Point(343, 305);
            this.techAccountTextBox.Name = "techAccountTextBox";
            this.techAccountTextBox.Size = new System.Drawing.Size(378, 36);
            this.techAccountTextBox.TabIndex = 51;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(343, 236);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(378, 36);
            this.phone_textBox.TabIndex = 52;
            // 
            // NickNameTextBox
            // 
            this.NickNameTextBox.Location = new System.Drawing.Point(343, 167);
            this.NickNameTextBox.Name = "NickNameTextBox";
            this.NickNameTextBox.Size = new System.Drawing.Size(378, 36);
            this.NickNameTextBox.TabIndex = 53;
            this.NickNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(56, 681);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 37);
            this.label8.TabIndex = 38;
            this.label8.Text = "更新時間:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(56, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 37);
            this.label7.TabIndex = 39;
            this.label7.Text = "創建時間:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(343, 98);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(378, 36);
            this.userNameTextBox.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(113, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 37);
            this.label10.TabIndex = 44;
            this.label10.Text = "性別:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(113, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 37);
            this.label9.TabIndex = 43;
            this.label9.Text = "email:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(130, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 37);
            this.label6.TabIndex = 42;
            this.label6.Text = "地址:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(130, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 41;
            this.label1.Text = "密碼:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(130, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 37);
            this.label5.TabIndex = 40;
            this.label5.Text = "帳號:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(130, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 37);
            this.label3.TabIndex = 46;
            this.label3.Text = "暱稱:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(130, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "姓名:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUploadPhoto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(757, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 715);
            this.panel1.TabIndex = 60;
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.ForeColor = System.Drawing.Color.Black;
            this.buttonUploadPhoto.Location = new System.Drawing.Point(40, 529);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(321, 71);
            this.buttonUploadPhoto.TabIndex = 20;
            this.buttonUploadPhoto.Text = "Open File ...";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(33, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 37);
            this.label11.TabIndex = 8;
            this.label11.Text = "頭貼照片";
            // 
            // t_ACDataSet11
            // 
            this.t_ACDataSet11.DataSetName = "T_ACDataSet1";
            this.t_ACDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techniciansTableAdapter1
            // 
            this.techniciansTableAdapter1.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(622, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 36);
            this.label13.TabIndex = 61;
            this.label13.Text = "(必填)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(622, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 36);
            this.label12.TabIndex = 61;
            this.label12.Text = "(必填)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(622, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 36);
            this.label14.TabIndex = 61;
            this.label14.Text = "(必填)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1459, 1073);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updatedAtPicker);
            this.Controls.Add(this.createdAtPicker);
            this.Controls.Add(this.btnAddTemp);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.techAccountTextBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.NickNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTech";
            this.Text = "FormTech";
            this.Load += new System.EventHandler(this.FormTech_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techbindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker updatedAtPicker;
        private System.Windows.Forms.DateTimePicker createdAtPicker;
        private System.Windows.Forms.Button btnAddTemp;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox techAccountTextBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox NickNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private Tech.DataSet.T_ACDataSet1 t_ACDataSet11;
        private System.Windows.Forms.BindingSource techbindingSource1;
        private Tech.DataSet.T_ACDataSet1TableAdapters.TechniciansTableAdapter techniciansTableAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}