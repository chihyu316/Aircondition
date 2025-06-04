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
            try
            {
                // 先載入課程資料
                this.courseTableAdapter.FillByCourseID(this.c_RecruitDataSet.Course, CourseID);

                // 從課程資料中取得正確的 CourseBatchID
                if (this.c_RecruitDataSet.Course.Rows.Count > 0)
                {
                    DataRow courseRow = this.c_RecruitDataSet.Course.Rows[0];
                    int actualCourseBatchID = Convert.ToInt32(courseRow["CourseBatchID"]);

                    // 用正確的 CourseBatchID 載入梯次資料
                    this.courseBatchTableAdapter.FillByCourseBatchID(this.c_RecruitDataSet.CourseBatch, actualCourseBatchID);

                    // 從梯次資料中取得 CategoryID
                    if (this.c_RecruitDataSet.CourseBatch.Rows.Count > 0)
                    {
                        DataRow batchRow = this.c_RecruitDataSet.CourseBatch.Rows[0];
                        int actualCategoryID = Convert.ToInt32(batchRow["CategoryID"]);

                        // 載入類別資料
                        this.courseCategoryTableAdapter.FillByCategoryID(this.c_RecruitDataSet.CourseCategory, actualCategoryID);
                    }
                }

                // 設定綁定
                this.courseBindingSource.DataSource = this.c_RecruitDataSet;
                this.courseBindingSource.DataMember = "Course";
                this.courseBatchBindingSource.DataSource = this.c_RecruitDataSet;
                this.courseBatchBindingSource.DataMember = "CourseBatch";
                this.courseCategoryBindingSource.DataSource = this.c_RecruitDataSet;
                this.courseCategoryBindingSource.DataMember = "CourseCategory";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入資料失敗：{ex.Message}");
            }
        }


    }
}
