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

        private void ucAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlAddUser.Show();
            LoadYear();
        }

        private void LoadYear()
        {
            //if admin don't load
            cmbYear.DataSource = bll.GetYear();
            cmbYear.ValueMember = "YearID";
            cmbYear.DisplayMember = "YearDesc";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User(txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, 1);
            //int.Parse(cmbRole.SelectedValue.ToString())
            int id = bll.InsertUser(user);
            
            for (int i = 0; i < clbModules.CheckedItems.Count; i++)
            {
                DataRow dr = ((DataRowView)clbModules.CheckedItems[i]).Row;
                string value = (dr[this.clbModules.ValueMember]).ToString();
                UserModule userModule = new UserModule(id, int.Parse(value));
                bll.InsertUserModule(userModule);
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cmbYear.SelectedValue.ToString(), out int year);

            Module module = new Module(year);
            DataTable dt = bll.GetModuleByYear(module);
            //Uncheck all after year change

            clbModules.DataSource = dt;
            clbModules.ValueMember = "ModuleID";
            clbModules.DisplayMember = "ModuleDesc";
            //clbModules.SelectedIndex = -1;
        }
    }
}
