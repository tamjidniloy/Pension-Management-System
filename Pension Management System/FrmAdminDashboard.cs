using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pension_Management_System
{
    public partial class FrmAdminDashboard : Form
    {
        public FrmAdminDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_page loginPage = new Login_page();
            loginPage.Show();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee_Management manageEmployeeForm = new Employee_Management();
            manageEmployeeForm.Show();
        }

        private void btnManagePensionar_Click(object sender, EventArgs e)
        {
            this.Close();
            Pensioner_Management managePensionarForm = new Pensioner_Management();
            managePensionarForm.Show();
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            this.Close();
            Pensioner_Accounts manageAccountsForm = new Pensioner_Accounts();
            manageAccountsForm.Show();
        }

        private void btnManagePayment_Click(object sender, EventArgs e)
        {
            Monthly_Pension_Process frm = new Monthly_Pension_Process(this);
            this.Hide();
            frm.Show();
        }

        private void btnManageWithdraw_Click(object sender, EventArgs e)
        {
            Pension_Withdrawal frm = new Pension_Withdrawal(this);
            this.Hide();
            frm.Show();
        }
    }
}
