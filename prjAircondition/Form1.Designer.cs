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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("會員資料");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("會員產品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("新增會員");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("會員", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("師傅資訊");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("訂單管理");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("師傅", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("冷氣商品");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("材料商品");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("訂單");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("涼心產品", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("施工單");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("安裝");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("保養");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("維修");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("拆機");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("工單", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("課程一覽");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("我要報名");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("我的課程");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("我的交易記錄");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("證照課程", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("文章管理");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("留言管理");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("討論版", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("登出");
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
            treeNode1.Name = "M_Node1";
            treeNode1.Text = "會員資料";
            treeNode2.Name = "M_Node2";
            treeNode2.Text = "會員產品";
            treeNode3.Name = "M_Node";
            treeNode3.Text = "新增會員";
            treeNode4.Name = "會員";
            treeNode4.Text = "會員";
            treeNode5.Name = "T_Node1";
            treeNode5.Text = "師傅資訊";
            treeNode6.Name = "T_Node2";
            treeNode6.Text = "訂單管理";
            treeNode7.Name = "Tech";
            treeNode7.Text = "師傅";
            treeNode8.Name = "Shop_Node1";
            treeNode8.Text = "冷氣商品";
            treeNode9.Name = "Shop_Node2";
            treeNode9.Text = "材料商品";
            treeNode10.Name = "Shop_Node3";
            treeNode10.Text = "訂單";
            treeNode11.Name = "Shop";
            treeNode11.Text = "涼心產品";
            treeNode12.Name = "Repair_Node1";
            treeNode12.Text = "施工單";
            treeNode13.Name = "Repair_Node2";
            treeNode13.Text = "安裝";
            treeNode14.Name = "Repair_Node3";
            treeNode14.Text = "保養";
            treeNode15.Name = "Repair_Node4";
            treeNode15.Text = "維修";
            treeNode16.Name = "Repair_Node5";
            treeNode16.Text = "拆機";
            treeNode17.Name = "Repair";
            treeNode17.Text = "工單";
            treeNode18.Name = "Recruit_Node1";
            treeNode18.Text = "課程一覽";
            treeNode19.Name = "Recruit_Node2";
            treeNode19.Text = "我要報名";
            treeNode20.Name = "Recruit_Node3";
            treeNode20.Text = "我的課程";
            treeNode21.Name = "Recruit_Node4";
            treeNode21.Text = "我的交易記錄";
            treeNode22.Name = "Recruit";
            treeNode22.Text = "證照課程";
            treeNode23.Name = "Dis_Node1";
            treeNode23.Text = "文章管理";
            treeNode24.Name = "Dis_Node2";
            treeNode24.Text = "留言管理";
            treeNode25.Name = "Discuss";
            treeNode25.Text = "討論版";
            treeNode26.Name = "LogOut";
            treeNode26.Text = "登出";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode11,
            treeNode17,
            treeNode22,
            treeNode25,
            treeNode26});
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

