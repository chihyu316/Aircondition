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

            if (dataGridView1.Columns.Contains("CoolingProductID")) dataGridView1.Columns["CoolingProductID"].HeaderText = "商品編號";
            if (dataGridView1.Columns.Contains("CoolingName")) dataGridView1.Columns["CoolingName"].HeaderText = "商品名稱";
            if (dataGridView1.Columns.Contains("Category")) dataGridView1.Columns["Category"].HeaderText = "商品類別";
            if (dataGridView1.Columns.Contains("Type")) dataGridView1.Columns["Type"].HeaderText = "商品類型";
            if (dataGridView1.Columns.Contains("CoolingEfficiencyID")) dataGridView1.Columns["CoolingEfficiencyID"].HeaderText = "能效等級ID";
            if (dataGridView1.Columns.Contains("Price")) dataGridView1.Columns["Price"].HeaderText = "價格";
            if (dataGridView1.Columns.Contains("Description")) dataGridView1.Columns["Description"].HeaderText = "商品描述";
            if (dataGridView1.Columns.Contains("InstallmentRate")) dataGridView1.Columns["InstallmentRate"].HeaderText = "分期率";
            if (dataGridView1.Columns.Contains("Stock")) dataGridView1.Columns["Stock"].HeaderText = "庫存";
            if (dataGridView1.Columns.Contains("ProductStatus")) dataGridView1.Columns["ProductStatus"].HeaderText = "上架狀態";
            if (dataGridView1.Columns.Contains("CreatedTime")) dataGridView1.Columns["CreatedTime"].HeaderText = "建立時間";
            if (dataGridView1.Columns.Contains("CreatedBy")) dataGridView1.Columns["CreatedBy"].HeaderText = "建立者";
            if (dataGridView1.Columns.Contains("UpdatedTime")) dataGridView1.Columns["UpdatedTime"].HeaderText = "修改時間";
            if (dataGridView1.Columns.Contains("UpdatedBy")) dataGridView1.Columns["UpdatedBy"].HeaderText = "修改者";
            if (dataGridView1.Columns.Contains("VendorID")) dataGridView1.Columns["VendorID"].HeaderText = "廠商";

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
                            MessageBox.Show("請確認欄位是否完整與正確（名稱、價格、庫存）", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string connStr = Settings.Default.ACConnectionString;

            // ✅ 廠商 + 功能類型都選
            if (comboFunctionType.SelectedValue != null && comboVendor.SelectedValue != null)
            {
                string functionType = comboFunctionType.SelectedValue.ToString();
                int vendorId = Convert.ToInt32(((DataRowView)comboVendor.SelectedItem)["VendorID"]);

                string sql = @"
            SELECT DISTINCT cp.*
            FROM CoolingProduct cp
            JOIN CoolingFunctionMap map ON cp.CoolingProductID = map.CoolingProductID
            JOIN CoolingFunction cf ON map.FunctionTypeID = cf.FunctionTypeID
            WHERE cp.VendorID = @VendorID AND cf.FunctionType = @FunctionType";

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
            // ✅ 只有選功能（沒選廠商）
            else if (comboFunctionType.SelectedValue != null)
            {
                string functionType = comboFunctionType.SelectedValue.ToString();

                string sql = @"
            SELECT DISTINCT cp.*
            FROM CoolingProduct cp
            JOIN CoolingFunctionMap map ON cp.CoolingProductID = map.CoolingProductID
            JOIN CoolingFunction cf ON map.FunctionTypeID = cf.FunctionTypeID
            WHERE cf.FunctionType = @FunctionType";

                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FunctionType", functionType);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            // ✅ 只有選廠商（已有 fallback）
            else if (comboVendor.SelectedValue != null)
            {
                comboVendor_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("請至少選擇廠商或功能分類！");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dataGridView1.Columns.Count)
                return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

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
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "VendorID" && e.Value is int val4)
            {
                e.Value = val4 == 1 ? "日立" : val4 == 2 ? "大金" : val4 == 3 ? "三菱" : "其他廠商";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("請選擇一筆要刪除的資料！");
                return;
            }

            // 取得選取列的主鍵 ID
            var result = MessageBox.Show("確定要刪除這筆資料嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CoolingProductID"].Value);
                string connString = Settings.Default.ACConnectionString;
                string sql = "DELETE FROM CoolingProduct WHERE CoolingProductID = @ID";

                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(rows > 0 ? "刪除成功！" : "刪除失敗！");
                    LoadCoolingProduct(); // 重新載入資料
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗：" + ex.Message);
            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bindingSource.EndEdit();

                // 記錄目前選取的 CoolingProductID
                int selectedID = -1;
                if (dataGridView1.CurrentRow != null)
                {
                    object val = dataGridView1.CurrentRow.Cells["CoolingProductID"].Value;
                    if (val != DBNull.Value && val != null)
                        selectedID = Convert.ToInt32(val);
                }

                // 更新 UpdatedTime
                foreach (DataRow row in dataSet.Tables["CoolingProduct"].Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        row["UpdatedTime"] = DateTime.Now;
                    }
                }

                // 更新資料庫
                adapter.Update(dataSet, "CoolingProduct");
                MessageBox.Show("修改儲存成功！");

                // 重新載入資料
                LoadCoolingProduct();

                // 嘗試重新選取剛剛那一筆 CoolingProductID
                if (selectedID > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["CoolingProductID"].Value != null &&
                            Convert.ToInt32(row.Cells["CoolingProductID"].Value) == selectedID)
                        {
                            row.Selected = true;
                            dataGridView1.CurrentCell = row.Cells[1]; // 讓焦點在某欄
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失敗：" + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            comboVendor.SelectedIndex = -1;
            comboFunctionType.SelectedIndex = -1;
            LoadCoolingProduct();
            MessageBox.Show("已顯示全部商品！");
        }

        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVendor.SelectedItem is DataRowView rowView && comboFunctionType.SelectedValue == null)
            {
                int vendorId = Convert.ToInt32(rowView["VendorID"]);

                string connStr = Settings.Default.ACConnectionString;
                string sql = "SELECT * FROM CoolingProduct WHERE VendorID = @VendorID";

                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@VendorID", vendorId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
