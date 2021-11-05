/* Name:                Biandre
 * Surname:             Streso
 * Student Number:      221424660
 * 
 * Declaration
 * - I state that this is my own work.
 * - I have not submitted another person's practical as my own.
 * - I understand that copying is a serious form of academic dishonesty.
 * - I know that I will get zero, if copied.
 */
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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmLogin()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public static DataTable dtLogin = new DataTable();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblIncorrect.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(txtEmail.Text, txtPassword.Text);
            DataTable dt = bll.GetCountLogin(user);

            if (Convert.ToInt32(dt.Rows[0][0].ToString()) > 0)
            { 
                dtLogin = bll.GetLoginUser(user);

                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                this.Hide();
            }

            lblIncorrect.Show();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitleBarLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlTitleBarRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
