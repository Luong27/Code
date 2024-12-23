using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        private int customerID;
        private int employeeID;
        private int userId;
        private string authorityLevel;
        public ManageCustomer(string authorityLevel, int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.authorityLevel = authorityLevel;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = buttonStatus;
        }
        private bool ValidateData(string customerCode, string customerName, string customerAddress, string phonenumber)
        {
            bool isValid = true;
            if (customerCode == null || customerCode == string.Empty)
            {
                MessageBox.Show(
                    "Customer Code cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isValid = false;
                txtCustomerCode.Focus();
            }
            else if (customerName == null || customerName == string.Empty)
            {
                MessageBox.Show(
                    "Customer Name cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtCustomerName.Focus();
            }
            else if (customerAddress == null || customerAddress == string.Empty)
            {
                MessageBox.Show(
                    "Customer Address cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtCustomerAddress.Focus();
            }
            else if (phonenumber == null || phonenumber == string.Empty)
            {
                MessageBox.Show(
                    "Phonenumber cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtPhonenumber.Focus();
            }
            return isValid;
        }
        private void FlushCustomerId()
        {
            this.customerID = 0;
            ChangeButtonStatus(false);
        }
        private void LoadCustomerData()
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill( table );
                dtgCustomer.DataSource = table;
                connection.Close();
            }
        }
        private bool CheckUserExistence(int customerID)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Customer WHERE CustomerID = @customerId";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("customerId", customerID);
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                connection.Close();
            }
            return isExist;
        }
        private void AddCustomer(string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection .Open();
                string query = "INSERT INTO Customer (CustomerCode, CustomerName, Phonenumber, Address) " +
                               "VALUES (@customerCode, @customerName, @phoneNumber, @customerAddress) ";
                SqlCommand command = new SqlCommand (query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode);
                command.Parameters.AddWithValue("customerName", customerName);
                command.Parameters.AddWithValue("phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("cusomerAddress", customerAddress);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully and new customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information );
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while adding customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error );
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }
        private void ClearData()
        {
            FlushCustomerId();
            txtCustomerCode.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtCustomerAddress.Text = string.Empty;
            txtPhonenumber.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtCustomerCode.Focus();
        }
        private void updateCustomer(int customerId, string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            SqlConnection connection = DatabaseConection.GetConnection ();
            if (connection != null)
            {
                connection .Open();
                string query = "UPDATE Customer SET " +
                               "CustomerCode = @customerCode, " +
                               "CustomerName = @customerName, " +
                               "Address = @customerAddress, " +
                               "Phonenumber = @phoneNumber " +
                               "WHERE CustomerID = @customerId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode );
                command.Parameters.AddWithValue("customerName", customerName );
                command.Parameters.AddWithValue("customerAddress", customerAddress );
                command.Parameters.AddWithValue("phoneNumber", phoneNumber );
                command.Parameters.AddWithValue("customerId", customerID );
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information );
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while updating customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error );
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }
        private void DeleteCustomer( int customerId )
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection .Open();
                string deleteOrderDetailQuery = "DELETE OrderDetail WHERE OrderDetailID IN " +
                    "(SELECT OrderID FROM Orders WHERE CustomerID = @customerId)";
                SqlCommand command = new SqlCommand (deleteOrderDetailQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId );
                command.ExecuteNonQuery ();
                string deleteOrderQuery = "DELETE Orders WHERE Customer ID = @customerId";
                command = new SqlCommand (deleteOrderQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                command.ExecuteNonQuery ();
                string deleteCustomerQuery = "DELETE Customer WHERE Customer ID = @customerId";
                command = new SqlCommand(deleteCustomerQuery, connection);
                command.Parameters.AddWithValue("customerId", customerId);
                int deleteCustomerResult = command.ExecuteNonQuery ();
                if ( deleteCustomerResult > 0)
                {
                    MessageBox.Show(
                        "Successfully delete customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information );
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while deleting customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error );
                }
                connection.Close();
                ClearData();
                LoadCustomerData();
            }
        }
        private void SearchCustomer(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadCustomerData ();
            }
            else
            {
                SqlConnection connection = DatabaseConection.GetConnection();
                if (connection != null)
                {
                    connection.Open ();
                    string query = "SELECT * FROM Customer WHERE CustomerCode LIKE @search OR CustomerName LIKE @search OR Phonenumber LIKE @search OR Address LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" +  search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill (table);
                    dtgCustomer.DataSource = table;
                    connection.Close ();
                }
            }
        }
        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerCode = txtCustomerCode.Text;
            string customerName = txtCustomerName.Text;
            string customerAddress = txtCustomerAddress.Text;
            string phoneNumber = txtPhonenumber.Text;
            bool isValid = ValidateData(customerCode, customerName, customerAddress, phoneNumber);
            if (isValid)
            {
                AddCustomer(customerCode, customerName, customerAddress, phoneNumber);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (customerID >0)
            {
                bool isUserExist = CheckUserExistence(customerID);
                if (isUserExist)
                {
                    string customerCode = txtCustomerCode.Text;
                    string customerName = txtCustomerName.Text;
                    string customerAddress = txtCustomerAddress.Text;
                    string phoneNumber = txtPhonenumber.Text;
                    bool isValid = ValidateData(customerCode , customerName, customerAddress, phoneNumber);
                    if (isValid)
                    {
                        updateCustomer(customerID, customerCode, customerName, customerAddress, phoneNumber);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No customer found",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerID >0)
            {
                DialogResult result = MessageBox.Show(
                                      "Do you want to delete this customer with all related data?",
                                      "Warning",
                                      MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bool isUserExist = CheckUserExistence(customerID);
                    if (isUserExist)
                    {
                        DeleteCustomer(customerID);
                    }
                    else
                    {
                        MessageBox.Show(
                            "No customer found" ,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (authorityLevel)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(this.authorityLevel, this.userId);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.authorityLevel, this.userId);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(this.authorityLevel, this.userId);
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
        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerID = (int)dtgCustomer.Rows[index].Cells[0].Value;
                txtCustomerCode.Text = dtgCustomer.Rows[index].Cells[1].Value.ToString();
                txtCustomerName.Text = dtgCustomer.Rows[index].Cells[2].Value.ToString();
                txtPhonenumber.Text = dtgCustomer.Rows[index].Cells[3].Value.ToString();
                txtCustomerAddress.Text = dtgCustomer.Rows[index].Cells[4].Value.ToString();
                ChangeButtonStatus(true);
            }
        }
        private void dtgCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // int index = dtgCustomer.CurrentCell.RowIndex;
           // if (index > -1)
            //{
                //customerID = (int)dtgCustomer.Rows[index].Cells[0].Value;
                //string customerName = dtgCustomer.Rows[index].Cells[2].Value.ToString();
                //Order order = new Order(customerID, employeeID, customerName);
                //order.ShowDialog();
            //}
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchCustomer(search);
        }
    }
}
