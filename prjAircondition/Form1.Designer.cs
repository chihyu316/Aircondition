namespace prjAircondition
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("會員資料");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("會員產品");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("會員地址");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("會員", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("師傅資訊");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("訂單管理");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("師傅", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("冷的一比");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("冷料鋪");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("涼心產品", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("施工單");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("安裝");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("保養");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("維修");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("拆機");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("工單", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("課程一覽");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("我要報名");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("我的課程");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("我的交易記錄");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("證照課程", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("文章管理");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("留言管理");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("討論版", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("登出");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SeaShell;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox5);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 635);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightCyan;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView1.Location = new System.Drawing.Point(0, 154);
            this.treeView1.Name = "treeView1";
            treeNode28.Name = "M_Node1";
            treeNode28.Text = "會員資料";
            treeNode29.Name = "M_Node2";
            treeNode29.Text = "會員產品";
            treeNode30.Name = "M_Node";
            treeNode30.Text = "會員地址";
            treeNode31.Name = "會員";
            treeNode31.Text = "會員";
            treeNode32.Name = "T_Node1";
            treeNode32.Text = "師傅資訊";
            treeNode33.Name = "T_Node2";
            treeNode33.Text = "訂單管理";
            treeNode34.Name = "Tech";
            treeNode34.Text = "師傅";
            treeNode35.Name = "Shop_Node1";
            treeNode35.Text = "冷的一比";
            treeNode36.Name = "Shop_Node2";
            treeNode36.Text = "冷料鋪";
            treeNode37.Name = "Shop_Node3";
            treeNode37.Text = "Node7";
            treeNode38.Name = "Shop_Node4";
            treeNode38.Text = "Node8";
            treeNode39.Name = "Shop";
            treeNode39.Text = "涼心產品";
            treeNode40.Name = "Repair_Node1";
            treeNode40.Text = "施工單";
            treeNode41.Name = "Repair_Node2";
            treeNode41.Text = "安裝";
            treeNode42.Name = "Repair_Node3";
            treeNode42.Text = "保養";
            treeNode43.Name = "Repair_Node4";
            treeNode43.Text = "維修";
            treeNode44.Name = "Repair_Node5";
            treeNode44.Text = "拆機";
            treeNode45.Name = "Repair";
            treeNode45.Text = "工單";
            treeNode46.Name = "Recruit_Node1";
            treeNode46.Text = "課程一覽";
            treeNode47.Name = "Recruit_Node2";
            treeNode47.Text = "我要報名";
            treeNode48.Name = "Recruit_Node3";
            treeNode48.Text = "我的課程";
            treeNode49.Name = "Recruit_Node4";
            treeNode49.Text = "我的交易記錄";
            treeNode50.Name = "Recruit";
            treeNode50.Text = "證照課程";
            treeNode51.Name = "Dis_Node1";
            treeNode51.Text = "文章管理";
            treeNode52.Name = "Dis_Node2";
            treeNode52.Text = "留言管理";
            treeNode53.Name = "Discuss";
            treeNode53.Text = "討論版";
            treeNode54.Name = "LogOut";
            treeNode54.Text = "登出";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode34,
            treeNode39,
            treeNode45,
            treeNode50,
            treeNode53,
            treeNode54});
            this.treeView1.Size = new System.Drawing.Size(258, 481);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(724, 385);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(291, 247);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1280, 635);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

