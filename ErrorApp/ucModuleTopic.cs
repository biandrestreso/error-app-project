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
        bool selectModule;
        bool selectTopic;
        
        private void ucModuleTopic_Load(object sender, EventArgs e)
        {
            pnlModuleTopic.Hide();
            pnlModuleDialog.Hide();
            pnlModuleTopicDialog.Hide();
            pnlUpdateBtn.Hide();
            pnlDeleteBtn.Hide();

            LoadYear();
            LoadModule();
            LoadTopic();
            LoadModuleTopic();
        }

        private void RefreshDGV()
        {
            dgvTopic.DataSource = bll.GetTopic();
            dgvModule.DataSource = bll.GetModule();
            dgvModuleTopic.DataSource = bll.GetModuleTopic();
        }

        private void LoadYear()
        {
            cmbYear.DataSource = bll.GetYear();
            cmbYear.ValueMember = "YearID";
            cmbYear.DisplayMember = "YearDesc";
        }

        private void LoadModule()
        {
            DataTable dt = bll.GetModule();

            dgvModule.DataSource = dt;

            cmbModule.DataSource = dt;
            cmbModule.ValueMember = "Module ID";
            cmbModule.DisplayMember = "Module";
        }

        private void LoadTopic()
        {
            DataTable dt = bll.GetTopic();

            dgvTopic.DataSource = dt;

            cmbTopic.DataSource = dt;
            cmbTopic.ValueMember = "Topic ID";
            cmbTopic.DisplayMember = "Topic";
        }

        private void LoadModuleTopic()
        {
            dgvModuleTopic.DataSource = bll.GetModuleTopic();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isModule)
            {
                switch (isUpdate)
                {
                    case true:
                        break;
                    case false:
                        Module module = new Module(txtDesc.Text, int.Parse(cmbYear.SelectedValue.ToString()));
                        bll.InsertModule(module);
                        break;
                }
            }
            else if (!isModule)
            {
                switch (isUpdate)
                {
                    case true:
                        break;
                    case false:
                        Topic topic = new Topic(txtDesc.Text);
                        bll.InsertTopic(topic);
                        break;
                }
            }

            pnlModuleDialog.Hide();
        }

        private void btnModuleTopic_Click(object sender, EventArgs e)
        {
            pnlModuleTopic.Show();
            pnlModuleTopic.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlModuleTopic.Hide();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            isModule = true;
            isUpdate = false;

            pnlModuleDialog.Show();
            pnlModuleDialog.BringToFront();

            lblYear.Show();
            cmbYear.Show();

            lblModuleTopic.Text = "Insert Module";
            lblAddDesc.Text = "Please enter module details:";
            lblDesc.Text = "Module Description:";
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            isModule = false;
            isUpdate = false;

            pnlModuleDialog.Show();
            pnlModuleDialog.BringToFront();

            lblYear.Hide();
            cmbYear.Hide();

            lblModuleTopic.Text = "Insert Topic";
            lblAddDesc.Text = "Please enter topic details:";
            lblDesc.Text = "Topic Description:";
        }

        private void dgvModule_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModule.SelectedRows.Count == 1)
            {
                dgvTopic.ClearSelection();

                pnlUpdateBtn.Show();
                pnlDeleteBtn.Show();

                selectModule = true;
                selectTopic = false;
            }
            else if (dgvModule.SelectedRows.Count > 1)
            {
                dgvTopic.ClearSelection();

                pnlUpdateBtn.Hide();
                pnlDeleteBtn.Show();

                selectModule = true;
                selectTopic = false;
            }
            else if (dgvModule.SelectedRows.Count == 0)
            {
                pnlUpdateBtn.Hide();
                pnlDeleteBtn.Hide();
            }
        }

        private void dgvTopic_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTopic.SelectedRows.Count == 1)
            {
                dgvModule.ClearSelection();

                pnlUpdateBtn.Show();
                pnlDeleteBtn.Show();

                selectModule = false;
                selectTopic = true;
            }
            else if (dgvTopic.SelectedRows.Count > 1)
            {
                dgvModule.ClearSelection();

                pnlUpdateBtn.Hide();
                pnlDeleteBtn.Show();

                selectModule = false;
                selectTopic = true;
            }
            else if (dgvTopic.SelectedRows.Count == 0)
            {
                pnlUpdateBtn.Hide();
                pnlDeleteBtn.Hide();
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

        private void btnUpdateModuleTopic_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteModuleTopic_Click(object sender, EventArgs e)
        {

        }
    }
}