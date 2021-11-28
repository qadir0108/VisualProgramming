using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _34_Events
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
        }

        public void Run()
        {
            // desing a button over form  
            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Save";
            btn.Location = new Point(10, 10);
           
            //Event handler is assigned to the button click event  
            btn.Click += new System.EventHandler(CatchClickEvent);

            Console.ReadLine();

        }

        //call when button clicked  
        public void CatchClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Your admission has been saved!");
        }
    }
}
