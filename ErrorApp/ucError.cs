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
        bool selectDone = false;

        string action;

        private void ucError_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            dtLogin = frmLogin.dtLogin;

            resetUC();
            refresh();

            dgvError.ClearSelection();
        }

        public void resetUC() //Reset panels and button events
        {
            pnlErrorDialog.Hide();
            pnlUpdate.Hide();
            pnlDelete.Hide();
            pnlSolution.Hide();

            btnError.Click += btnError_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSolution.Click += btnAddSolution_Click;
        }

        public void refresh()  //Refresh entire usercontrol
        {
            selectDone = false;

            DataTable dtMerge = new DataTable();

            UserModule userModule = new UserModule(int.Parse(dtLogin.Rows[0]["UserID"].ToString()));
            DataTable dtModule = bll.GetUserModule(userModule);

            if (int.Parse(dtLogin.Rows[0]["RoleID"].ToString()) == 1)
            {
                dgvError.DataSource = bll.GetError();

                cmbTopic.DataSource = bll.GetTopicModule();
                cmbTopic.ValueMember = "Module Topic ID";
                cmbTopic.DisplayMember = "Topic and Module";
            }
            else
            {
                foreach (DataRow drow in dtModule.Rows)
                {
                    Module module = new Module(int.Parse(drow["Module ID"].ToString()), null);
                    DataTable dtTemp = bll.GetErrorByModule(module);

                    dtMerge.Merge(dtTemp);
                }

                User user = new User(int.Parse(dtLogin.Rows[0]["UserID"].ToString()));
                cmbTopic.DataSource = bll.GetTopicModuleByUser(user);
                cmbTopic.ValueMember = "Module Topic ID";
                cmbTopic.DisplayMember = "Topic and Module";

                dgvError.DataSource = dtMerge;
            }

            cmbProgLang.DataSource = bll.GetProgLang();
            cmbProgLang.ValueMember = "ProgLangID";
            cmbProgLang.DisplayMember = "ProgLangDesc";

            DataTable dt = bll.GetProgLang();

            DataRow dr = dt.NewRow();
            dr["ProgLangID"] = 0;
            dr["ProgLangDesc"] = "None";

            dt.Rows.InsertAt(dr, 0);

            cmbViewProgLang.DataSource = dt;
            cmbViewProgLang.ValueMember = "ProgLangID";
            cmbViewProgLang.DisplayMember = "ProgLangDesc";

            

            selectDone = true;
            setColumn();
        }

        private void setColumn() //Set column width after data is added
        {
            if (dgvError.Rows.Count > 0)
            {
                dgvError.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnError_Click(object sender, EventArgs e) //Open error add dialog panel
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
            
            btnError.Click -= btnError_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
            btnSolution.Click -= btnAddSolution_Click;
        }

        private void btnUpdate_Click(object sender, EventArgs e) //Open update dialog panel
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

            btnError.Click -= btnError_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
            btnSolution.Click -= btnAddSolution_Click;
        }

        private void btnAddSolution_Click(object sender, EventArgs e) //Open solution dialog panel
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

            btnError.Click -= btnError_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
            btnSolution.Click -= btnAddSolution_Click;
        }

        private void btnSubmit_Click(object sender, EventArgs e) //Add or update items in database based on values
        {
            bool invalid = false;

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                errorError.SetError(txtDesc, "Please enter an error description");
                invalid = true;
            }
            else
            {
                errorError.SetError(txtDesc, "");
                invalid = false;
            }

            if (!invalid)
            {
                switch (action)
                {
                    case "errorAdd":
                        pnlErrorDialog.Hide();

                        Error insertError = new Error(txtDesc.Text, "Pending", DateTime.Today ,int.Parse(dtLogin.Rows[0]["UserID"].ToString()), int.Parse(cmbProgLang.SelectedValue.ToString()), int.Parse(cmbTopic.SelectedValue.ToString()));
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

                pnlErrorDialog.Hide();

                btnError.Click += btnError_Click;
                btnUpdate.Click += btnUpdate_Click;
                btnDelete.Click += btnDelete_Click;
                btnSolution.Click += btnAddSolution_Click;
            }

            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e) //Delete error
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

        private void btnClose_Click(object sender, EventArgs e) //Close dialog menu and reset button events
        {
            pnlErrorDialog.Hide();

            btnError.Click += btnError_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSolution.Click += btnAddSolution_Click;
        }

        private void dgvError_SelectionChanged(object sender, EventArgs e) //Show buttons based on selection
        {
            switch (Convert.ToInt32(dtLogin.Rows[0]["RoleID"].ToString()))
            {
                case 1:
                    if (dgvError.SelectedRows.Count == 1)
                    {
                        pnlUpdate.Show();
                        pnlDelete.Show();
                        if (dgvError.SelectedRows[0].Cells["Status"].Value.ToString() == "Pending")
                            pnlSolution.Show();
                        else
                            pnlSolution.Hide();
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
                        pnlUpdate.Show();
                        pnlDelete.Show();
                        if (dgvError.SelectedRows[0].Cells["Status"].Value.ToString() == "Pending")
                            pnlSolution.Show();
                        else
                            pnlSolution.Hide();
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
                        else
                        {
                            pnlUpdate.Hide();
                            pnlDelete.Hide();
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

        private void dgvError_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //Clear dgv after databinding
        {
            dgvError.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) //Search for errors in dgv
        {   
            (dgvError.DataSource as DataTable).DefaultView.RowFilter = string.Format("Error LIKE '%{0}%'", txtSearch.Text);
        }

        private void cmbViewProgLang_SelectedIndexChanged(object sender, EventArgs e) //Filter by programming language in dgv
        {
            if (selectDone)
            {
                if (cmbViewProgLang.Text != "None")
                    (dgvError.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Programming Language] LIKE '%{0}%'", cmbViewProgLang.Text);
                else if (cmbViewProgLang.Text == "None")
                    (dgvError.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        private void btnFilterDate_Click(object sender, EventArgs e) //Gets errors between entered dates
        {
            Error error = new Error(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvError.DataSource = bll.GetErrorByDate(error);
            setColumn();
        }

        private void btnReset_Click(object sender, EventArgs e) //Resets filtering
        {
            refresh();
        }
    }
}