using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsAppFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check Login Username & Password
            if(txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                //lblMessage.Text = "Welcome " + txtUserName.Text + "!";

                Dashboard obj = new Dashboard();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter correct Username and Password");
            }
        }
    }
}
