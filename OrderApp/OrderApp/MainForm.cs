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
        public MainForm()
        {
            InitializeComponent();
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
            OrderManager orderManager = new OrderManager();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = orderManager.GetAllOrders();
            dgvOrders.DataSource = bSource;
        }
    }
}
