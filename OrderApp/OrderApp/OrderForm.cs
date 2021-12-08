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
    public partial class OrderForm : Form
    {
        MainForm MainForm;
        public Order Order;
        public List<OrderItem> OrderItems;

        public OrderForm(MainForm mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;

            Order = new Order();
            Order.Id = new Random().Next(1000);
            OrderItems = new List<OrderItem>();

            RefreshGridView();
        }

        public void RefreshGridView()
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = OrderItems;
            dgvOrderItems.DataSource = bSource;
            dgvOrderItems.Refresh();
            dgvOrderItems.Update();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm(this);
            itemForm.ShowDialog();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();

                Order.CustomerName = txtCustomerName.Text;

                OrderManager orderManager = new OrderManager();
                orderManager.SaveOrder(Order, OrderItems);

                MainForm.RefreshGridView();

                MessageBox.Show("Your order has been saved successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ValidateInputs()
        {
            string customerName = txtCustomerName.Text;
            if (string.IsNullOrEmpty(customerName))
                throw new Exception("Customer Name is required.");

            if(OrderItems.Count == 0)
                throw new Exception("Items are required.");

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new PDFGenerator().Generate(Order);
        }
    }
}
