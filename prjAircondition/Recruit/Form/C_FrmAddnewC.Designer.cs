namespace prjAircondition
{
    partial class C_FrmAddnewC
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.c_RecruitDataSet = new prjAircondition.Recruit.DateSet.C_RecruitDataSet();
            this.courseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseCategoryTableAdapter = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseCategoryTableAdapter();
            this.courseTableAdapter1 = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseTableAdapter();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBatchTableAdapter1 = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseBatchTableAdapter();
            this.courseBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.courseBatchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "課程類別";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "課程名稱";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.courseCategoryBindingSource;
            this.comboBox1.DisplayMember = "CategoryName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 26);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "課程介紹";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(185, 232);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 26);
            this.comboBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "課程級別";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "梯次名稱";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.courseBatchBindingSource;
            this.comboBox3.DisplayMember = "BatchName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(511, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 26);
            this.comboBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "開課日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "授課講師";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(511, 168);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(137, 26);
            this.comboBox4.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "標準價格";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(185, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 15;
            // 
            // c_RecruitDataSet
            // 
            this.c_RecruitDataSet.DataSetName = "C_RecruitDataSet";
            this.c_RecruitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseCategoryBindingSource
            // 
            this.courseCategoryBindingSource.DataMember = "CourseCategory";
            this.courseCategoryBindingSource.DataSource = this.c_RecruitDataSet;
            // 
            // courseCategoryTableAdapter
            // 
            this.courseCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.c_RecruitDataSet;
            // 
            // courseBatchTableAdapter1
            // 
            this.courseBatchTableAdapter1.ClearBeforeFill = true;
            // 
            // courseBatchBindingSource
            // 
            this.courseBatchBindingSource.DataMember = "CourseBatch";
            this.courseBatchBindingSource.DataSource = this.c_RecruitDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 176);
            this.button1.TabIndex = 16;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 176);
            this.button2.TabIndex = 17;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // courseBatchBindingSource1
            // 
            this.courseBatchBindingSource1.DataMember = "CourseBatch";
            this.courseBatchBindingSource1.DataSource = this.c_RecruitDataSet;
            // 
            // C_FrmAddnewC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 779);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "C_FrmAddnewC";
            this.Text = "C_FrmAddnewC";
            this.Load += new System.EventHandler(this.C_FrmAddnewC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private Recruit.DateSet.C_RecruitDataSet c_RecruitDataSet;
        private System.Windows.Forms.BindingSource courseCategoryBindingSource;
        private Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseCategoryTableAdapter courseCategoryTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource courseBatchBindingSource;
        private Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseTableAdapter courseTableAdapter1;
        private Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseBatchTableAdapter courseBatchTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource courseBatchBindingSource1;
    }
}