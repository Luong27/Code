using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem.ToString();
            bool isValid = ValidateData(username, password, role);
            if (isValid) 
            {
                SqlConnection connection = DatabaseConection.GetConnection();
                if (connection != null)
                {
                    string query = "SELECT Staff_ID, Passwordchange FROM Staff WHERE Username = @username " +
                                   "AND Password = @password AND AuthorityLevel = @role";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("role", role);
                    SqlDataReader reader = command.ExecuteReader();
                    int Staff_Id = 0;
                    bool Passwordchanged = false;
                    while (reader.Read())
                    {
                        Staff_Id = reader.GetInt32(reader.GetOrdinal("Staff_ID"));
                        Passwordchanged = reader.GetBoolean(reader.GetOrdinal("Passwordchange"));
                    }
                    if (Staff_Id > 0)
                    {
                        MessageBox.Show(
                            "Login success",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        RedirectPage(role, Staff_Id);
                    }
                    else 
                    {
                        MessageBox.Show(
                            "Invalid login credential",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        ClearData();
                    }
                    connection.Close();
                }
            }
        }

        private void ClearData()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbRole.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void InitializeCombobox()
        {
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Warehouse Manager");
            cbRole.Items.Add("Sale");
            cbRole.SelectedIndex = 0;
        }
        private bool ValidateData(string username, string password, string role)
        {
            bool isValid = true;
            if (username == null || username == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtUsername.Focus();
            }
            else if (password == null || password == string.Empty) 
            {
                MessageBox.Show(
                    "Password cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtPassword.Focus();
            }
            else if (role == null || role == string.Empty)
            {
                MessageBox.Show(
                    "No role selected",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                cbRole.Focus();
            }
            return isValid;
        }
        private void RedirectPage(string selectedRole, int Staff_Id)
        {
            if (selectedRole != null) 
            {
                    if (selectedRole == "Admin")
                    {
                        AdminForm adminForm = new AdminForm(selectedRole, Staff_Id);
                        this.Hide();
                        adminForm.Show();
                    }
                    else if (selectedRole == "Warehouse Manager") 
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(selectedRole, Staff_Id);
                        this.Hide();
                        warehouseManagerForm.Show();
                    }
                    else if (selectedRole == "Sale") 
                    {
                        SaleForm saleForm = new SaleForm(selectedRole, Staff_Id);
                        this.Hide();
                        saleForm.Show();
                    }
            }
            else
            {
                //ChangePassword changePassword = new ChangePassword(Staff_Id, selectedRole);
                //changePassword.Show();
                //this
            }
        }
    }
}
