using prjAircondition.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace prjAircondition.Shop
{
    public partial class S_UcProduct1 : UserControl
    {
        private SqlDataAdapter adapter;
        private System.Data.DataSet dataSet;
        private BindingSource bindingSource;
        private SqlCommandBuilder commandBuilder;
        private DataTable vendorTable;

        public S_UcProduct1()
        {
            InitializeComponent();
        }

        private void S_UcProduct1_Load(object sender, EventArgs e)
        {
            LoadVendorList();
            LoadCoolingProduct();
            LoadFunctionTypes();
            this.dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            this.dataGridView1.DefaultValuesNeeded += dataGridView1_DefaultValuesNeeded; // 預設值
            btnSearchByFunction.Click += btnSearchByFunction_Click;
        }

        private void LoadVendorList()
        {
            vendorTable = new DataTable();
            string connString = Settings.Default.ACConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "SELECT VendorID, VendorName FROM Vendor";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(vendorTable);
            }

            comboVendor.DataSource = vendorTable;
            comboVendor.DisplayMember = "VendorName";
            comboVendor.ValueMember = "VendorID";
            comboVendor.SelectedIndex = -1;
        }

        private void LoadFunctionTypes()
        {
            string connStr = Settings.Default.ACConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT DISTINCT FunctionType FROM CoolingFunction";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboFunctionType.DataSource = dt;
                comboFunctionType.DisplayMember = "FunctionType";
                comboFunctionType.ValueMember = "FunctionType";
                comboFunctionType.SelectedIndex = -1;
            }
        }

        private void LoadCoolingProduct()
        {
            string connString = Settings.Default.ACConnectionString;
            string sql = "SELECT * FROM CoolingProduct";

            adapter = new SqlDataAdapter(sql, connString);
            commandBuilder = new SqlCommandBuilder(adapter);

            dataSet = new System.Data.DataSet();
            adapter.Fill(dataSet, "CoolingProduct");

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables["CoolingProduct"];
            dataGridView1.DataSource = bindingSource;

            if (dataGridView1.Columns.Contains("CoolingProductID"))
            {
                dataGridView1.Columns["CoolingProductID"].ReadOnly = true;
                dataGridView1.Columns["CoolingProductID"].DefaultCellStyle.BackColor = Color.LightGray;
            }

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bindingSource.EndEdit();
                bool hasNewRow = false;

                foreach (DataRow row in dataSet.Tables["CoolingProduct"].Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        string name = row["CoolingName"]?.ToString().Trim();
                        string priceText = row["Price"]?.ToString().Trim();
                        string stockText = row["Stock"]?.ToString().Trim();
                        string rateText = row["InstallmentRate"]?.ToString().Trim();

                        if (string.IsNullOrEmpty(name) ||
                            !decimal.TryParse(priceText, out decimal price) || price < 0 ||
                            !int.TryParse(stockText, out int stock) || stock < 0 )
                            //!int.TryParse(rateText, out int rate) || rate < 0)
                        {
                            MessageBox.Show("請確認欄位是否完整與正確（名稱、價格、庫存、分期）", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        row["CreatedTime"] = DateTime.Now;
                        row["CreatedBy"] = "admin";
                        hasNewRow = true;
                    }
                }

                if (!hasNewRow)
                {
                    MessageBox.Show("請先在表格中輸入一筆新資料再點選新增。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                adapter.Update(dataSet, "CoolingProduct");
                MessageBox.Show("新增成功！");
                LoadCoolingProduct(); // 重新加載以刷新 ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗: " + ex.Message);
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["CreatedTime"].Value = DateTime.Now;
            e.Row.Cells["CreatedBy"].Value = "admin";
            e.Row.Cells["Stock"].Value = 0;  // 確保 Stock 預設為 0
            e.Row.Cells["Price"].Value = 0;  // 確保 Price 預設為 0
            e.Row.Cells["InstallmentRate"].Value = 0;  // 確保 InstallmentRate 預設為 0
            e.Row.Cells["ProductStatus"].Value = 1;
        }

        private void btnSearchByFunction_Click(object sender, EventArgs e)
        {
            if (comboFunctionType.SelectedValue != null && comboVendor.SelectedValue != null)
            {
                string functionType = comboFunctionType.SelectedValue.ToString();
                int vendorId = Convert.ToInt32(comboVendor.SelectedValue);

                string connStr = Settings.Default.ACConnectionString;
                string sql = @"
                    SELECT DISTINCT cp.*
                    FROM CoolingProduct cp
                    JOIN Vendor v ON cp.VendorID = v.VendorID
                    JOIN CoolingFunctionMap map ON cp.CoolingProductID = map.CoolingProductID
                    JOIN CoolingFunction cf ON map.FunctionTypeID = cf.FunctionTypeID
                    WHERE v.VendorID = @VendorID AND cf.FunctionType = @FunctionType";

                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@VendorID", vendorId);
                    cmd.Parameters.AddWithValue("@FunctionType", functionType);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("請先選擇廠商與功能分類！");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Category" && e.Value is int val1)
            {
                e.Value = val1 == 0 ? "家用" : val1 == 1 ? "商用" : "其他";
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Type" && e.Value is int val2)
            {
                e.Value = val2 == 0 ? "定頻" : val2 == 1 ? "變頻" : "其他";
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "ProductStatus" && e.Value is int val3)
            {
                e.Value = val3 == 0 ? "下架" : "上架";
            }
        }
    }
}
