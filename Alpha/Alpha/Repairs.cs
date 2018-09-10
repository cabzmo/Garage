using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha
{
    public partial class Repairs : Form
    {
        private formAdmin _formAdmin;

        public Repairs(formAdmin Admin)
        {
            InitializeComponent();
            _formAdmin = Admin;
        }

        private void Repairs_Load(object sender, EventArgs e)
        {
            rtb1.Dock = DockStyle.Left; rtb1.Dock = DockStyle.Right; rtb1.Dock = DockStyle.Top;
            rtb1.Height = this.Height - 115;
            int w = Convert.ToInt16(this.Width);
            int mid = (w / 2) - 23;
            btnSave.Left = mid;
            btnSave.Top = this.Height - 107;


            // Check if the file exists
            // If it does NOT, create the file
            string path = @"repairs.txt";
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
            }


            // Load the textbox with the data from the file
            rtb1.Text = System.IO.File.ReadAllText(path);


        }

        private void Repairs_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) { this.Hide(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add save form code here (json or mysql or both) (currently just saving in a text file)

            // Confirm that the file exists

            string path = @"repairs.txt";
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("There was an error saving the data\nPlease contact a system administrator",
                    "Error", MessageBoxButtons.OK);
                return;
            }

            // Save the data from the textbox into the file
            try
            {
                System.IO.File.WriteAllText(path, rtb1.Text);
                btnSave.Font = new Font(btnSave.Font, FontStyle.Regular);
                _formAdmin.resetForm();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error saving the data\nPlease contact a system administrator",
                    "Error", MessageBoxButtons.OK);
                return;
            }

            WindowState = FormWindowState.Minimized;
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.ReadAllText(@"repairs.txt").ToString() == rtb1.Text)
            {
                btnSave.Font = new Font(btnSave.Font, FontStyle.Regular);
                _formAdmin.allSavedTrue();
            }
            else
            {
                btnSave.Font = new Font(btnSave.Font, FontStyle.Bold);
                _formAdmin.allSavedFalse();
            }

            
        }
    }
}
