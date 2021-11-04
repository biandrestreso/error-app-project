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
        bool isUpdate;

        private void ucError_Load(object sender, EventArgs e)
        {
            LoadError();
            pnlErrorDialog.Hide();
            pnlUpdateBtn.Hide();
            pnlDeleteBtn.Hide();
        }

        private void LoadError()
        {
            dgvError.DataSource = bll.GetError();
        }

        private void LoadStatus()
        {
            cmbStatus.Items.AddRange(new string[] { "New", "Pending", "Solved" });
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadProgLang()
        {
            cmbProgLang.DataSource = bll.GetProgLang();
            cmbProgLang.ValueMember = "ProgLangID";
            cmbProgLang.DisplayMember = "ProgLangDesc";
        }

        private void LoadTopic()
        {
            cmbTopic.DataSource = bll.GetTopicModule();
            cmbTopic.ValueMember = "Module Topic ID";
            cmbTopic.DisplayMember = "Topic and Module";
        }
        
        private void btnErrorAdd_Click(object sender, EventArgs e)
        {
            isUpdate = false;

            pnlErrorDialog.Show();
            LoadStatus();
            LoadProgLang();
            LoadTopic();
            btnErrorAdd.Click -= btnErrorAdd_Click;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isUpdate = true;

            lblError.Text = "Update Error";
            btnSubmit.Text = "Update";

            pnlErrorDialog.Show();
            btnErrorAdd.Click -= btnErrorAdd_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (isUpdate)
            {
                case false:
                    pnlErrorDialog.Hide();
                    btnErrorAdd.Click += btnErrorAdd_Click;

                    Error error = new Error(txtDesc.Text, cmbStatus.SelectedItem.ToString(), 1, int.Parse(cmbProgLang.SelectedValue.ToString()), int.Parse(cmbTopic.SelectedValue.ToString()));
                    bll.InsertError(error);
                    break;
                case true:
                    pnlErrorDialog.Hide();
                    btnErrorAdd.Click += btnErrorAdd_Click;

                    //Error error = new Error();
                    //bll.UpdateError(error);
                    break;
            }
        }

        private void dgvError_Click(object sender, EventArgs e)
        {
            pnlDeleteBtn.Show();
            pnlUpdateBtn.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}