using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ErrorApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public static DataTable dtLogin;

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "s221424660@mandela.ac.za";
            txtPassword.Text = "Chenay11581975";

            User user = new User(txtEmail.Text, txtPassword.Text);
            DataTable dt = bll.GetCountLogin(user);

            if (dt.Rows[0][0].ToString() == "1")
            { 
                dtLogin = bll.GetLoginUser(user);

                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                this.Hide();
            }

            txtPassword.Text = "";
        }

        private void pnlEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else if (!chkShowPass.Checked)
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
