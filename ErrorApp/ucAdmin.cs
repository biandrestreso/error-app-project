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
using System.Configuration;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ErrorApp
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        bool isUpdate;
        bool importDone;

        private void ucAdmin_Load(object sender, EventArgs e)
        {
            pnlUserDialog.Hide();
            refresh();

            dgvUser.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void refresh() //Refresh everything on usercontrol
        {
            cmbRole.DataSource = bll.GetRole();
            cmbRole.ValueMember = "RoleID";
            cmbRole.DisplayMember = "RoleDescription";

            clbModules.DataSource = bll.GetModuleAndYear();
            clbModules.ValueMember = "Module ID";
            clbModules.DisplayMember = "Module";

            dgvUser.DataSource = bll.GetUser();

            DataTable dt = bll.CountUsers();
            if (dt.Rows.Count > 0)
                lblTotalUsers.Text = dt.Rows[0][0].ToString();
            else
                lblTotalUsers.Text = "No Users";
        }

        public void resetUC() //Hide dialog if it was open when switching pages
        {
            pnlUserDialog.Hide();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnAdd_Click(object sender, EventArgs e) //Open insert dialog
        {
            isUpdate = false;
            importDone = false;

            pnlUserDialog.Show();
            clbModules.Show();

            btnAdd.Click -= btnAdd_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;

            lblAdminDialog.Text = "Add User";

            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e) //Open update dialog and get current modules of user
        {
            isUpdate = true;
            importDone = false;

            pnlUserDialog.Show();
            clbModules.Show();

            btnAdd.Click -= btnAdd_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;

            lblAdminDialog.Text = "Update User";

            txtName.Text = dgvUser.SelectedRows[0].Cells["Name"].Value.ToString();
            txtSurname.Text = dgvUser.SelectedRows[0].Cells["Surname"].Value.ToString();
            txtEmail.Text = dgvUser.SelectedRows[0].Cells["Email"].Value.ToString();
            cmbRole.SelectedIndex = cmbRole.FindString(dgvUser.SelectedRows[0].Cells["Role"].Value.ToString());

            UserModule userModule = new UserModule(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()));
            DataTable dt = bll.GetUserModule(userModule);

            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < clbModules.Items.Count; i++)
                {
                    DataRow row = ((DataRowView)clbModules.Items[i]).Row;
                    string value = (row[this.clbModules.ValueMember]).ToString();
                    if (value == dr["Module ID"].ToString())
                    {
                        clbModules.SetItemChecked(i, true);
                    }
                }
            }

            importDone = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) //Delete user solutions and errors before deleting user
        {
            double placeholder = 0;

            try
            {
                if (dgvUser.SelectedRows[0].Cells["Role"].Value.ToString() == "Student")
                {
                    User user = new User(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()));
                    DataTable dt = bll.GetLecturerByStudentError(user);

                    foreach (DataRow dr in dt.Rows)
                    {
                        user = new User(int.Parse(dr["LecturerID"].ToString()));
                        bll.DeleteSolutionByLecturer(user);
                    }

                    Error error = new Error(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()), placeholder);
                    bll.DeleteUserError(error);

                    user = new User(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()));
                    bll.DeleteUser(user);
                }
                else if (dgvUser.SelectedRows[0].Cells["Role"].Value.ToString() == "Lecturer")
                {
                    User user = new User(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()));
                    DataTable dt = bll.GetLecturerSolutions(user);

                    foreach (DataRow dr in dt.Rows)
                    {
                        SolutionError solutionError = new SolutionError(int.Parse(dr["SolutionID"].ToString()));
                        bll.SetErrorPending(solutionError);
                    }

                    user = new User(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()));
                    bll.DeleteUser(user);
                }
                else
                {
                    User user = new User(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()));
                    bll.DeleteUser(user);
                }
            }
            catch
            {

            }

            refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e) //Validates and inserts or updates based on input
        {
            bool invalid = false;
            DataTable dt = (DataTable)dgvUser.DataSource;

            foreach (DataRow dr in dt.Rows)
            {
                if (txtEmail.Text.ToUpper() == dr["Email"].ToString().ToUpper())
                {
                    errorAdmin.SetError(txtEmail, "Please enter a new Email");
                    invalid = true;
                }
                else if (txtName.Text.ToUpper() == dr["Name"].ToString().ToUpper() && txtSurname.Text.ToUpper() == dr["Surname"].ToString().ToUpper())
                {
                    errorAdmin.SetError(txtName, "This user already exists");
                    errorAdmin.SetError(txtSurname, "This user already exists");
                    invalid = true;
                }
            }


            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorAdmin.SetError(txtName, "Please enter a name");
                invalid = true;
            }
            else
            {
                errorAdmin.SetError(txtName, "");
                invalid = false;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorAdmin.SetError(txtSurname, "Please enter a surname");
                invalid = true;
            }
            else
            {
                errorAdmin.SetError(txtSurname, "");
                invalid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorAdmin.SetError(txtEmail, "Please enter an email");
                invalid = true;
            }
            else
            {
                errorAdmin.SetError(txtEmail, "");
                invalid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorAdmin.SetError(txtPassword, "Please enter a password");
                invalid = true;
            }
            else
            {
                errorAdmin.SetError(txtPassword, "");
                invalid = false;
            }
                
            if (txtPassword.Text.Length < 8)
            {
                errorAdmin.SetError(txtPassword, "Password must be at least 8 characters in length");
                invalid = true;
            }
            else
            {
                errorAdmin.SetError(txtPassword, "");
                invalid = false;
            }
            
            if (!invalid)
            {
                switch (isUpdate)
                {
                    case true:
                        User updateUser = new User(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()), txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, int.Parse(cmbRole.SelectedValue.ToString()));
                        bll.UpdateUser(updateUser);
                        break;
                    case false:
                        if (cmbRole.SelectedValue.ToString() == "1")
                        {
                            User user = new User(txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, 1);
                            bll.InsertUser(user);
                        }
                        else
                        {
                            User user = new User(txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, int.Parse(cmbRole.SelectedValue.ToString()));
                            int id = bll.InsertUser(user);

                            for (int i = 0; i < clbModules.CheckedItems.Count; i++)
                            {
                                DataRow dr = ((DataRowView)clbModules.CheckedItems[i]).Row;
                                string value = (dr[this.clbModules.ValueMember]).ToString();
                                UserModule userModule = new UserModule(id, int.Parse(value));
                                bll.InsertUserModule(userModule);
                            }
                        }
                        break;
                }

                btnAdd.Click += btnAdd_Click;
                btnUpdate.Click += btnUpdate_Click;
                btnDelete.Click += btnDelete_Click;

                pnlUserDialog.Hide();
                refresh();
            }

            importDone = false;
        }

        private void dgvUser_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //Clear selection after dgv is bound to data
        {
            dgvUser.ClearSelection();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) //Only allow students and lecturers to receive modules
        {
            if (cmbRole.SelectedValue.ToString() == "1")
            {
                clbModules.Enabled = false;
                for (int i = 0; i < clbModules.Items.Count; i++)
                {
                    clbModules.SetItemChecked(i, false);
                }
            }
            else
            {
                clbModules.Enabled = true;
            }
        }

        private void clbModules_ItemCheck(object sender, ItemCheckEventArgs e) //If it is an update then add modules as ticked or delete module if unticked
        {
            if (importDone)
            {
                DataRow dr = ((DataRowView)clbModules.Items[e.Index]).Row;
                UserModule userModule = new UserModule(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()), int.Parse((dr[this.clbModules.ValueMember]).ToString()));

                if (e.NewValue == CheckState.Checked)
                {
                    bll.InsertUserModule(userModule);
                }
                else
                {
                    bll.DeleteUserModule(userModule);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) //Close dialog panel
        {
            pnlUserDialog.Hide();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e) //Show buttons based on dgv selection
        {
            if (dgvUser.SelectedRows.Count == 1)
            {
                btnUpdate.Show();
                btnDelete.Show();
            }
            else
            {
                btnUpdate.Hide();
                btnDelete.Hide();
            }
        }
    }
}