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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPword = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(94, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cabz Cars";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(38, 94);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(55, 13);
            this.lblUname.TabIndex = 1;
            this.lblUname.Text = "Username";
            // 
            // lblPword
            // 
            this.lblPword.AutoSize = true;
            this.lblPword.Location = new System.Drawing.Point(38, 131);
            this.lblPword.Name = "lblPword";
            this.lblPword.Size = new System.Drawing.Size(53, 13);
            this.lblPword.TabIndex = 2;
            this.lblPword.Text = "Password";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(115, 87);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(100, 20);
            this.txtUname.TabIndex = 3;
            // 
            // txtPword
            // 
            this.txtPword.Location = new System.Drawing.Point(115, 124);
            this.txtPword.Name = "txtPword";
            this.txtPword.PasswordChar = '*';
            this.txtPword.Size = new System.Drawing.Size(100, 20);
            this.txtPword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(53, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(152, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formLogin
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblPword);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblTitle);
            this.Name = "formLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private Label lblTitle;
        private Label lblUname;
        private Label lblPword;
        private TextBox txtUname;
        private TextBox txtPword;
        private Button btnLogin;
        private Button btnClose;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUname.Text == "cab") && (txtPword.Text == "123"))
            {
                MessageBox.Show("Welcome " + txtUname.Text, "Login successful", MessageBoxButtons.OK);
                formAdmin next = new formAdmin(txtUname.Text);
                txtUname.Text = "";
                txtPword.Text = "";
                this.Visible = false;
                next.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect\nPlease try again", "Login unsuccessful", MessageBoxButtons.OK);
            }
        }
    }
}
