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
    public partial class OrderHistory : Form
    {
        private int employeeId;
        private string authorityLevel;
        public OrderHistory(string authorityLevel, int employeeId)
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {

        }
        private void LoadOrderHistory()
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null )
            {
                connection.Open();
                string query = "SELECT o.OrderDate, " +
                               "e.EmplyeeName, " +
                               "c.CustomerName" +
                               "FROM Orders o " +
                               "INNER JOIN Employee e ON o.EmployeeID = e.EmployeeID " +
                               "INNER JOIN Customer c ON c.CustomerID = c.CustomerID" +
                               "WHERE o.EmployeeID = @employeeId " +
                               "GROUP BY o.OrderDate, e.EmployeeName, e.EmployeeCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("employeeId", employeeId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgOrderHistory.DataSource = dataTable;
            }
        }
        private void RedirectPage()
        {
            switch (this.authorityLevel)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(authorityLevel, employeeId);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManager = new WarehouseManagerForm(authorityLevel, employeeId);
                        this.Hide();    
                        warehouseManager.Show();
                        break;
                    }
                case "Sale":
                    {
                        ManageCustomer saleForm = new ManageCustomer(authorityLevel,employeeId);
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
        private void CustomerHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            RedirectPage();
        }
    }
}
