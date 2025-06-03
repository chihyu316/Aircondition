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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_FrmAddnewC));
            System.Windows.Forms.Label courseIDLabel;
            System.Windows.Forms.Label courseBatchIDLabel;
            System.Windows.Forms.Label courseTitleLabel;
            System.Windows.Forms.Label courseIntroductionLabel;
            System.Windows.Forms.Label courseLevelLabel;
            System.Windows.Forms.Label standardPriceLabel;
            System.Windows.Forms.Label courseHoursLabel;
            System.Windows.Forms.Label photosLabel;
            System.Windows.Forms.Label courseStatusLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label updateDateLabel;
            this.c_RecruitDataSet = new prjAircondition.Recruit.DateSet.C_RecruitDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager();
            this.courseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.courseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.courseBatchIDTextBox = new System.Windows.Forms.TextBox();
            this.courseTitleTextBox = new System.Windows.Forms.TextBox();
            this.courseIntroductionTextBox = new System.Windows.Forms.TextBox();
            this.courseLevelTextBox = new System.Windows.Forms.TextBox();
            this.standardPriceTextBox = new System.Windows.Forms.TextBox();
            this.courseHoursTextBox = new System.Windows.Forms.TextBox();
            this.photosPictureBox = new System.Windows.Forms.PictureBox();
            this.courseStatusTextBox = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            courseIDLabel = new System.Windows.Forms.Label();
            courseBatchIDLabel = new System.Windows.Forms.Label();
            courseTitleLabel = new System.Windows.Forms.Label();
            courseIntroductionLabel = new System.Windows.Forms.Label();
            courseLevelLabel = new System.Windows.Forms.Label();
            standardPriceLabel = new System.Windows.Forms.Label();
            courseHoursLabel = new System.Windows.Forms.Label();
            photosLabel = new System.Windows.Forms.Label();
            courseStatusLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            updateDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).BeginInit();
            this.courseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // c_RecruitDataSet
            // 
            this.c_RecruitDataSet.DataSetName = "C_RecruitDataSet";
            this.c_RecruitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.c_RecruitDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassroomManagementTableAdapter = null;
            this.tableAdapterManager.CourseBatchTableAdapter = null;
            this.tableAdapterManager.CourseCategoryTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseBindingNavigator
            // 
            this.courseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.courseBindingNavigator.BindingSource = this.courseBindingSource;
            this.courseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.courseBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.courseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.courseBindingNavigatorSaveItem});
            this.courseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.courseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courseBindingNavigator.Name = "courseBindingNavigator";
            this.courseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courseBindingNavigator.Size = new System.Drawing.Size(1196, 38);
            this.courseBindingNavigator.TabIndex = 0;
            this.courseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 33);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // courseBindingNavigatorSaveItem
            // 
            this.courseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.courseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("courseBindingNavigatorSaveItem.Image")));
            this.courseBindingNavigatorSaveItem.Name = "courseBindingNavigatorSaveItem";
            this.courseBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.courseBindingNavigatorSaveItem.Text = "儲存資料";
            this.courseBindingNavigatorSaveItem.Click += new System.EventHandler(this.courseBindingNavigatorSaveItem_Click);
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseIDLabel.Location = new System.Drawing.Point(305, 45);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(132, 31);
            courseIDLabel.TabIndex = 1;
            courseIDLabel.Text = "Course ID:";
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CourseID", true));
            this.courseIDTextBox.Location = new System.Drawing.Point(528, 45);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(200, 29);
            this.courseIDTextBox.TabIndex = 2;
            // 
            // courseBatchIDLabel
            // 
            courseBatchIDLabel.AutoSize = true;
            courseBatchIDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseBatchIDLabel.Location = new System.Drawing.Point(305, 98);
            courseBatchIDLabel.Name = "courseBatchIDLabel";
            courseBatchIDLabel.Size = new System.Drawing.Size(202, 31);
            courseBatchIDLabel.TabIndex = 3;
            courseBatchIDLabel.Text = "Course Batch ID:";
            // 
            // courseBatchIDTextBox
            // 
            this.courseBatchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CourseBatchID", true));
            this.courseBatchIDTextBox.Location = new System.Drawing.Point(528, 98);
            this.courseBatchIDTextBox.Name = "courseBatchIDTextBox";
            this.courseBatchIDTextBox.Size = new System.Drawing.Size(200, 29);
            this.courseBatchIDTextBox.TabIndex = 4;
            // 
            // courseTitleLabel
            // 
            courseTitleLabel.AutoSize = true;
            courseTitleLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseTitleLabel.Location = new System.Drawing.Point(305, 145);
            courseTitleLabel.Name = "courseTitleLabel";
            courseTitleLabel.Size = new System.Drawing.Size(116, 31);
            courseTitleLabel.TabIndex = 5;
            courseTitleLabel.Text = "課程名稱:";
            // 
            // courseTitleTextBox
            // 
            this.courseTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CourseTitle", true));
            this.courseTitleTextBox.Location = new System.Drawing.Point(528, 152);
            this.courseTitleTextBox.Name = "courseTitleTextBox";
            this.courseTitleTextBox.Size = new System.Drawing.Size(200, 29);
            this.courseTitleTextBox.TabIndex = 6;
            // 
            // courseIntroductionLabel
            // 
            courseIntroductionLabel.AutoSize = true;
            courseIntroductionLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseIntroductionLabel.Location = new System.Drawing.Point(305, 207);
            courseIntroductionLabel.Name = "courseIntroductionLabel";
            courseIntroductionLabel.Size = new System.Drawing.Size(116, 31);
            courseIntroductionLabel.TabIndex = 7;
            courseIntroductionLabel.Text = "課程介紹:";
            // 
            // courseIntroductionTextBox
            // 
            this.courseIntroductionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CourseIntroduction", true));
            this.courseIntroductionTextBox.Location = new System.Drawing.Point(528, 207);
            this.courseIntroductionTextBox.Multiline = true;
            this.courseIntroductionTextBox.Name = "courseIntroductionTextBox";
            this.courseIntroductionTextBox.Size = new System.Drawing.Size(458, 152);
            this.courseIntroductionTextBox.TabIndex = 8;
            // 
            // courseLevelLabel
            // 
            courseLevelLabel.AutoSize = true;
            courseLevelLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseLevelLabel.Location = new System.Drawing.Point(305, 389);
            courseLevelLabel.Name = "courseLevelLabel";
            courseLevelLabel.Size = new System.Drawing.Size(116, 31);
            courseLevelLabel.TabIndex = 9;
            courseLevelLabel.Text = "課程級別:";
            // 
            // courseLevelTextBox
            // 
            this.courseLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CourseLevel", true));
            this.courseLevelTextBox.Location = new System.Drawing.Point(528, 389);
            this.courseLevelTextBox.Name = "courseLevelTextBox";
            this.courseLevelTextBox.Size = new System.Drawing.Size(200, 29);
            this.courseLevelTextBox.TabIndex = 10;
            // 
            // standardPriceLabel
            // 
            standardPriceLabel.AutoSize = true;
            standardPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            standardPriceLabel.Location = new System.Drawing.Point(305, 441);
            standardPriceLabel.Name = "standardPriceLabel";
            standardPriceLabel.Size = new System.Drawing.Size(116, 31);
            standardPriceLabel.TabIndex = 11;
            standardPriceLabel.Text = "標準價格:";
            // 
            // standardPriceTextBox
            // 
            this.standardPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "StandardPrice", true));
            this.standardPriceTextBox.Location = new System.Drawing.Point(528, 441);
            this.standardPriceTextBox.Name = "standardPriceTextBox";
            this.standardPriceTextBox.Size = new System.Drawing.Size(200, 29);
            this.standardPriceTextBox.TabIndex = 12;
            // 
            // courseHoursLabel
            // 
            courseHoursLabel.AutoSize = true;
            courseHoursLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseHoursLabel.Location = new System.Drawing.Point(305, 476);
            courseHoursLabel.Name = "courseHoursLabel";
            courseHoursLabel.Size = new System.Drawing.Size(116, 31);
            courseHoursLabel.TabIndex = 13;
            courseHoursLabel.Text = "課程時數:";
            // 
            // courseHoursTextBox
            // 
            this.courseHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CourseHours", true));
            this.courseHoursTextBox.Location = new System.Drawing.Point(528, 476);
            this.courseHoursTextBox.Name = "courseHoursTextBox";
            this.courseHoursTextBox.Size = new System.Drawing.Size(200, 29);
            this.courseHoursTextBox.TabIndex = 14;
            // 
            // photosLabel
            // 
            photosLabel.AutoSize = true;
            photosLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            photosLabel.Location = new System.Drawing.Point(305, 530);
            photosLabel.Name = "photosLabel";
            photosLabel.Size = new System.Drawing.Size(116, 31);
            photosLabel.TabIndex = 15;
            photosLabel.Text = "相關圖片:";
            // 
            // photosPictureBox
            // 
            this.photosPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.courseBindingSource, "Photos", true));
            this.photosPictureBox.Location = new System.Drawing.Point(528, 511);
            this.photosPictureBox.Name = "photosPictureBox";
            this.photosPictureBox.Size = new System.Drawing.Size(375, 117);
            this.photosPictureBox.TabIndex = 16;
            this.photosPictureBox.TabStop = false;
            // 
            // courseStatusLabel
            // 
            courseStatusLabel.AutoSize = true;
            courseStatusLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseStatusLabel.Location = new System.Drawing.Point(305, 634);
            courseStatusLabel.Name = "courseStatusLabel";
            courseStatusLabel.Size = new System.Drawing.Size(116, 31);
            courseStatusLabel.TabIndex = 17;
            courseStatusLabel.Text = "課程狀態:";
            // 
            // courseStatusTextBox
            // 
            this.courseStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "CourseStatus", true));
            this.courseStatusTextBox.Location = new System.Drawing.Point(528, 634);
            this.courseStatusTextBox.Name = "courseStatusTextBox";
            this.courseStatusTextBox.Size = new System.Drawing.Size(200, 29);
            this.courseStatusTextBox.TabIndex = 18;
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            createDateLabel.Location = new System.Drawing.Point(305, 680);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(156, 31);
            createDateLabel.TabIndex = 19;
            createDateLabel.Text = "Create Date:";
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.courseBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(528, 679);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.createDateDateTimePicker.TabIndex = 20;
            // 
            // updateDateLabel
            // 
            updateDateLabel.AutoSize = true;
            updateDateLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            updateDateLabel.Location = new System.Drawing.Point(305, 715);
            updateDateLabel.Name = "updateDateLabel";
            updateDateLabel.Size = new System.Drawing.Size(167, 31);
            updateDateLabel.TabIndex = 21;
            updateDateLabel.Text = "Update Date:";
            // 
            // updateDateDateTimePicker
            // 
            this.updateDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.courseBindingSource, "UpdateDate", true));
            this.updateDateDateTimePicker.Location = new System.Drawing.Point(528, 714);
            this.updateDateDateTimePicker.Name = "updateDateDateTimePicker";
            this.updateDateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.updateDateDateTimePicker.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courseBindingSource, "CourseLevel", true));
            this.comboBox1.DataSource = this.courseBindingSource;
            this.comboBox1.DisplayMember = "CourseLevel";
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(763, 389);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 38);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "CourseLevel";
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.c_RecruitDataSet;
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.c_RecruitDataSet;
            // 
            // C_FrmAddnewC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 803);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(courseBatchIDLabel);
            this.Controls.Add(this.courseBatchIDTextBox);
            this.Controls.Add(courseTitleLabel);
            this.Controls.Add(this.courseTitleTextBox);
            this.Controls.Add(courseIntroductionLabel);
            this.Controls.Add(this.courseIntroductionTextBox);
            this.Controls.Add(courseLevelLabel);
            this.Controls.Add(this.courseLevelTextBox);
            this.Controls.Add(standardPriceLabel);
            this.Controls.Add(this.standardPriceTextBox);
            this.Controls.Add(courseHoursLabel);
            this.Controls.Add(this.courseHoursTextBox);
            this.Controls.Add(photosLabel);
            this.Controls.Add(this.photosPictureBox);
            this.Controls.Add(courseStatusLabel);
            this.Controls.Add(this.courseStatusTextBox);
            this.Controls.Add(createDateLabel);
            this.Controls.Add(this.createDateDateTimePicker);
            this.Controls.Add(updateDateLabel);
            this.Controls.Add(this.updateDateDateTimePicker);
            this.Controls.Add(this.courseBindingNavigator);
            this.Name = "C_FrmAddnewC";
            this.Text = "C_FrmAddnewC";
            this.Load += new System.EventHandler(this.C_FrmAddnewC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).EndInit();
            this.courseBindingNavigator.ResumeLayout(false);
            this.courseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Recruit.DateSet.C_RecruitDataSet c_RecruitDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton courseBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.TextBox courseBatchIDTextBox;
        private System.Windows.Forms.TextBox courseTitleTextBox;
        private System.Windows.Forms.TextBox courseIntroductionTextBox;
        private System.Windows.Forms.TextBox courseLevelTextBox;
        private System.Windows.Forms.TextBox standardPriceTextBox;
        private System.Windows.Forms.TextBox courseHoursTextBox;
        private System.Windows.Forms.PictureBox photosPictureBox;
        private System.Windows.Forms.TextBox courseStatusTextBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker updateDateDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.BindingSource courseBindingSource2;
    }
}