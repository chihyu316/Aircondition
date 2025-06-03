namespace prjAircondition.Tech
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
            this.label4 = new System.Windows.Forms.Label();
            this.updatedAtPicker = new System.Windows.Forms.DateTimePicker();
            this.createdAtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.techAccountTextBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.NickNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.InsertToDataSetbutton = new System.Windows.Forms.Button();
            this.t_ACDataSet1 = new prjAircondition.Tech.DataSet.T_ACDataSet();
            this.techniciansTableAdapter1 = new prjAircondition.Tech.DataSet.T_ACDataSetTableAdapters.TechniciansTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "電話號碼:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updatedAtPicker
            // 
            this.updatedAtPicker.Location = new System.Drawing.Point(314, 690);
            this.updatedAtPicker.Name = "updatedAtPicker";
            this.updatedAtPicker.Size = new System.Drawing.Size(378, 36);
            this.updatedAtPicker.TabIndex = 35;
            this.updatedAtPicker.Visible = false;
            // 
            // createdAtPicker
            // 
            this.createdAtPicker.Location = new System.Drawing.Point(314, 621);
            this.createdAtPicker.Name = "createdAtPicker";
            this.createdAtPicker.Size = new System.Drawing.Size(378, 36);
            this.createdAtPicker.TabIndex = 36;
            this.createdAtPicker.Visible = false;
            // 
            // btnSaveData
            // 
            this.btnSaveData.ForeColor = System.Drawing.Color.Black;
            this.btnSaveData.Location = new System.Drawing.Point(402, 790);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(290, 71);
            this.btnSaveData.TabIndex = 34;
            this.btnSaveData.Text = "Update back DB";
            this.btnSaveData.UseVisualStyleBackColor = true;
            // 
            // techAccountTextBox
            // 
            this.techAccountTextBox.Location = new System.Drawing.Point(314, 303);
            this.techAccountTextBox.Name = "techAccountTextBox";
            this.techAccountTextBox.Size = new System.Drawing.Size(378, 36);
            this.techAccountTextBox.TabIndex = 30;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(314, 234);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(378, 36);
            this.phone_textBox.TabIndex = 31;
            // 
            // NickNameTextBox
            // 
            this.NickNameTextBox.Location = new System.Drawing.Point(314, 165);
            this.NickNameTextBox.Name = "NickNameTextBox";
            this.NickNameTextBox.Size = new System.Drawing.Size(378, 36);
            this.NickNameTextBox.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(27, 688);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 37);
            this.label8.TabIndex = 24;
            this.label8.Text = "更新時間:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 37);
            this.label7.TabIndex = 25;
            this.label7.Text = "創建時間:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(314, 96);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(378, 36);
            this.userNameTextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(101, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "帳號:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(101, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "暱稱:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(101, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "姓名:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "密碼:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(314, 363);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(378, 36);
            this.PasswordtextBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(101, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 37);
            this.label6.TabIndex = 26;
            this.label6.Text = "地址:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(314, 426);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(378, 36);
            this.AddresstextBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(84, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 37);
            this.label9.TabIndex = 26;
            this.label9.Text = "email:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(314, 477);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(378, 36);
            this.emailTextBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(84, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 37);
            this.label10.TabIndex = 26;
            this.label10.Text = "性別:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(314, 550);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 36);
            this.comboBox1.TabIndex = 37;
            // 
            // InsertToDataSetbutton
            // 
            this.InsertToDataSetbutton.ForeColor = System.Drawing.Color.Black;
            this.InsertToDataSetbutton.Location = new System.Drawing.Point(52, 790);
            this.InsertToDataSetbutton.Name = "InsertToDataSetbutton";
            this.InsertToDataSetbutton.Size = new System.Drawing.Size(290, 71);
            this.InsertToDataSetbutton.TabIndex = 34;
            this.InsertToDataSetbutton.Text = "建立暫存";
            this.InsertToDataSetbutton.UseVisualStyleBackColor = true;
            // 
            // t_ACDataSet1
            // 
            this.t_ACDataSet1.DataSetName = "T_ACDataSet";
            this.t_ACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techniciansTableAdapter1
            // 
            this.techniciansTableAdapter1.ClearBeforeFill = true;
            // 
            // FormTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1687, 1402);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updatedAtPicker);
            this.Controls.Add(this.createdAtPicker);
            this.Controls.Add(this.InsertToDataSetbutton);
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
            ((System.ComponentModel.ISupportInitialize)(this.t_ACDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker updatedAtPicker;
        private System.Windows.Forms.DateTimePicker createdAtPicker;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.TextBox techAccountTextBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox NickNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button InsertToDataSetbutton;
        private DataSet.T_ACDataSet t_ACDataSet1;
        private DataSet.T_ACDataSetTableAdapters.TechniciansTableAdapter techniciansTableAdapter1;
    }
}