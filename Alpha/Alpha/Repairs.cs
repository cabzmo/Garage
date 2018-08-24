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

        }

        private void Repairs_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) { this.Hide(); }
        }
    }
}
