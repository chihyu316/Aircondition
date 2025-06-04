namespace prjAircondition.Member
{
    partial class M_memberProduct
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
            this.SearchMember = new System.Windows.Forms.TextBox();
            this.MemberListV = new System.Windows.Forms.ListView();
            this.memberTableAdapter1 = new prjAircondition.Member.DataSet.M_MemberDatasetTableAdapters.MemberTableAdapter();
            this.m_MemberDataset1 = new prjAircondition.Member.DataSet.M_MemberDataset();
            this.memberTableAdapter2 = new prjAircondition.Dicuss.DataSet.D_ACDataSetTableAdapters.MemberTableAdapter();
            this.MemberProductDT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.m_MemberDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberProductDT)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchMember
            // 
            this.SearchMember.Font = new System.Drawing.Font("新細明體", 15F);
            this.SearchMember.Location = new System.Drawing.Point(65, 120);
            this.SearchMember.Name = "SearchMember";
            this.SearchMember.Size = new System.Drawing.Size(131, 31);
            this.SearchMember.TabIndex = 46;
            this.SearchMember.TextChanged += new System.EventHandler(this.SearchMember_TextChanged);
            // 
            // MemberListV
            // 
            this.MemberListV.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberListV.HideSelection = false;
            this.MemberListV.Location = new System.Drawing.Point(65, 185);
            this.MemberListV.Name = "MemberListV";
            this.MemberListV.Size = new System.Drawing.Size(131, 357);
            this.MemberListV.TabIndex = 45;
            this.MemberListV.UseCompatibleStateImageBehavior = false;
            this.MemberListV.View = System.Windows.Forms.View.Details;
            this.MemberListV.SelectedIndexChanged += new System.EventHandler(this.MemberListV_SelectedIndexChanged);
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // m_MemberDataset1
            // 
            this.m_MemberDataset1.DataSetName = "M_MemberDataset";
            this.m_MemberDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter2
            // 
            this.memberTableAdapter2.ClearBeforeFill = true;
            // 
            // MemberProductDT
            // 
            this.MemberProductDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberProductDT.Location = new System.Drawing.Point(231, 185);
            this.MemberProductDT.Name = "MemberProductDT";
            this.MemberProductDT.RowTemplate.Height = 24;
            this.MemberProductDT.Size = new System.Drawing.Size(671, 218);
            this.MemberProductDT.TabIndex = 47;
            // 
            // M_memberProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.MemberProductDT);
            this.Controls.Add(this.SearchMember);
            this.Controls.Add(this.MemberListV);
            this.Name = "M_memberProduct";
            this.Size = new System.Drawing.Size(963, 682);
            this.Load += new System.EventHandler(this.M_memberProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_MemberDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberProductDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchMember;
        private System.Windows.Forms.ListView MemberListV;
        private DataSet.M_MemberDatasetTableAdapters.MemberTableAdapter memberTableAdapter1;
        private DataSet.M_MemberDataset m_MemberDataset1;
        private Dicuss.DataSet.D_ACDataSetTableAdapters.MemberTableAdapter memberTableAdapter2;
        private System.Windows.Forms.DataGridView MemberProductDT;
    }
}
