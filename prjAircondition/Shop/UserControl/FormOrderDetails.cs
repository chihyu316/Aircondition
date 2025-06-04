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

namespace prjAircondition
{
    public partial class FormOrderDetails : Form
    {
        private string connStr = "Data Source=.;Initial Catalog=AC;Integrated Security=True";
        public FormOrderDetails(string memberId)
        {
            InitializeComponent();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s_DProductImage);

        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 's_DProductImage.OrderDetails' 資料表。您可以視需要進行移動或移除。
            this.orderDetailsTableAdapter.Fill(this.s_DProductImage.OrderDetails);

        }

        private void txtCoolingProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCoolingProductID_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtCoolingProductID.Text.Trim(), out int productId))
            {
                string sql = "SELECT Price FROM CoolingProduct WHERE CoolingProductID = @id";
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    conn.Open();
                    object price = cmd.ExecuteScalar();
                    if (price != null)
                    {
                        txtUnitPrice.Text = Convert.ToDecimal(price).ToString("0.00");
                        CalculateSubtotal(); // 自動計算小計
                    }
                }
            }
        }

        private void txtMaterialID_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaterialID.Text.Trim(), out int materialId))
            {
                string sql = "SELECT Price FROM Material WHERE MaterialID = @id";
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", materialId);
                    conn.Open();
                    object price = cmd.ExecuteScalar();
                    if (price != null)
                    {
                        txtUnitPrice.Text = Convert.ToDecimal(price).ToString("0.00");
                        CalculateSubtotal(); // 自動算小計
                    }
                }
            }
        }
        private void CalculateSubtotal()
        {
            if (decimal.TryParse(txtUnitPrice.Text, out decimal price) &&
                int.TryParse(txtQuantity.Text, out int qty))
            {
                txtSubtotal.Text = (price * qty).ToString("0.00");
            }
        }

        private void detailIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
