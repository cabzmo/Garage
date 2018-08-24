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
    public partial class formAdmin : Form
    {
        Repairs repairs = new Repairs(); 
        string uname;
        public formAdmin(string para)
        {
            uname = para;
            InitializeComponent();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            repairs.MdiParent = this;
            this.Text = "User " + uname;
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuRepairs_Click(object sender, EventArgs e)
        {
            //Repairs newMDIChild = new Repairs();
            // Set the Parent Form of the Child window.  
            //newMDIChild.MdiParent = this;
            // Display the new form.  
            //MessageBox.Show(Application.OpenForms.ToString(), "hi", MessageBoxButtons.OK);
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Repairs))
                {
                    form.WindowState = FormWindowState.Normal;
                    return;
                }
            }

            Repairs repairs = new Repairs();
            repairs.MdiParent = this;
            repairs.Show();

        }
    }
}
