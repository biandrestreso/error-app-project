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
    public partial class ucError : UserControl
    {
        public ucError()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public static DataTable dtLogin;

        string action;

        private void ucError_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            dtLogin = frmLogin.dtLogin;

            resetUC();
            refresh();

            dgvError.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvError.ClearSelection();
        }

        public void resetUC()
        {
            pnlErrorDialog.Hide();
            pnlUpdate.Hide();
            pnlDelete.Hide();
            pnlSolution.Hide();
        }

        public void refresh()
        {

            dgvError.DataSource = bll.GetError();

            cmbProgLang.DataSource = bll.GetProgLang();
            cmbProgLang.ValueMember = "ProgLangID";
            cmbProgLang.DisplayMember = "ProgLangDesc";

            DataTable dt = bll.GetProgLang();

            DataRow dr = dt.NewRow();
            dr["ProgLangID"] = 0;
            dr["ProgLangDesc"] = "SELECT";

            dt.Rows.InsertAt(dr, 0);

            cmbViewProgLang.DataSource = dt;
            cmbViewProgLang.ValueMember = "ProgLangID";
            cmbViewProgLang.DisplayMember = "ProgLangDesc";

            cmbTopic.DataSource = bll.GetTopicModule();
            cmbTopic.ValueMember = "Module Topic ID";
            cmbTopic.DisplayMember = "Topic and Module";
        }


        private void btnError_Click(object sender, EventArgs e)
        {
            action = "errorAdd";

            lblHeading.Text = "Add Error";
            lblSubHeading.Text = "Please enter error details:";
            btnSubmit.Text = "Add";

            txtDesc.Text = "";
            lblLanguage.Show();
            lblTopic.Show();
            cmbProgLang.Show();
            cmbTopic.Show();

            pnlErrorDialog.Show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            action = "errorUpdate";

            lblHeading.Text = "Update Error";
            lblSubHeading.Text = "Please enter error details:";
            btnSubmit.Text = "Update";

            txtDesc.Text = "";
            lblLanguage.Show();
            lblTopic.Show();
            cmbProgLang.Show();
            cmbTopic.Show();

            txtDesc.Text = dgvError.SelectedRows[0].Cells["Error"].Value.ToString();
            cmbProgLang.SelectedIndex = cmbProgLang.FindString(dgvError.SelectedRows[0].Cells["Programming Language"].Value.ToString());
            cmbTopic.SelectedIndex = cmbTopic.FindString(dgvError.Rows[0].Cells["Module and Topic"].Value.ToString());

            pnlErrorDialog.Show();
        }

        private void btnAddSolution_Click(object sender, EventArgs e)
        {
            action = "solutionAdd";

            lblHeading.Text = "Add Solution";
            lblSubHeading.Text = "Please enter solution details:";
            btnSubmit.Text = "Add";

            txtDesc.Text = "";
            lblLanguage.Hide();
            lblTopic.Hide();
            cmbProgLang.Hide();
            cmbTopic.Hide();

            pnlErrorDialog.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "errorAdd":
                    pnlErrorDialog.Hide();

                    Error insertError = new Error(txtDesc.Text, "Pending", int.Parse(dtLogin.Rows[0]["UserID"].ToString()), int.Parse(cmbProgLang.SelectedValue.ToString()), int.Parse(cmbTopic.SelectedValue.ToString()));
                    bll.InsertError(insertError);
                    break;
                case "errorUpdate":
                    pnlErrorDialog.Hide();

                    Error updateError = new Error(int.Parse(dgvError.SelectedRows[0].Cells["Error ID"].Value.ToString()), txtDesc.Text, int.Parse(cmbProgLang.SelectedValue.ToString()), int.Parse(cmbTopic.SelectedValue.ToString()));
                    bll.UpdateError(updateError);
                    break;
                case "solutionAdd":
                    pnlErrorDialog.Hide();

                    SolutionError solutionError = new SolutionError(txtDesc.Text, int.Parse(dtLogin.Rows[0]["UserID"].ToString()), int.Parse(dgvError.SelectedRows[0].Cells["Error ID"].Value.ToString()), DateTime.Today);
                    bll.InsertSolutionError(solutionError);
                    break;
            }

            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (int.Parse(dtLogin.Rows[0]["RoleID"].ToString()))
            {
                case 1:
                    foreach (DataGridViewRow selectedRow in dgvError.SelectedRows)
                    {
                        Error adminError = new Error(int.Parse(selectedRow.Cells["Error ID"].Value.ToString()), dgvError.SelectedRows[0].Cells["Status"].Value.ToString());
                        bll.DeleteError(adminError);
                    }
                    break;
                case 2:
                    foreach (DataGridViewRow selectedRow in dgvError.SelectedRows)
                    {
                        Error lecturerError = new Error(int.Parse(selectedRow.Cells["Error ID"].Value.ToString()), dgvError.SelectedRows[0].Cells["Status"].Value.ToString());
                        bll.DeleteError(lecturerError);
                    }
                    break;
                case 3:
                    Error studentError = new Error(int.Parse(dgvError.SelectedRows[0].Cells["Error ID"].Value.ToString()), dgvError.SelectedRows[0].Cells["Status"].Value.ToString());
                    bll.DeleteError(studentError);
                    break;
            }
            refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlErrorDialog.Hide();
        }

        private void dgvError_SelectionChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(dtLogin.Rows[0]["RoleID"].ToString()))
            {
                case 1:
                    if (dgvError.SelectedRows.Count == 1)
                    {
                        pnlUpdate.Show();
                        pnlDelete.Show();
                        pnlSolution.Show();
                    }
                    else if (dgvError.SelectedRows.Count > 1)
                    {
                        pnlUpdate.Hide();
                        pnlDelete.Show();
                        pnlSolution.Hide();
                    }
                    else if (dgvError.SelectedRows.Count == 0)
                    {
                        pnlUpdate.Hide();
                        pnlDelete.Hide();
                        pnlSolution.Hide();
                    }
                    break;
                case 2:
                    if (dgvError.SelectedRows.Count == 1)
                    {
                        pnlUpdate.Hide();
                        pnlDelete.Show();
                        pnlSolution.Show();
                    }
                    else if (dgvError.SelectedRows.Count > 1)
                    {
                        pnlUpdate.Hide();
                        pnlDelete.Show();
                        pnlSolution.Hide();
                    }
                    else if (dgvError.SelectedRows.Count == 0)
                    {
                        pnlUpdate.Hide();
                        pnlDelete.Hide();
                        pnlSolution.Hide();
                    }
                    break;
                case 3:
                    if (dgvError.SelectedRows.Count == 1)
                    {
                        if (dgvError.SelectedRows[0].Cells["Student"].Value.ToString() == (dtLogin.Rows[0]["Username"].ToString() + " " + dtLogin.Rows[0]["Surname"].ToString()))
                        {
                            pnlUpdate.Show();
                            pnlDelete.Show();
                            pnlSolution.Hide();
                        }
                    }
                    else if (dgvError.SelectedRows.Count == 0)
                    {
                        pnlUpdate.Hide();
                        pnlDelete.Hide();
                        pnlSolution.Hide();
                    }
                    break;
            }
        }

        private void dgvError_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvError.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {   
            (dgvError.DataSource as DataTable).DefaultView.RowFilter = string.Format("Error LIKE '%{0}%'", txtSearch.Text);
        }

        private void cmbViewProgLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViewProgLang.Text != "SELECT")
                (dgvError.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Programming Language] LIKE '%{0}%'", cmbViewProgLang.Text);
            else if (cmbViewProgLang.Text == "SELECT")
                (dgvError.DataSource as DataTable).DefaultView.RowFilter = "";
        }
    }
}