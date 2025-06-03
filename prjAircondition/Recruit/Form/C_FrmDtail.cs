using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Recruit
{
    public partial class C_FrmDtail : Form
    {
        public int CategoryID { get; internal set; }
        public int CourseBatchID { get; internal set; }
        public int CourseID { get; internal set; }
       
        public C_FrmDtail()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.c_RecruitDataSet);

        }

        private void C_FrmDtail_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'c_RecruitDataSet.CourseCategory' 資料表。您可以視需要進行移動或移除。
            //this.courseCategoryTableAdapter.Fill(this.c_RecruitDataSet.CourseCategory);
            this.courseCategoryTableAdapter.FillByCategoryID(this.c_RecruitDataSet.CourseCategory, CategoryID);
            // TODO: 這行程式碼會將資料載入 'c_RecruitDataSet.CourseBatch' 資料表。您可以視需要進行移動或移除。
            //this.courseBatchTableAdapter.Fill(this.c_RecruitDataSet.CourseBatch);
            this.courseBatchTableAdapter.FillByCourseBatchID(this.c_RecruitDataSet.CourseBatch, CourseBatchID);
            // TODO: 這行程式碼會將資料載入 'c_RecruitDataSet.Course' 資料表。您可以視需要進行移動或移除。
            //this.courseTableAdapter.Fill(this.c_RecruitDataSet.Course);
            this.courseTableAdapter.FillByCourseID(this.c_RecruitDataSet.Course, CourseID);
            
            // 設定各自獨立的 BindingSource（暫不建立關聯）
            this.courseBindingSource.DataSource = this.c_RecruitDataSet;
            this.courseBindingSource.DataMember = "Course";

            this.courseBatchBindingSource.DataSource = this.c_RecruitDataSet;
            this.courseBatchBindingSource.DataMember = "CourseBatch";

            this.courseCategoryBindingSource.DataSource = this.c_RecruitDataSet;
            this.courseCategoryBindingSource.DataMember = "CourseCategory";

            this.bindingNavigator1.BindingSource = this.courseBindingSource;
            //// 註冊事件：當 Course 選擇改變時，更新其他表
            //this.courseBindingSource.CurrentChanged += CourseBindingSource_CurrentChanged;

            //// 初始載入時也要執行一次
            //this.UpdateRelatedTables();
                }



        //private void CourseBindingSource_CurrentChanged(object sender, EventArgs e)
        //{
        //    UpdateRelatedTables();
        //}        
        //private void UpdateRelatedTables()
        //{
        //    if (this.courseBindingSource.Current != null)
        //    {
        //        DataRowView currentCourse = (DataRowView)this.courseBindingSource.Current;

        //        // 取得當前 Course 的 CourseBatchID
        //        var courseBatchID = currentCourse["CourseBatchID"];

        //        // 在 CourseBatch 表中找到對應的記錄
        //        var batchRows = this.c_RecruitDataSet.CourseBatch.Select($"CourseBatchID = {courseBatchID}");
        //        if (batchRows.Length > 0)
        //        {
        //            // 移動 CourseBatch BindingSource 到對應位置
        //            var batchIndex = this.c_RecruitDataSet.CourseBatch.Rows.IndexOf(batchRows[0]);
        //            this.courseBatchBindingSource.Position = batchIndex;

        //            // 取得 CourseBatch 的 CategoryID
        //            var categoryID = batchRows[0]["CategoryID"];

        //            // 在 CourseCategory 表中找到對應的記錄
        //            var categoryRows = this.c_RecruitDataSet.CourseCategory.Select($"CategoryID = {categoryID}");
        //            if (categoryRows.Length > 0)
        //            {
        //                // 移動 CourseCategory BindingSource 到對應位置
        //                var categoryIndex = this.c_RecruitDataSet.CourseCategory.Rows.IndexOf(categoryRows[0]);
        //                this.courseCategoryBindingSource.Position = categoryIndex;
        //            }
        //        }
        //    }
        //}
    }
}
