using OrderApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class ItemForm : Form
    {
        OrderForm OrderForm;
        public ItemForm(OrderForm orderForm)
        {
            InitializeComponent();
            OrderForm = orderForm;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            OrderManager orderManager = new OrderManager();
            cmbItems.DataSource = orderManager.GetAllItems();
            cmbItems.DisplayMember = "Name";
            cmbItems.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();

                OrderForm.OrderItems.Add(new OrderItem()
                {
                    OrderId = OrderForm.Order.Id,
                    ItemId = (int)cmbItems.SelectedValue,
                    Quantity = int.Parse(txtQuantity.Text)
                });

                OrderForm.RefreshGridView();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
                throw new Exception("Please enter quantity");

            int quantity = int.Parse(txtQuantity.Text);
            if (quantity < 1 || quantity > 100)
                throw new Exception("Quantity must be between 1 and 100");
        }
    }
}
