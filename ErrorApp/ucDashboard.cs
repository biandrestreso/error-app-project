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
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public static DataTable dtLogin;

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            dtLogin = frmLogin.dtLogin;

            refresh();
        }

        public void refresh() //Refresh everything on usercontrol based on user logged in
        {
            switch (Convert.ToInt32(dtLogin.Rows[0]["RoleID"].ToString()))
            {
                case 1:
                    lblHeading.Text = "";
                    break;
                case 2:
                    lblHeading.Text = "Your Solutions";
                    User userLecturer = new User(Convert.ToInt32(dtLogin.Rows[0]["UserID"].ToString()));
                    dgvDashboard.DataSource = bll.GetSolutionByUser(userLecturer);
                    break;
                case 3:
                    lblHeading.Text = "Your Errors";
                    User userStudent = new User(Convert.ToInt32(dtLogin.Rows[0]["UserID"].ToString()));
                    dgvDashboard.DataSource = bll.GetErrorByUser(userStudent);
                    break;
            }
            
            DataTable dt = bll.GetLeastAnswered();
            if (dt.Rows.Count > 0)
                lblRed.Text = dt.Rows[0][1].ToString();
            else
                lblRed.Text = "No Solutions";

            dt = bll.GetMostAnswered();
            if (dt.Rows.Count > 0)
                lblPurple.Text = dt.Rows[0][1].ToString();
            else
                lblPurple.Text = "No Solutions";

            dt = bll.CountErrors();
            if (dt.Rows.Count > 0)
                lblGreen.Text = dt.Rows[0][0].ToString();

            dt = bll.CountPending();
            if (dt.Rows.Count > 0)
                lblLightBlue.Text = dt.Rows[0][0].ToString();

            dt = bll.CountSolved();
            if (dt.Rows.Count > 0)
                lblBlue.Text = dt.Rows[0][0].ToString();

            UserModule userModule = new UserModule(int.Parse(dtLogin.Rows[0]["UserID"].ToString()));
            dt = bll.GetUserModule(userModule);

            if (dt.Rows.Count > 0)
            {
                lblModules.Text = "";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string addModule = dt.Rows[i][1].ToString() + "\n";
                    lblModules.Text += addModule;
                }
            }
            else
            {
                lblModules.Text = "No Modules to Display";
            }

            setColumn();
        }

        private void setColumn() //Set column width after data added
        {
            if (dgvDashboard.Rows.Count > 0)
            {
                dgvDashboard.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDashboard.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
