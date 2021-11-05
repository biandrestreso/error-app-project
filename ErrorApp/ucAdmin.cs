﻿using System;
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

        public void refresh()
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

        public void resetUC()
        {
            pnlUserDialog.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            importDone = false;

            pnlUserDialog.Show();
            clbModules.Show();

            lblAdminDialog.Text = "Add User";

            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            importDone = false;

            pnlUserDialog.Show();
            clbModules.Show();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            double placeholder = 0;

            SolutionError solutionError = new SolutionError(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()), placeholder);
            bll.DeleteUserSolution(solutionError);

            Error error = new Error(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()), placeholder);
            bll.DeleteUserError(error);

            User user = new User(int.Parse(dgvUser.SelectedRows[0].Cells["User ID"].Value.ToString()));
            bll.DeleteUser(user);

            refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

                pnlUserDialog.Hide();
                refresh();
            }
            importDone = false;
        }

        private void dgvUser_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUser.ClearSelection();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
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

        private void clbModules_ItemCheck(object sender, ItemCheckEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlUserDialog.Hide();
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
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