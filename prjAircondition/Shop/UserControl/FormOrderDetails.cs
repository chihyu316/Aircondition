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
    public partial class FormOrderDetails : Form
    {
        private string _memberId;
        public FormOrderDetails(string memberId)
        {
            InitializeComponent();
            _memberId = memberId;  // 💾 把傳進來的 memberId 存下來           
        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 's_DOrderProcessing.OrderDetails' 資料表。您可以視需要進行移動或移除。
            this.orderDetailsTableAdapter.Fill(this.s_DOrderProcessing.OrderDetails);
            // TODO: 這行程式碼會將資料載入 's_DOrderProcessing.OrderDetails' 資料表。您可以視需要進行移動或移除。
            this.orderDetailsTableAdapter.Fill(this.s_DOrderProcessing.OrderDetails);
            // TODO: 這行程式碼會將資料載入 's_DOrderProcessing.OrderDetails' 資料表。您可以視需要進行移動或移除。
            this.orderDetailsTableAdapter.Fill(this.s_DOrderProcessing.OrderDetails);
            //LoadOrdersForMember(_memberId);
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s_DOrderProcessing);

        }

        private void orderDetailsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s_DOrderProcessing);

        }

        private void orderDetailsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s_DOrderProcessing);

        }
    }
}
