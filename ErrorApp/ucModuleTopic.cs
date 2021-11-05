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

        public void resetUC()
        {
            pnlModuleTopic.Hide();
            pnlModuleDialog.Hide();
            pnlModuleTopicDialog.Hide();
            pnlUpdate.Hide();
            pnlDelete.Hide();
        }

        public void refresh()
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

        private void setColumnWidth()
        {
            dgvModule.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvModule.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvTopic.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvModuleTopic.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isModule)
            {
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

            pnlModuleDialog.Hide();
            refresh();
        }

        private void btnModuleTopic_Click(object sender, EventArgs e)
        {
            pnlModuleTopic.Show();
            pnlModuleTopic.BringToFront();

            refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlModuleTopic.Hide();
            refresh();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            isModule = true;
            isUpdate = false;

            pnlModuleDialog.Show();
            pnlModuleDialog.BringToFront();

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

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            isModule = false;
            isUpdate = false;

            pnlModuleDialog.Show();
            pnlModuleDialog.BringToFront();

            lblYear.Hide();
            cmbYear.Hide();

            txtDesc.Text = "";

            lblModuleTopic.Text = "Insert Topic";
            lblAddDesc.Text = "Please enter topic details:";
            lblDesc.Text = "Topic Description:";
            btnSubmit.Text = "Add";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvModule.SelectedRows.Count == 1)
            {
                isModule=true;
                isUpdate = true;

                pnlModuleDialog.Show();
                pnlModuleDialog.BringToFront();

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

                lblYear.Hide();
                cmbYear.Hide();

                lblModuleTopic.Text = "Update Topic";
                lblAddDesc.Text = "Please enter topic details:";
                lblDesc.Text = "Topic Description:";
                btnSubmit.Text = "Update";

                txtDesc.Text = dgvTopic.SelectedRows[0].Cells["Topic"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void dgvModule_SelectionChanged(object sender, EventArgs e)
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

        private void dgvTopic_SelectionChanged(object sender, EventArgs e)
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

        private void dgvModule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvModule.ClearSelection();
        }

        private void dgvTopic_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTopic.ClearSelection();
        }

        //ModuleTopicPanel

        private void btnAddTopicModule_Click(object sender, EventArgs e)
        {
            isUpdate = false;

            pnlModuleTopicDialog.Show();
            pnlModuleTopicDialog.BringToFront();

            lblModuleTopicHeading.Text = "Add Topic to Module";
            lblModuleTopicDesc.Text = "Select topic to add to module";
            btnSubmitModuleTopic.Text = "Add";

        }

        private void btnUpdateModuleTopic_Click(object sender, EventArgs e)
        {
            isUpdate = true;

            pnlModuleTopicDialog.Show();
            pnlModuleTopicDialog.BringToFront();

            cmbModule.Enabled = false;
            cmbModule.SelectedIndex = cmbModule.FindString(dgvModuleTopic.SelectedRows[0].Cells["Module and Topic"].Value.ToString().Split(' ')[0]);
            
            lblModuleTopicHeading.Text = "Update Topic";
            lblModuleTopicDesc.Text = "Select new topic";
            btnSubmitModuleTopic.Text = "Update";
        }

        private void btnDeleteModuleTopic_Click(object sender, EventArgs e)
        {
            isUpdate = false;

            foreach (DataGridViewRow selectedRow in dgvModuleTopic.SelectedRows)
            {
                ModuleTopic moduleTopic = new ModuleTopic(int.Parse(selectedRow.Cells["Module Topic ID"].Value.ToString()));
                bll.DeleteModuleTopic(moduleTopic);
            }

            refresh();
        }

        private void btnSubmitModuleTopic_Click(object sender, EventArgs e)
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

            pnlModuleTopicDialog.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlModuleDialog.Hide();
        }

        private void dgvModuleTopic_SelectionChanged(object sender, EventArgs e)
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
        }
    }
}