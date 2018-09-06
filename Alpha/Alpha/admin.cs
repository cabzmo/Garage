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
        string uname;
        bool AllSaved = false;

        private void OpenRepair()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Repairs))
                {
                    form.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            Repairs repairs = new Repairs();
            repairs.MdiParent = this;
            repairs.WindowState = FormWindowState.Maximized;
            repairs.Show();
            menuRepairs.Font = new Font(menuRepairs.Font, FontStyle.Bold);
        }

        public formAdmin(string para)
        {
            uname = para;
            InitializeComponent();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            this.Text = "User " + uname;
            this.WindowState = FormWindowState.Maximized;
            //OpenRepair();
        }

        private void menuRepairs_Click(object sender, EventArgs e)
        {
            
            foreach (Form form in Application.OpenForms)
                
                // If the form is already opened ...

                if (form.GetType() == typeof(Repairs))
                {
                    // ... and the form is minimized:
                    if (form.WindowState == FormWindowState.Minimized)
                    {   
                        // maximize it
                        form.WindowState = FormWindowState.Maximized;
                        return;
                    }
                    
                    // ... and the form is maximized:
                    else if (form.WindowState == FormWindowState.Maximized)
                    {   // minimize it
                        form.WindowState = FormWindowState.Minimized;
                        return;
                    }

                }
            // if the form is not open (due to unreturned functions), open it
            OpenRepair();


        }

        void formB_ButtonWasClicked()
        {
            AllSaved = true;
        }

        private void formAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AllSaved == true)
            {

            }
            else
            {
                if (MessageBox.Show("Any unsaved data will be discarded", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                }
                else
                {
                    // user clicked no
                    foreach (Form form in Application.OpenForms)
                    {
                        form.WindowState = FormWindowState.Maximized;
                        return;
                    }
                }
            }
        }
    }
}
