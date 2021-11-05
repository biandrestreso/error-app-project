using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using BLL;

namespace ErrorApp
{
    public partial class ucModuleTopic : UserControl
    {
        public ucModuleTopic()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        bool isModule;
        bool isUpdate;
        
        private void ucModuleTopic_Load(object sender, EventArgs e)
        {
            resetUC();
            refresh();

            setColumnWidth();
        }

        public void resetUC() //Reset entire usercontrol
        {
            pnlModuleTopic.Hide();
            pnlModuleDialog.Hide();
            pnlModuleTopicDialog.Hide();
            pnlUpdate.Hide();
            pnlDelete.Hide();
            pnlUpdateModuleTopic.Hide();
            pnlDeleteModuleTopic.Hide();

            btnAddModule.Click += btnAddModule_Click;
            btnAddTopic.Click += btnAddTopic_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdateModuleTopic.Click += btnUpdateModuleTopic_Click;
            btnDelete.Click += btnDelete_Click;
            btnDeleteModuleTopic.Click += btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click += btnAddTopicModule_Click;
            btnModuleTopic.Click += btnModuleTopic_Click;
            btnBack.Click += btnBack_Click;
        }

        public void refresh() //Refresh dgv and cmb's
        {
            dgvTopic.DataSource = bll.GetTopic();
            dgvModule.DataSource = bll.GetModule();
            dgvModuleTopic.DataSource = bll.GetModuleTopic();

            cmbYear.DataSource = bll.GetYear();
            cmbYear.ValueMember = "YearID";
            cmbYear.DisplayMember = "YearDesc";

            cmbModule.DataSource = bll.GetModule();
            cmbModule.ValueMember = "Module ID";
            cmbModule.DisplayMember = "Module";

            cmbTopic.DataSource = bll.GetTopic();
            cmbTopic.ValueMember = "Topic ID";
            cmbTopic.DisplayMember = "Topic";
        }

