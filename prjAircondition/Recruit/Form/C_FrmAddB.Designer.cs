namespace prjAircondition
{
    partial class C_FrmAddB
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
            System.Windows.Forms.Label batchNameLabel;
            System.Windows.Forms.Label instructorIDLabel;
            System.Windows.Forms.Label classroomIDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label classTimeLabel;
            System.Windows.Forms.Label maxCapacityLabel;
            System.Windows.Forms.Label batchStatusLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label courseBatchIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_FrmAddB));
            this.c_RecruitDataSet = new prjAircondition.Recruit.DateSet.C_RecruitDataSet();
            this.courseBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBatchTableAdapter = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseBatchTableAdapter();
            this.tableAdapterManager = new prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager();
            this.courseBatchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.courseBatchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.batchNameTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.classTimeTextBox = new System.Windows.Forms.TextBox();
            this.maxCapacityTextBox = new System.Windows.Forms.TextBox();
            this.batchStatusTextBox = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.courseBatchIDTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            batchNameLabel = new System.Windows.Forms.Label();
            instructorIDLabel = new System.Windows.Forms.Label();
            classroomIDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            classTimeLabel = new System.Windows.Forms.Label();
            maxCapacityLabel = new System.Windows.Forms.Label();
            batchStatusLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            courseBatchIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingNavigator)).BeginInit();
            this.courseBatchBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // batchNameLabel
            // 
            batchNameLabel.AutoSize = true;
            batchNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            batchNameLabel.Location = new System.Drawing.Point(126, 163);
            batchNameLabel.Name = "batchNameLabel";
            batchNameLabel.Size = new System.Drawing.Size(115, 30);
            batchNameLabel.TabIndex = 5;
            batchNameLabel.Text = "梯次名稱:";
            batchNameLabel.UseWaitCursor = true;
            // 
            // instructorIDLabel
            // 
            instructorIDLabel.AutoSize = true;
            instructorIDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            instructorIDLabel.Location = new System.Drawing.Point(126, 227);
            instructorIDLabel.Name = "instructorIDLabel";
            instructorIDLabel.Size = new System.Drawing.Size(115, 30);
            instructorIDLabel.TabIndex = 7;
            instructorIDLabel.Text = "授課講師:";
            instructorIDLabel.UseWaitCursor = true;
            // 
            // classroomIDLabel
            // 
            classroomIDLabel.AutoSize = true;
            classroomIDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            classroomIDLabel.Location = new System.Drawing.Point(126, 283);
            classroomIDLabel.Name = "classroomIDLabel";
            classroomIDLabel.Size = new System.Drawing.Size(67, 30);
            classroomIDLabel.TabIndex = 9;
            classroomIDLabel.Text = "教室:";
            classroomIDLabel.UseWaitCursor = true;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            startDateLabel.Location = new System.Drawing.Point(126, 339);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(115, 30);
            startDateLabel.TabIndex = 11;
            startDateLabel.Text = "開課日期:";
            startDateLabel.UseWaitCursor = true;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            endDateLabel.Location = new System.Drawing.Point(126, 395);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(115, 30);
            endDateLabel.TabIndex = 13;
            endDateLabel.Text = "結束日期:";
            endDateLabel.UseWaitCursor = true;
            // 
            // classTimeLabel
            // 
            classTimeLabel.AutoSize = true;
            classTimeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            classTimeLabel.Location = new System.Drawing.Point(126, 446);
            classTimeLabel.Name = "classTimeLabel";
            classTimeLabel.Size = new System.Drawing.Size(115, 30);
            classTimeLabel.TabIndex = 15;
            classTimeLabel.Text = "上課時間:";
            classTimeLabel.UseWaitCursor = true;
            // 
            // maxCapacityLabel
            // 
            maxCapacityLabel.AutoSize = true;
            maxCapacityLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            maxCapacityLabel.Location = new System.Drawing.Point(126, 495);
            maxCapacityLabel.Name = "maxCapacityLabel";
            maxCapacityLabel.Size = new System.Drawing.Size(115, 30);
            maxCapacityLabel.TabIndex = 17;
            maxCapacityLabel.Text = "最大人數:";
            maxCapacityLabel.UseWaitCursor = true;
            // 
            // batchStatusLabel
            // 
            batchStatusLabel.AutoSize = true;
            batchStatusLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            batchStatusLabel.Location = new System.Drawing.Point(126, 560);
            batchStatusLabel.Name = "batchStatusLabel";
            batchStatusLabel.Size = new System.Drawing.Size(115, 30);
            batchStatusLabel.TabIndex = 29;
            batchStatusLabel.Text = "梯次狀態:";
            batchStatusLabel.UseWaitCursor = true;
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            createDateLabel.Location = new System.Drawing.Point(126, 626);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(115, 30);
            createDateLabel.TabIndex = 31;
            createDateLabel.Text = "建立日期:";
            createDateLabel.UseWaitCursor = true;
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            categoryIDLabel.Location = new System.Drawing.Point(126, 106);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(115, 30);
            categoryIDLabel.TabIndex = 3;
            categoryIDLabel.Text = "課程類別:";
            categoryIDLabel.UseWaitCursor = true;
            // 
            // courseBatchIDLabel
            // 
            courseBatchIDLabel.AutoSize = true;
            courseBatchIDLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            courseBatchIDLabel.Location = new System.Drawing.Point(126, 61);
            courseBatchIDLabel.Name = "courseBatchIDLabel";
            courseBatchIDLabel.Size = new System.Drawing.Size(200, 30);
            courseBatchIDLabel.TabIndex = 1;
            courseBatchIDLabel.Text = "Course Batch ID:";
            courseBatchIDLabel.UseWaitCursor = true;
            // 
            // c_RecruitDataSet
            // 
            this.c_RecruitDataSet.DataSetName = "C_RecruitDataSet";
            this.c_RecruitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBatchBindingSource
            // 
            this.courseBatchBindingSource.DataMember = "CourseBatch";
            this.courseBatchBindingSource.DataSource = this.c_RecruitDataSet;
            // 
            // courseBatchTableAdapter
            // 
            this.courseBatchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassroomManagementTableAdapter = null;
            this.tableAdapterManager.CourseBatchTableAdapter = this.courseBatchTableAdapter;
            this.tableAdapterManager.CourseCategoryTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjAircondition.Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseBatchBindingNavigator
            // 
            this.courseBatchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.courseBatchBindingNavigator.BindingSource = this.courseBatchBindingSource;
            this.courseBatchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courseBatchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.courseBatchBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.courseBatchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.courseBatchBindingNavigatorSaveItem});
            this.courseBatchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.courseBatchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courseBatchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courseBatchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courseBatchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courseBatchBindingNavigator.Name = "courseBatchBindingNavigator";
            this.courseBatchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courseBatchBindingNavigator.Size = new System.Drawing.Size(1389, 38);
            this.courseBatchBindingNavigator.TabIndex = 0;
            this.courseBatchBindingNavigator.Text = "bindingNavigator1";
            this.courseBatchBindingNavigator.UseWaitCursor = true;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 33);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // courseBatchBindingNavigatorSaveItem
            // 
            this.courseBatchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.courseBatchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("courseBatchBindingNavigatorSaveItem.Image")));
            this.courseBatchBindingNavigatorSaveItem.Name = "courseBatchBindingNavigatorSaveItem";
            this.courseBatchBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.courseBatchBindingNavigatorSaveItem.Text = "儲存資料";
            this.courseBatchBindingNavigatorSaveItem.Click += new System.EventHandler(this.courseBatchBindingNavigatorSaveItem_Click);
            // 
            // batchNameTextBox
            // 
            this.batchNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBatchBindingSource, "BatchName", true));
            this.batchNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.batchNameTextBox.Location = new System.Drawing.Point(400, 160);
            this.batchNameTextBox.Name = "batchNameTextBox";
            this.batchNameTextBox.Size = new System.Drawing.Size(247, 39);
            this.batchNameTextBox.TabIndex = 6;
            this.batchNameTextBox.UseWaitCursor = true;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.courseBatchBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(400, 335);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(247, 39);
            this.startDateDateTimePicker.TabIndex = 12;
            this.startDateDateTimePicker.UseWaitCursor = true;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.courseBatchBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(400, 391);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(247, 39);
            this.endDateDateTimePicker.TabIndex = 14;
            this.endDateDateTimePicker.UseWaitCursor = true;
            // 
            // classTimeTextBox
            // 
            this.classTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBatchBindingSource, "ClassTime", true));
            this.classTimeTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.classTimeTextBox.Location = new System.Drawing.Point(400, 443);
            this.classTimeTextBox.Name = "classTimeTextBox";
            this.classTimeTextBox.Size = new System.Drawing.Size(247, 39);
            this.classTimeTextBox.TabIndex = 16;
            this.classTimeTextBox.UseWaitCursor = true;
            // 
            // maxCapacityTextBox
            // 
            this.maxCapacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBatchBindingSource, "MaxCapacity", true));
            this.maxCapacityTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maxCapacityTextBox.Location = new System.Drawing.Point(400, 492);
            this.maxCapacityTextBox.Name = "maxCapacityTextBox";
            this.maxCapacityTextBox.Size = new System.Drawing.Size(247, 39);
            this.maxCapacityTextBox.TabIndex = 18;
            this.maxCapacityTextBox.UseWaitCursor = true;
            // 
            // batchStatusTextBox
            // 
            this.batchStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBatchBindingSource, "BatchStatus", true));
            this.batchStatusTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.batchStatusTextBox.Location = new System.Drawing.Point(400, 557);
            this.batchStatusTextBox.Name = "batchStatusTextBox";
            this.batchStatusTextBox.Size = new System.Drawing.Size(247, 39);
            this.batchStatusTextBox.TabIndex = 30;
            this.batchStatusTextBox.UseWaitCursor = true;
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.courseBatchBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(400, 622);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(247, 39);
            this.createDateDateTimePicker.TabIndex = 32;
            this.createDateDateTimePicker.UseWaitCursor = true;
            // 
            // courseBatchIDTextBox
            // 
            this.courseBatchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBatchBindingSource, "CourseBatchID", true));
            this.courseBatchIDTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.courseBatchIDTextBox.Location = new System.Drawing.Point(400, 58);
            this.courseBatchIDTextBox.Name = "courseBatchIDTextBox";
            this.courseBatchIDTextBox.Size = new System.Drawing.Size(247, 39);
            this.courseBatchIDTextBox.TabIndex = 2;
            this.courseBatchIDTextBox.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(400, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 38);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.UseWaitCursor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(400, 224);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(247, 38);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.UseWaitCursor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(400, 275);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(247, 38);
            this.comboBox3.TabIndex = 35;
            // 
            // C_FrmAddB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 879);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(courseBatchIDLabel);
            this.Controls.Add(this.courseBatchIDTextBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(batchNameLabel);
            this.Controls.Add(this.batchNameTextBox);
            this.Controls.Add(instructorIDLabel);
            this.Controls.Add(classroomIDLabel);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(classTimeLabel);
            this.Controls.Add(this.classTimeTextBox);
            this.Controls.Add(maxCapacityLabel);
            this.Controls.Add(this.maxCapacityTextBox);
            this.Controls.Add(batchStatusLabel);
            this.Controls.Add(this.batchStatusTextBox);
            this.Controls.Add(createDateLabel);
            this.Controls.Add(this.createDateDateTimePicker);
            this.Controls.Add(this.courseBatchBindingNavigator);
            this.Name = "C_FrmAddB";
            this.Text = "C_FrmAddB";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.C_FrmAddB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_RecruitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBatchBindingNavigator)).EndInit();
            this.courseBatchBindingNavigator.ResumeLayout(false);
            this.courseBatchBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Recruit.DateSet.C_RecruitDataSet c_RecruitDataSet;
        private System.Windows.Forms.BindingSource courseBatchBindingSource;
        private Recruit.DateSet.C_RecruitDataSetTableAdapters.CourseBatchTableAdapter courseBatchTableAdapter;
        private Recruit.DateSet.C_RecruitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courseBatchBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton courseBatchBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox batchNameTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox classTimeTextBox;
        private System.Windows.Forms.TextBox maxCapacityTextBox;
        private System.Windows.Forms.TextBox batchStatusTextBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.TextBox courseBatchIDTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}