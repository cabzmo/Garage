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
        public formAdmin(string para)
        {
            uname = para;
            InitializeComponent();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            this.Text = "User " + uname;
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuRepairs_Click(object sender, EventArgs e)
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

        }
    }
}
