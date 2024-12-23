using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class ManageEmployee_Form : Form
    {
        int Staff_ID;
        string StaffPosition;
        int userId;
        public ManageEmployee_Form(string staffPosition, int userId)
        {
            this.Staff_ID = 0;
            this.userId = userId;
            InitializeComponent();
            this.StaffPosition = staffPosition;
        }
        private bool ValidateData(string StaffCode,
                                  string nameStaff,
                                  string staffPosition,
                                  string AuthorityLevel,
                                  string Username,
                                  string Password)
        {
            bool isValid = true;
            if (StaffCode == null || StaffCode == string.Empty)
            {
                MessageBox.Show(
                    "Staff Code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmployeeCode.Focus();
                isValid = false;
            }
            else if (nameStaff == null || nameStaff == string.Empty)
            {
                MessageBox.Show(
                    "Staff Name cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmployeeName.Focus();
                isValid = false;
            }
            else if (staffPosition == null || staffPosition == string.Empty)
            {
                MessageBox.Show(
                    "Position cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmployeePosition.Focus();
                isValid = false;
            }
            else if (AuthorityLevel == null || AuthorityLevel == string.Empty)
            {
                MessageBox.Show(
                    "Staff Code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cbAuthorityLevel.Focus();
                isValid = false;
            }
            else if (Username == null || Username == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUsername.Focus();
                isValid = false;
            }
            else if (Password == null || Password == string.Empty)
            {
                MessageBox.Show(
                    "Password cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Focus();
                isValid = false;
            }
            return isValid;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = buttonStatus;
        }
        private void FlushStaffID()
        {
            this.Staff_ID = 0;
            ChangeButtonStatus(false);
        }
        private void LoadStaffData()
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT * FROM Staff";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgEmployee.DataSource = table;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushStaffID();
            txtEmployeeCode.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeePosition.Text = string.Empty;
            cbAuthorityLevel.SelectedIndex = 0;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmployeeCode.Focus();
        }
        public void InitializeCombobox()
        {
            cbAuthorityLevel.Items.Add("Admin");
            cbAuthorityLevel.Items.Add("Warehouse Manager");
            cbAuthorityLevel.Items.Add("Sale");
            cbAuthorityLevel.SelectedIndex = 0;
        }
        private bool CheckUserExistence(int Staff_ID)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Staff WHERE Staff_ID = @staffid ";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("Staff_ID", Staff_ID);
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                connection.Close();
            }
            return isExist;
        }
        private void AddUser(string StaffCode,
                             string nameStaff,
                             string Position,
                             string AuthorityLevel,
                             string Username,
                             string Password)
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "INSERT INTO Staff VALUES (@StaffCode, " +
                             "@nameStaff, @Position, " +
                             "@AuthorityLevel, @Username, @Password, 0)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("StaffCode", StaffCode);
                command.Parameters.AddWithValue("nameStaff", nameStaff);
                command.Parameters.AddWithValue("Position", Position);
                command.Parameters.AddWithValue("AuthorityLevel", AuthorityLevel);
                command.Parameters.AddWithValue("Username", Username);
                command.Parameters.AddWithValue("Password", Password);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Succesfully add new user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadStaffData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot add new user",
                        "Errpr",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                connection.Close();
            }
        }
        private void UpdateUser(int Staff_ID,
                                string StaffCode,
                                string nameStaff,
                                string Position,
                                string AuthorityLevel,
                                string Username,
                                string Password)
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "UPDATE Staff SET StaffCode = @StaffCode, " +
                             "nameStaff = @nameStaff, " +
                             "Position = @Position, " +
                             "AuthorityLevel = @AuthorityLevel, " +
                             "Username = @Username, " +
                             "Password = @Password, " +
                             "WHERE  Staff_ID = @Staff_ID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("StaffCode", StaffCode);
                command.Parameters.AddWithValue("nameStaff", nameStaff);
                command.Parameters.AddWithValue("Position", Position);
                command.Parameters.AddWithValue("AuthorityLevel", AuthorityLevel);
                command.Parameters.AddWithValue("Username", Username);
                command.Parameters.AddWithValue("Password", Password);
                command.Parameters.AddWithValue("Staff_ID", Staff_ID);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadStaffData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot update user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }
        private void DeleteUser(int Staff_ID)
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "DELETE Staff WHERE Staff_ID = @Staff_ID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("Staff_ID", Staff_ID);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully delete user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadStaffData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot delete user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }
        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadStaffData();
            }
            else
            {
                SqlConnection connection = DatabaseConection.GetConnection();
                if (connection != null)
                    connection.Open();
                string query = "SELECT * FROM Employee WHERE Employee LIKE @search " +
                               "OR name Staff LIKE @search " +
                               "OR Position LIKE @search" +
                               "OR AuthorityLevel LIKE @search " +
                               "OR Username LIKE @search " +
                               "OR Password LIKE @search ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgEmployee.DataSource = table;
                connection.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string StaffCode = txtEmployeeCode.Text;
            string nameStaff = txtEmployeeName.Text;
            string Position = txtEmployeePosition.Text;
            string AuthorityLevel = cbAuthorityLevel.Text;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            bool isValid = ValidateData(StaffCode,
                                        nameStaff,
                                        Position,
                                        AuthorityLevel,
                                        Username,
                                        Password);
            if (isValid)
            {
                AddUser(StaffCode, nameStaff, Position, AuthorityLevel, Username, Password);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string StaffCode = txtEmployeeCode.Text;
            string nameStaff = txtEmployeeName.Text;
            string Position = txtEmployeePosition.Text;
            string AuthorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            bool isValid = ValidateData(StaffCode,
                                        nameStaff,
                                        Position,
                                        AuthorityLevel,
                                        Username,
                                        Password);
            if (isValid)
            {
                UpdateUser(Staff_ID,StaffCode, nameStaff, Position, AuthorityLevel, Username, Password);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                                  "Do you want to delete this user",
                                                  "warning",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteUser(Staff_ID);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (StaffPosition)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(StaffPosition, Staff_ID);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManager = new WarehouseManagerForm(StaffPosition, Staff_ID);
                        this.Hide();
                        warehouseManager.Show();
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(StaffPosition, Staff_ID);
                        this.Hide();
                        saleForm.Show();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            ChangeButtonStatus(false);
            InitializeCombobox();
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchUser(search);
        }
        private void dtgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgEmployee.CurrentCell.RowIndex;
            if (index != -1)
            {
                Staff_ID = Convert.ToInt32(dtgEmployee.Rows[index].Cells[0].Value);
                ChangeButtonStatus(true);
                txtEmployeeCode.Text = dtgEmployee.Rows[index].Cells[1].Value.ToString();
                txtEmployeeName.Text = dtgEmployee.Rows[index].Cells[2].Value.ToString();
                txtEmployeePosition.Text = dtgEmployee.Rows[index].Cells[3].ToString();
                string AuthorityLevel = dtgEmployee.Rows[index].Cells[4].Value.ToString();
                if (AuthorityLevel == "Admin")
                {
                    cbAuthorityLevel.SelectedIndex = 0;
                }
                else if (AuthorityLevel == "Warehouse Manager")
                {
                    cbAuthorityLevel.SelectedIndex = 1;
                }
                else if (AuthorityLevel == "Sale")
                {
                    cbAuthorityLevel.SelectedIndex = 2;
                }
                txtUsername.Text = dtgEmployee.Rows[index].Cells[5].Value.ToString();
                txtPassword.Text = dtgEmployee.Rows[index].Cells[6].Value.ToString();
            }
        }
        public ManageEmployee_Form()
        {
            InitializeComponent();
        }

        private void ManageEmployee_Form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmployeeCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeePosition_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
