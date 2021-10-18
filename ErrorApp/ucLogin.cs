using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorApp
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
