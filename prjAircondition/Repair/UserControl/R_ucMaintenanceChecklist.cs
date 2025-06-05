using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition.Repair
{
    public partial class R_ucMaintenanceChecklist : UserControl
    {
        public R_ucMaintenanceChecklist()
        {
            InitializeComponent();
        }
        
        private void R_ucMaintenanceChecklist_Load_1(object sender, EventArgs e)
        {
            LoadLookupTables();          // 載入下拉資料 
            //InitDataTable();             // 建立 dtWorkOrders，並設為 DataSource 
            //InitGridColumns();           // 建立下拉欄位，並中文化 
        }
        private string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True;";
        private DataTable dtWorkOrders;
        private SqlDataAdapter adapter;

        // 對照資料表
        private DataTable dtCity;
        private DataTable dtAreas;
        private DataTable dtWorkTypes;
        private DataTable dtTechnicians;

        private void R_ucMaintenanceChecklist_Load(object sender, EventArgs e)
        {
            LoadLookupTables();      // 對照表（城市、地區、師傅、工作類型）
            InitGridColumns();       // 設定 DataGridView 欄位
                                     // LoadWorkOrders();     // 下一步才會實作
        }
        private void LoadLookupTables()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT CityID, City FROM CityList", conn))
                {
                    dtCity = new DataTable();
                    da.Fill(dtCity);
                }

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT AreaID, AREA FROM AreaList", conn))
                {
                    dtAreas = new DataTable();
                    da.Fill(dtAreas);
                }

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT WorkTypeID, WorkType FROM WorkType", conn))
                {
                    dtWorkTypes = new DataTable();
                    da.Fill(dtWorkTypes);
                }

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT T_id, Nickname FROM Technicians", conn))
                {
                    dtTechnicians = new DataTable();
                    da.Fill(dtTechnicians);
                }
            }
        }
        private DataTable LoadMembers()
        {
            DataTable dtMembers = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT MemberID, MemberAccount FROM Member";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dtMembers);
                }
            }
            return dtMembers;
        }
        private void InitDataTable()
        {
            dtWorkOrders = new DataTable();
            dtWorkOrders.Columns.Add("WorkOrderID", typeof(int));
            dtWorkOrders.Columns.Add("WorkTypeID", typeof(int));
            dtWorkOrders.Columns.Add("TechnicianID", typeof(int));
            dtWorkOrders.Columns.Add("CityID", typeof(int));
            dtWorkOrders.Columns.Add("AreaID", typeof(int));
            dtWorkOrders.Columns.Add("MemberID", typeof(int));
            dtWorkOrders.Columns.Add("ModelName", typeof(string));
            dtWorkOrders.Columns.Add("CreatedDate", typeof(DateTime));
            dtWorkOrders.Columns.Add("AddressDetail", typeof(string));

            dgvWorkOrder.DataSource = dtWorkOrders;
        }
        private void InitGridColumns()
        {
            dgvWorkOrder.Columns.Clear();
            dgvWorkOrder.AllowUserToAddRows = false;

            // 工單編號（唯讀）
            dgvWorkOrder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "WorkOrderID",
                HeaderText = "工單編號",
                
            });

            // 工作類型
            var workTypeCol = new DataGridViewComboBoxColumn()
            {
                DataPropertyName = "WorkTypeID",
                HeaderText = "工作類型",
                DataSource = dtWorkTypes,
                ValueMember = "WorkTypeID",
                DisplayMember = "WorkType"
            };
            dgvWorkOrder.Columns.Add(workTypeCol);

            // 派工師傅
            var techCol = new DataGridViewComboBoxColumn()
            {
                DataPropertyName = "TechnicianID",
                HeaderText = "派工師傅",
                DataSource = dtTechnicians,
                ValueMember = "T_id",
                DisplayMember = "Nickname"
            };
            dgvWorkOrder.Columns.Add(techCol);

            // 城市
            var cityCol = new DataGridViewComboBoxColumn()
            {
                DataPropertyName = "CityID",
                HeaderText = "城市",
                DataSource = dtCity,
                ValueMember = "CityID",
                DisplayMember = "City"
            };
            dgvWorkOrder.Columns.Add(cityCol);

            // 地區
            var areaCol = new DataGridViewComboBoxColumn()
            {
                DataPropertyName = "AreaID",
                HeaderText = "地區",
                DataSource = dtAreas,
                ValueMember = "AreaID",
                DisplayMember = "AREA"
            };
            dgvWorkOrder.Columns.Add(areaCol);

            // 會員帳號
            var memberCol = new DataGridViewComboBoxColumn()
            {
                DataPropertyName = "MemberID",
                HeaderText = "會員帳號",
                DataSource = LoadMembers(),
                ValueMember = "MemberID",
                DisplayMember = "MemberAccount"
            };
            dgvWorkOrder.Columns.Add(memberCol);

            // 機型
            dgvWorkOrder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ModelName",
                HeaderText = "機型"
            });

            // 建單時間
            dgvWorkOrder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CreatedDate",
                HeaderText = "建單時間"
            });

            // 地址
            dgvWorkOrder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AddressDetail",
                HeaderText = "施工地址"
            });
        }
        private void RE_btnAdd_Click(object sender, EventArgs e)
        {

            //  先初始化表格與欄位（僅在第一次新增時）
            if (dtWorkOrders == null)
            {
                dtWorkOrders = new DataTable();
                dtWorkOrders.Columns.Add("WorkOrderID", typeof(int));
                dtWorkOrders.Columns.Add("WorkTypeID", typeof(int));
                dtWorkOrders.Columns.Add("TechnicianID", typeof(int));
                dtWorkOrders.Columns.Add("CityID", typeof(int));
                dtWorkOrders.Columns.Add("AreaID", typeof(int));
                dtWorkOrders.Columns.Add("MemberID", typeof(int));
                dtWorkOrders.Columns.Add("ModelName", typeof(string));
                dtWorkOrders.Columns.Add("CreatedDate", typeof(DateTime));
                dtWorkOrders.Columns.Add("AddressDetail", typeof(string));

                dgvWorkOrder.DataSource = dtWorkOrders;
                InitGridColumns(); // 載入欄位樣式
            }

            //  自動產生下一筆工單編號（查 MAX + 1）
            int nextID = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT ISNULL(MAX(WorkOrderID), 0) + 1 FROM WorkOrder";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    nextID = (int)cmd.ExecuteScalar();
                }
            }

            // ➕ 建立資料列並自動填入欄位
            DataRow row = dtWorkOrders.NewRow();
            row["WorkOrderID"] = nextID;
            row["CreatedDate"] = DateTime.Now;
            dtWorkOrders.Rows.Add(row);
            UpdateCountLabel();
        }
        private void UpdateCountLabel()
        {
            int count = dtWorkOrders?.Rows.Count ?? 0;
            RE_lblCount.Text = $"筆數：{count}";
        }

        private void LoadWorkOrders()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT WorkOrderID, WorkTypeID, TechnicianID, CityID, AreaID, MemberID, 
                              ModelName, CreatedDate, AddressDetail 
                       FROM WorkOrder";
                adapter = new SqlDataAdapter(sql, conn);
                dtWorkOrders = new DataTable();
                adapter.Fill(dtWorkOrders);
                dgvWorkOrder.DataSource = dtWorkOrders;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dtWorkOrders == null || dtWorkOrders.Rows.Count == 0)
            {
                MessageBox.Show("沒有任何資料可以儲存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT WorkOrderID, WorkTypeID, TechnicianID, CityID, AreaID, MemberID, 
                              ModelName, CreatedDate, AddressDetail 
                       FROM WorkOrder";

                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                try
                {
                    conn.Open();
                    int rows = adapter.Update(dtWorkOrders);
                    MessageBox.Show($"成功儲存 {rows} 筆工單資料", "儲存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }


    
}