        private void setColumnWidth() //Set column width after databinding
        {
            dgvModule.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvModule.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvTopic.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvModuleTopic.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSubmit_Click(object sender, EventArgs e) //Run sql queries and validate input
        {
            if (isModule)
            {
                if (string.IsNullOrWhiteSpace(txtDesc.Text) || (!Regex.IsMatch(txtDesc.Text, @"^[A-Za-z]{3,4}\d{4}$")))
                    errorModule.SetError(txtDesc, "Please enter a valid Module Code (3 to 4 letters and 4 numbers");
                else
                {
                    errorModule.SetError(txtDesc, "");

                    switch (isUpdate)
                    {
                        case true:
                            Module updateModule = new Module(int.Parse(dgvModule.SelectedRows[0].Cells["Module ID"].Value.ToString()), txtDesc.Text, int.Parse(cmbYear.SelectedValue.ToString()));
                            bll.UpdateModule(updateModule);
                            break;
                        case false:
                            Module insertModule = new Module(txtDesc.Text, int.Parse(cmbYear.SelectedValue.ToString()));
                            bll.InsertModule(insertModule);
                            break;
                    }
                }
            }
            else if (!isModule)
            {
                switch (isUpdate)
                {
                    case true:
                        Topic updateTopic = new Topic(int.Parse(dgvTopic.SelectedRows[0].Cells["Topic ID"].Value.ToString()), txtDesc.Text);
                        bll.UpdateTopic(updateTopic);
                        break;
                    case false:
                        Topic insertTopic = new Topic(txtDesc.Text);
                        bll.InsertTopic(insertTopic);
                        break;
                }
            }

            btnAddModule.Click += btnAddModule_Click;
            btnAddTopic.Click += btnAddTopic_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdateModuleTopic.Click += btnUpdateModuleTopic_Click;
            btnDelete.Click += btnDelete_Click;
            btnDeleteModuleTopic.Click += btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click += btnAddTopicModule_Click;
            btnModuleTopic.Click += btnModuleTopic_Click;
            btnBack.Click += btnBack_Click;

            pnlModuleDialog.Hide();
            refresh();
        }

        private void btnModuleTopic_Click(object sender, EventArgs e) //Open module topic combination panel
        {
            pnlModuleTopic.Show();
            pnlModuleTopic.BringToFront();

            refresh();
        }

        private void btnBack_Click(object sender, EventArgs e) //Opens module and topic panel
        {
            pnlModuleTopic.Hide();
            refresh();
        }

        private void btnAddModule_Click(object sender, EventArgs e) //Open add module dialog
        {
            isModule = true;
            isUpdate = false;

            pnlModuleDialog.Show();
            pnlModuleDialog.BringToFront();

            btnAddModule.Click -= btnAddModule_Click;
            btnAddTopic.Click -= btnAddTopic_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnUpdateModuleTopic.Click -= btnUpdateModuleTopic_Click;
            btnDelete.Click -= btnDelete_Click;
            btnDeleteModuleTopic.Click -= btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click -= btnAddTopicModule_Click;
            btnModuleTopic.Click -= btnModuleTopic_Click;
            btnBack.Click -= btnBack_Click;

            lblYear.Show();
            cmbYear.Show();

            txtDesc.Text = "";

            if (cmbYear.Items.Count > 0)
                cmbYear.SelectedIndex = 0;

            lblModuleTopic.Text = "Insert Module";
            lblAddDesc.Text = "Please enter module details:";
            lblDesc.Text = "Module Description:";
            btnSubmit.Text = "Add";
        }

        private void btnAddTopic_Click(object sender, EventArgs e) //Opens add Topic dialog
        {
            isModule = false;
            isUpdate = false;

            pnlModuleDialog.Show();
            pnlModuleDialog.BringToFront();

            btnAddModule.Click -= btnAddModule_Click;
            btnAddTopic.Click -= btnAddTopic_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnUpdateModuleTopic.Click -= btnUpdateModuleTopic_Click;
            btnDelete.Click -= btnDelete_Click;
            btnDeleteModuleTopic.Click -= btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click -= btnAddTopicModule_Click;
            btnModuleTopic.Click -= btnModuleTopic_Click;
            btnBack.Click -= btnBack_Click;

            lblYear.Hide();
            cmbYear.Hide();

            txtDesc.Text = "";

            lblModuleTopic.Text = "Insert Topic";
            lblAddDesc.Text = "Please enter topic details:";
            lblDesc.Text = "Topic Description:";
            btnSubmit.Text = "Add";
        }

        private void btnUpdate_Click(object sender, EventArgs e) //Opens update dialog
        {
            if (dgvModule.SelectedRows.Count == 1)
            {
                isModule=true;
                isUpdate = true;

                pnlModuleDialog.Show();
                pnlModuleDialog.BringToFront();

                btnAddModule.Click -= btnAddModule_Click;
                btnAddTopic.Click -= btnAddTopic_Click;
                btnUpdate.Click -= btnUpdate_Click;
                btnUpdateModuleTopic.Click -= btnUpdateModuleTopic_Click;
                btnDelete.Click -= btnDelete_Click;
                btnDeleteModuleTopic.Click -= btnDeleteModuleTopic_Click;
                btnAddModuleTopic.Click -= btnAddTopicModule_Click;
                btnModuleTopic.Click -= btnModuleTopic_Click;
                btnBack.Click -= btnBack_Click;

                lblYear.Show();
                cmbYear.Show();

                lblModuleTopic.Text = "Update Module";
                lblAddDesc.Text = "Please enter module details:";
                lblDesc.Text = "Module Description:";
                btnSubmit.Text = "Update";

                txtDesc.Text = dgvModule.SelectedRows[0].Cells["Module"].Value.ToString();
                cmbYear.SelectedIndex = cmbYear.FindString(dgvModule.SelectedRows[0].Cells["Year"].Value.ToString());
            }
            else if (dgvTopic.SelectedRows.Count == 1)
            {
                isModule = false;
                isUpdate = true;

                pnlModuleDialog.Show();
                pnlModuleDialog.BringToFront();

                btnAddModule.Click -= btnAddModule_Click;
                btnAddTopic.Click -= btnAddTopic_Click;
                btnUpdate.Click -= btnUpdate_Click;
                btnUpdateModuleTopic.Click -= btnUpdateModuleTopic_Click;
                btnDelete.Click -= btnDelete_Click;
                btnDeleteModuleTopic.Click -= btnDeleteModuleTopic_Click;
                btnAddModuleTopic.Click -= btnAddTopicModule_Click;
                btnModuleTopic.Click -= btnModuleTopic_Click;
                btnBack.Click -= btnBack_Click;

                lblYear.Hide();
                cmbYear.Hide();

                lblModuleTopic.Text = "Update Topic";
                lblAddDesc.Text = "Please enter topic details:";
                lblDesc.Text = "Topic Description:";
                btnSubmit.Text = "Update";

                txtDesc.Text = dgvTopic.SelectedRows[0].Cells["Topic"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //Deletes selected topics or modules
        {
            if (dgvModule.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvModule.SelectedRows)
                {
                    Module module = new Module(int.Parse(selectedRow.Cells["Module ID"].Value.ToString()), null);
                    bll.DeleteModule(module);
                }
            }
            else if (dgvTopic.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvTopic.SelectedRows)
                {
                    Topic topic = new Topic(int.Parse(selectedRow.Cells["Topic ID"].Value.ToString()));
                    bll.DeleteTopic(topic);
                }
            }

            refresh();
        }

        private void dgvModule_SelectionChanged(object sender, EventArgs e) //Shows buttons based on selection
        {
            if (dgvModule.SelectedRows.Count == 1)
            {
                dgvTopic.ClearSelection();

                pnlUpdate.Show();
                pnlDelete.Show();
            }
            else if (dgvModule.SelectedRows.Count > 1)
            {
                dgvTopic.ClearSelection();

                pnlUpdate.Hide();
                pnlDelete.Show();
            }
            else if (dgvModule.SelectedRows.Count == 0)
            {
                pnlUpdate.Hide();
                pnlDelete.Hide();
            }
        }

        private void dgvTopic_SelectionChanged(object sender, EventArgs e) //Shows buttons based on selection
        {
            if (dgvTopic.SelectedRows.Count == 1)
            {
                dgvModule.ClearSelection();

                pnlUpdate.Show();
                pnlDelete.Show();
            }
            else if (dgvTopic.SelectedRows.Count > 1)
            {
                dgvModule.ClearSelection();

                pnlUpdate.Hide();
                pnlDelete.Show();
            }
            else if (dgvTopic.SelectedRows.Count == 0)
            {
                pnlUpdate.Hide();
                pnlDelete.Hide();
            }
        }

        private void dgvModule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //Clear selection after databinding
        {
            dgvModule.ClearSelection();
        }

        private void dgvTopic_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //Clear selection after databinding
        {
            dgvTopic.ClearSelection();
        }

        private void btnAddTopicModule_Click(object sender, EventArgs e) //Opens add topic to module dialog
        {
            isUpdate = false;

            pnlModuleTopicDialog.Show();
            pnlModuleTopicDialog.BringToFront();

            btnAddModule.Click -= btnAddModule_Click;
            btnAddTopic.Click -= btnAddTopic_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnUpdateModuleTopic.Click -= btnUpdateModuleTopic_Click;
            btnDelete.Click -= btnDelete_Click;
            btnDeleteModuleTopic.Click -= btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click -= btnAddTopicModule_Click;
            btnModuleTopic.Click -= btnModuleTopic_Click;
            btnBack.Click -= btnBack_Click;

            lblModuleTopicHeading.Text = "Add Topic to Module";
            lblModuleTopicDesc.Text = "Select topic to add to module";
            btnSubmitModuleTopic.Text = "Add";
        }

        private void btnUpdateModuleTopic_Click(object sender, EventArgs e) //Opens update dialog for module and topic
        {
            isUpdate = true;

            pnlModuleTopicDialog.Show();
            pnlModuleTopicDialog.BringToFront();

            btnAddModule.Click -= btnAddModule_Click;
            btnAddTopic.Click -= btnAddTopic_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnUpdateModuleTopic.Click -= btnUpdateModuleTopic_Click;
            btnDelete.Click -= btnDelete_Click;
            btnDeleteModuleTopic.Click -= btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click -= btnAddTopicModule_Click;
            btnModuleTopic.Click -= btnModuleTopic_Click;
            btnBack.Click -= btnBack_Click;

            cmbModule.Enabled = false;
            cmbModule.SelectedIndex = cmbModule.FindString(dgvModuleTopic.SelectedRows[0].Cells["Module and Topic"].Value.ToString().Split(' ')[0]);
            
            lblModuleTopicHeading.Text = "Update Topic";
            lblModuleTopicDesc.Text = "Select new topic";
            btnSubmitModuleTopic.Text = "Update";
        }

        private void btnDeleteModuleTopic_Click(object sender, EventArgs e) //Delete module and topic
        {
            isUpdate = false;

            foreach (DataGridViewRow selectedRow in dgvModuleTopic.SelectedRows)
            {
                ModuleTopic moduleTopic = new ModuleTopic(int.Parse(selectedRow.Cells["Module Topic ID"].Value.ToString()));
                bll.DeleteModuleTopic(moduleTopic);
            }

            refresh();
        }

        private void btnSubmitModuleTopic_Click(object sender, EventArgs e) //Combine module and topic
        {
            switch (isUpdate)
            {
                case true:
                    break;
                case false:
                    ModuleTopic moduleTopic = new ModuleTopic(int.Parse(cmbModule.SelectedValue.ToString()), int.Parse(cmbTopic.SelectedValue.ToString()));
                    bll.InsertModuleTopic(moduleTopic);
                    break;
            }

            btnAddModule.Click += btnAddModule_Click;
            btnAddTopic.Click += btnAddTopic_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdateModuleTopic.Click += btnUpdateModuleTopic_Click;
            btnDelete.Click += btnDelete_Click;
            btnDeleteModuleTopic.Click += btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click += btnAddTopicModule_Click;
            btnModuleTopic.Click += btnModuleTopic_Click;
            btnBack.Click += btnBack_Click;

            refresh();
            pnlModuleTopicDialog.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e) //Close module topic dialog
        {
            pnlModuleDialog.Hide();

            btnAddModule.Click += btnAddModule_Click;
            btnAddTopic.Click += btnAddTopic_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdateModuleTopic.Click += btnUpdateModuleTopic_Click;
            btnDelete.Click += btnDelete_Click;
            btnDeleteModuleTopic.Click += btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click += btnAddTopicModule_Click;
            btnModuleTopic.Click += btnModuleTopic_Click;
            btnBack.Click += btnBack_Click;
        }

        private void dgvModuleTopic_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvModuleTopic.SelectedRows.Count == 1)
            {
                pnlUpdateModuleTopic.Show();
                pnlDeleteModuleTopic.Show();
            }
            else if (dgvModuleTopic.SelectedRows.Count > 1)
            {
                pnlUpdateModuleTopic.Hide();
                pnlDeleteModuleTopic.Show();
            }
            else if (dgvModuleTopic.SelectedRows.Count == 0)
            {
                pnlUpdateModuleTopic.Hide();
                pnlDeleteModuleTopic.Hide();
            }
        }

        private void btnCloseModuleTopic_Click(object sender, EventArgs e)
        {
            pnlModuleTopicDialog.Hide();

            btnAddModule.Click += btnAddModule_Click;
            btnAddTopic.Click += btnAddTopic_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdateModuleTopic.Click += btnUpdateModuleTopic_Click;
            btnDelete.Click += btnDelete_Click;
            btnDeleteModuleTopic.Click += btnDeleteModuleTopic_Click;
            btnAddModuleTopic.Click += btnAddTopicModule_Click;
            btnModuleTopic.Click += btnModuleTopic_Click;
            btnBack.Click += btnBack_Click;
        }

        private void dgvModuleTopic_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //Clear selection after databinding
        {
            dgvModuleTopic.ClearSelection();
        }
    }
}