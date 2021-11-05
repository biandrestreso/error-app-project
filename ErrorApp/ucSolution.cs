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

        private void ucSolution_Load(object sender, EventArgs e)
        {
            refresh();
            resetUC();

            dgvSolution.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSolution.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void refresh()
        {
            dgvSolution.DataSource = bll.GetSolutionError();
        }

        public void resetUC()
        {
            pnlDelete.Hide();
            pnlUpdate.Hide();

            pnlSolutionDialog.Hide();
            refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlSolutionDialog.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDesc.Text = dgvSolution.SelectedRows[0].Cells["Solution"].Value.ToString();

            pnlSolutionDialog.Show();
            pnlSolutionDialog.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SolutionError solutionError = new SolutionError(int.Parse(dgvSolution.SelectedRows[0].Cells["Solution ID"].Value.ToString()));
            bll.DeleteSolution(solutionError);

            refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SolutionError solutionError = new SolutionError(int.Parse(dgvSolution.SelectedRows[0].Cells["Solution ID"].Value.ToString()), txtDesc.Text);
            bll.UpdateSolution(solutionError);

            pnlSolutionDialog.Hide();
            refresh();
        }

        private void dgvSolution_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSolution.ClearSelection();
        }

        private void dgvSolution_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolution.SelectedRows.Count == 1)
            {
                pnlUpdate.Show();
                pnlDelete.Show();
            }
            else
            {
                pnlUpdate.Hide();
                pnlDelete.Hide();
            }
        }
    }
}
