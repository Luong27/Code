using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class AdminForm : Form
    {
        int employeeId;
        string authorityLevel;
        public AdminForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }
        private void btnManageEmployee_Click(Object sender, EventArgs e)
        {
            ManageEmployee_Form manageEmployee = new ManageEmployee_Form(this.authorityLevel, this.employeeId);
            this.Hide();
            manageEmployee.Show();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
              
        }
        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct_form manageProduct_Form = new ManageProduct_form(this.authorityLevel, this.employeeId);
            this.Hide();
            manageProduct_Form.Show();
        }
        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer(authorityLevel, employeeId);
            this.Hide();
            manageCustomer.Show();
        }
        private void sqlDataAdapter1_RowUpdated(object sender, Microsoft.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnManageImport_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStatistic_Click(object sender, EventArgs e)
        {

        }
    }
}
