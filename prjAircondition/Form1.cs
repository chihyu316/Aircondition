using prjAircondition.Dicuss;
using prjAircondition.Member;
using prjAircondition.Recruit;
using prjAircondition.Repair;
using prjAircondition.Shop;
using prjAircondition.Tech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition
{
    public partial class Form1 : Form
    {
        string loginAccount;

        private void ShowPage(UserControl user)
        {
            splitContainer1.Panel2.Controls.Clear();
            user.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(user);
        }
        public Form1(string UserID)
        {
            InitializeComponent();
            loginAccount = UserID;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "會員資料":
                    M_meberinfo meberinfo= new M_meberinfo();
                    ShowPage(meberinfo);
                    break;
                case "會員產品":
                    M_memberProduct product= new M_memberProduct();
                    ShowPage(product);
                    break;
                case "會員地址":
                    M_MemberAddress address= new M_MemberAddress();
                    ShowPage(address);
                    break;
                case "師傅資訊":
                    T_TechUserControl1 tech= new T_TechUserControl1();
                    ShowPage(tech);
                    break;
                case "訂單管理":
                    T_OrderUserControl1 order= new T_OrderUserControl1();
                    ShowPage(order);
                    break;
                case "冷的一比":
                    S_UcProduct1 ucproduct= new S_UcProduct1();
                    ShowPage(ucproduct);
                    break;
                case "冷料鋪":
                    S_UcMateral ucMateral= new S_UcMateral();
                    ShowPage(ucMateral);
                    break;
                case "施工單":
                    R_ucWorkOrder UcWorkOrder= new R_ucWorkOrder();
                    ShowPage(UcWorkOrder);
                    break;
                case "安裝":
                    R_ucInstallationChecklist install = new R_ucInstallationChecklist();
                    ShowPage(install);
                    break;
                case "保養":
                    R_ucMaintenanceChecklist maintain = new R_ucMaintenanceChecklist();
                    ShowPage(maintain);
                    break;
                case "維修":
                    R_ucRepairChecklist repair= new R_ucRepairChecklist();
                    ShowPage(repair);
                    break;
                case "拆機":
                    R_ucUninstallChecklist uninstall= new R_ucUninstallChecklist();
                    ShowPage(uninstall);
                    break;
                case "課程一覽":
                    C_CourseControl course = new C_CourseControl();
                    ShowPage(course);
                    break;
                case "我要報名":
                    C_RegisterControl register = new C_RegisterControl();
                    ShowPage(register);
                    break;
                case "我的課程":
                    C_MYCCntrol Mycourse = new C_MYCCntrol();
                    ShowPage(Mycourse);
                    break;
                case "我的交易記錄":
                    C_TradeHistory Trade = new C_TradeHistory();
                    ShowPage(Trade);
                    break;
                case "文章管理":
                    D_DisControl dis = new D_DisControl();
                    ShowPage(dis);
                    break;
                case "留言管理":
                    D_ReplyControl reply = new D_ReplyControl();
                    ShowPage(reply);
                    break;
                case "登出":
                    this.Hide();
                    FRMloLogin login = new FRMloLogin();
                    login.Show();
                    break;
            }
        }

  
    }
}
