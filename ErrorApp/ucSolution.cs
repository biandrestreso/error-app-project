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
    public partial class ucSolution : UserControl
    {
        public ucSolution()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public static DataTable dtLogin;
        bool selectDone = false;

        private void ucSolution_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            dtLogin = frmLogin.dtLogin;

            refresh();
            resetUC();
        }

        public void refresh() //Refresh dgv and cmb's
        {
            selectDone = false;

            DataTable dtMerge = new DataTable();

            UserModule userModule = new UserModule(int.Parse(dtLogin.Rows[0]["UserID"].ToString()));
            DataTable dtModule = bll.GetUserModule(userModule);

            if (int.Parse(dtLogin.Rows[0]["RoleID"].ToString()) == 1)
            {
                dgvSolution.DataSource = bll.GetSolutionError();
            }
            else
            {
                foreach (DataRow drow in dtModule.Rows)
                {
                    Module module = new Module(int.Parse(drow["Module ID"].ToString()), null);
                    DataTable dtTemp = bll.GetSolutionByModule(module);

                    dtMerge.Merge(dtTemp);
                }

                dgvSolution.DataSource = dtMerge;
            }

            DataTable dt = bll.GetModule();

            DataRow dr = dt.NewRow();
            dr["Module ID"] = 0;
            dr["Module"] = "None";

            dt.Rows.InsertAt(dr, 0);

            cmbModule.DataSource = dt;
            cmbModule.ValueMember = "Module ID";
            cmbModule.DisplayMember = "Module";

            selectDone = true;
            setColumn();
        }

        public void resetUC() //Reset entire usercontrol
        {
            pnlDelete.Hide();
            pnlUpdate.Hide();
            pnlSolutionDialog.Hide();

            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

            refresh();
        }

        private void setColumn() //Set column width after databinding
        {
            if (dgvSolution.Rows.Count > 0)
            {
                dgvSolution.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSolution.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) //Close dialog menu
        {
            pnlSolutionDialog.Hide();

            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDesc.Text = dgvSolution.SelectedRows[0].Cells["Solution"].Value.ToString();

            pnlSolutionDialog.Show();
            pnlSolutionDialog.BringToFront();

            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SolutionError solutionError = new SolutionError(int.Parse(dgvSolution.SelectedRows[0].Cells["Solution ID"].Value.ToString()));
            bll.DeleteSolution(solutionError);

            refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool invalid = false;

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                errorSolution.SetError(txtDesc, "Please enter a description");
                invalid = true;
            }
            else
            {
                errorSolution.SetError(txtDesc, "");
                invalid = false;
            }

            if (!invalid)
            {
                SolutionError solutionError = new SolutionError(int.Parse(dgvSolution.SelectedRows[0].Cells["Solution ID"].Value.ToString()), txtDesc.Text);
                bll.UpdateSolution(solutionError);

                pnlSolutionDialog.Hide();

                btnUpdate.Click += btnUpdate_Click;
                btnDelete.Click += btnDelete_Click;

                refresh();
            }
        }

        private void dgvSolution_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSolution.ClearSelection();
        }

        private void dgvSolution_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolution.Rows.Count > 0)
            {
                if (dgvSolution.SelectedRows.Count == 1)
                {
                    pnlUpdate.Show();

                    string lecturer = dtLogin.Rows[0]["Username"].ToString() + " " + dtLogin.Rows[0]["Surname"].ToString();
                    if (dgvSolution.SelectedRows[0].Cells["Lecturer"].Value.ToString() == lecturer)
                    {
                        pnlDelete.Show();
                    }
                    else
                        pnlDelete.Hide();
                }
                else
                {
                    pnlUpdate.Hide();
                    pnlDelete.Hide();
                }
            }
        }

        private void txtSearchError_TextChanged(object sender, EventArgs e)
        {
            (dgvSolution.DataSource as DataTable).DefaultView.RowFilter = string.Format("Error LIKE '%{0}%'", txtSearchError.Text);
        }

        private void txtSearchSolution_TextChanged(object sender, EventArgs e)
        {
            (dgvSolution.DataSource as DataTable).DefaultView.RowFilter = string.Format("Solution LIKE '%{0}%'", txtSearchSolution.Text);
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectDone)
            {
                if (cmbModule.Text != "None")
                    (dgvSolution.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Module and Topic] LIKE '%{0}%'", cmbModule.Text);
                else if (cmbModule.Text == "None")
                    (dgvSolution.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            SolutionError solutionError = new SolutionError(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvSolution.DataSource = bll.GetSolutionByDate(solutionError);
            setColumn();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
