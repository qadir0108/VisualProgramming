using StudentAdmissionSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdmissionSystem
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentManager manager = new StudentManager();
            try
            {
                long cnic = long.Parse(txtCNIC.Text);
                manager.Add(cnic, txtFirstName.Text, txtLastName.Text);
                MessageBox.Show("New Student Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentManager manager = new StudentManager();
            try
            {
                long cnic = long.Parse(txtCNIC.Text);
                Student found = manager.Search(cnic);

                if (found == null)
                    MessageBox.Show("Not Found.");
                else
                {
                    txtFirstName.Text = found.FirstName;
                    txtLastName.Text = found.LastName;
                    MessageBox.Show("Stduent Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentManager manager = new StudentManager();
            try
            {
                long cnic = long.Parse(txtCNIC.Text);
                bool result = manager.Delete(cnic);
                if (result == true)
                    MessageBox.Show("Delete.");
                else
                    MessageBox.Show("Cannot Delete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StudentManager manager = new StudentManager();
            List<Student> students = manager.GetAll();

            BindingSource source = new BindingSource();
            source.DataSource = students;

            dgvStudents.DataSource = source;
        }
    }
}
