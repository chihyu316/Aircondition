namespace prjAircondition.Recruit
{
    partial class C_RegisterControl
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
            this.c_RecruitDataSet1 = new prjAircondition.Recruit.DateSet.C_RecruitDataSet();
            this.registrationTableAdapter1 = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.RegistrationTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmSelectCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmBC = new System.Windows.Forms.ComboBox();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c_RecruitDataSet1
            // 
            this.c_RecruitDataSet1.DataSetName = "C_RecruitDataSet";
            this.c_RecruitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationTableAdapter1
            // 
            this.registrationTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(642, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 61);
            this.button2.TabIndex = 17;
            this.button2.Text = "查看報名紀錄";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.C_checkR_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(22, 311);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(507, 148);
            this.listBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(180, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "確認報名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.C_confirmR_Click);
            // 
            // txtMAccount
            // 
            this.txtMAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMAccount.Location = new System.Drawing.Point(180, 65);
            this.txtMAccount.Name = "txtMAccount";
            this.txtMAccount.Size = new System.Drawing.Size(417, 39);
            this.txtMAccount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "選擇梯次課程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "會員帳號";
            // 
            // cmSelectCourse
            // 
            this.cmSelectCourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmSelectCourse.FormattingEnabled = true;
            this.cmSelectCourse.Location = new System.Drawing.Point(180, 139);
            this.cmSelectCourse.Name = "cmSelectCourse";
            this.cmSelectCourse.Size = new System.Drawing.Size(417, 38);
            this.cmSelectCourse.TabIndex = 11;
            this.cmSelectCourse.SelectedIndexChanged += new System.EventHandler(this.cmSelectCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "課程報名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(642, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(811, 572);
            this.dataGridView1.TabIndex = 18;
            // 
            // cmBC
            // 
            this.cmBC.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmBC.FormattingEnabled = true;
            this.cmBC.Location = new System.Drawing.Point(1047, 65);
            this.cmBC.Name = "cmBC";
            this.cmBC.Size = new System.Drawing.Size(324, 32);
            this.cmBC.TabIndex = 21;
            this.cmBC.SelectedIndexChanged += new System.EventHandler(this.cmBC_SelectedIndexChanged);
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.c_RecruitDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassroomManagementTableAdapter = null;
            this.tableAdapterManager.CourseBatchTableAdapter = null;
            this.tableAdapterManager.CourseCategoryTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.InstructorTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = this.registrationTableAdapter1;
            this.tableAdapterManager.UpdateOrder = prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "報名費用";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(180, 200);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 39);
            this.txtPrice.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(1050, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "個別梯次報名狀況";
            // 
            // C_RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmBC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmSelectCourse);
            this.Controls.Add(this.label1);
            this.Name = "C_RegisterControl";
            this.Size = new System.Drawing.Size(1526, 887);
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateSet.C_RecruitDataSet c_RecruitDataSet1;
        private DateSet.C_RecruitDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmSelectCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmBC;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
    }
}
