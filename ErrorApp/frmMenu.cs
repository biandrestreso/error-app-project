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
    public partial class frmMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMenu()
        {
            InitializeComponent();
        }

        public static DataTable dtLogin;

        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            dtLogin = frmLogin.dtLogin;

            setUser(dtLogin);
        }

        public void setUser(DataTable dtLogin)
        {
            lblName.Text = dtLogin.Rows[0]["Username"].ToString() + " " + dtLogin.Rows[0]["Surname"].ToString();
            lblEmail.Text = dtLogin.Rows[0]["Email"].ToString();
            lblRole.Text = dtLogin.Rows[0]["RoleDescription"].ToString();

            switch (int.Parse(dtLogin.Rows[0]["RoleID"].ToString()))
            { 
                case 1:
                    break;
                case 2:
                    btnAdmin.Hide();
                    break;
                case 3:
                    btnAdmin.Hide();
                    btnModuleTopic.Hide();
                    break;
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ucDashboard.BringToFront();
            ucDashboard.refresh();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            ucError.BringToFront();
            ucError.refresh();
            ucError.resetUC();
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            ucSolution.BringToFront();
            ucSolution.refresh();
            ucSolution.resetUC();
        }

        private void btnModuleTopic_Click(object sender, EventArgs e)
        {
            ucModuleTopic.BringToFront();
            ucModuleTopic.refresh();
            ucModuleTopic.resetUC();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ucAdmin.BringToFront();
            ucAdmin.refresh();
            ucAdmin.resetUC();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
            dtLogin = null;
        }
    }
}
