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
        public Repairs()
        {
            InitializeComponent();
        }

        private void Repairs_Load(object sender, EventArgs e)
        {
            rtb1.Dock = DockStyle.Left; rtb1.Dock = DockStyle.Right; rtb1.Dock = DockStyle.Top;
            rtb1.Height = this.Height - 115;
            int w = Convert.ToInt16(this.Width);
            int mid = (w / 2) - 23;
            btnSave.Left = mid;
            btnSave.Top = this.Height - 107;

        }

        private void Repairs_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) { this.Hide(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add save form code here (json or mysql or both)

            WindowState = FormWindowState.Minimized;
        }
    }
}
