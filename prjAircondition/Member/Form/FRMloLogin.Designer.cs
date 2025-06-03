namespace prjAircondition.Member
{
    partial class FRMloLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMloLogin));
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.Logibtxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Accountlbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.ShowPasswordBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.Loginbtn.Location = new System.Drawing.Point(181, 322);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(104, 42);
            this.Loginbtn.TabIndex = 0;
            this.Loginbtn.Text = "登入";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.Cancelbtn.Location = new System.Drawing.Point(349, 322);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(94, 42);
            this.Cancelbtn.TabIndex = 1;
            this.Cancelbtn.Text = "取消";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Createbtn
            // 
            this.Createbtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.Createbtn.Location = new System.Drawing.Point(511, 322);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(84, 42);
            this.Createbtn.TabIndex = 2;
            this.Createbtn.Text = "註冊";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Logibtxt
            // 
            this.Logibtxt.Font = new System.Drawing.Font("新細明體", 20F);
            this.Logibtxt.Location = new System.Drawing.Point(259, 124);
            this.Logibtxt.Name = "Logibtxt";
            this.Logibtxt.Size = new System.Drawing.Size(313, 39);
            this.Logibtxt.TabIndex = 3;
            this.Logibtxt.Text = "Adminator";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("新細明體", 20F);
            this.Passwordtxt.Location = new System.Drawing.Point(259, 216);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '●';
            this.Passwordtxt.Size = new System.Drawing.Size(313, 39);
            this.Passwordtxt.TabIndex = 4;
            // 
            // Accountlbl
            // 
            this.Accountlbl.AutoSize = true;
            this.Accountlbl.Font = new System.Drawing.Font("新細明體", 20F);
            this.Accountlbl.Location = new System.Drawing.Point(179, 124);
            this.Accountlbl.Name = "Accountlbl";
            this.Accountlbl.Size = new System.Drawing.Size(73, 27);
            this.Accountlbl.TabIndex = 5;
            this.Accountlbl.Text = "帳號:";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("新細明體", 20F);
            this.Passwordlbl.Location = new System.Drawing.Point(176, 219);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(73, 27);
            this.Passwordlbl.TabIndex = 6;
            this.Passwordlbl.Text = "密碼:";
            // 
            // ShowPasswordBTN
            // 
            this.ShowPasswordBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordBTN.BackgroundImage")));
            this.ShowPasswordBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordBTN.Location = new System.Drawing.Point(571, 216);
            this.ShowPasswordBTN.Name = "ShowPasswordBTN";
            this.ShowPasswordBTN.Size = new System.Drawing.Size(34, 39);
            this.ShowPasswordBTN.TabIndex = 18;
            this.ShowPasswordBTN.Text = "\r\n";
            this.ShowPasswordBTN.UseVisualStyleBackColor = true;
            this.ShowPasswordBTN.Click += new System.EventHandler(this.ShowPasswordBTN_Click);
            // 
            // FRMloLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowPasswordBTN);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Accountlbl);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Logibtxt);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Loginbtn);
            this.Name = "FRMloLogin";
            this.Text = "FRMloLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.TextBox Logibtxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Accountlbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Button ShowPasswordBTN;
    }
}