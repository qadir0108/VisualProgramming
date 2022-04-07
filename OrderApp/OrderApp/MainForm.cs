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
    public partial class MainForm : Form
    {
        OrderManager orderManager;
        public MainForm()
        {
            ObserverPattern observer = new ObserverPattern();
            observer.Run();

            InitializeComponent();
            orderManager = new OrderManager();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(this);
            orderForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshGridView();
           
        }

        public void RefreshGridView()
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = orderManager.GetAllOrders();
            dgvOrders.DataSource = bSource;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvOrders.SelectedRows;
            if (selectedRows == null || selectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to DELETE");
                return;
            }

            if (selectedRows[0].Cells[0].Value == null)
                return;

            int orderId = (int)selectedRows[0].Cells[0].Value;
            orderManager.DeleteOrder(orderId);
            MessageBox.Show("Order deleted succefully.");
            RefreshGridView();

        }
    }
}
