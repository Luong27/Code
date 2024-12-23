using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class ManageProduct_form : Form
    {
        private int productID;
        private string AuthorityLevel;
        private int userID;
        public ManageProduct_form(string AuthorityLevel, int userID)
        {
            this.AuthorityLevel = AuthorityLevel;
            this.userID = userID;
            productID = 0;
            InitializeComponent();
        }
        private void LoadCategoryCombobox()
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT CategoryID, CategoryName FROM Category ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "Category ID";
            }
        }
        private bool ValidateData(String productCode,
            String productName,
            String productPrice,
            String productQuantity)
        {
            double temp;
            int temp2;
            if (String.IsNullOrEmpty(productName)) { return false; }
            if (String.IsNullOrEmpty (productPrice)) { return false; }
            if (!double.TryParse(productPrice,out temp)) { return false; }
            if (String.IsNullOrEmpty(productQuantity)) { return false; }
            return int.TryParse(productQuantity,out temp2);
        }
        private void UploadFile(String filter, String path)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.Title = "Select a file to upload";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
                string targetFilePath = Path.Combine(targetDirectory,Path.GetFileName(sourceFilePath));
                try
                {
                    if (!Directory.Exists(targetDirectory))
                    {
                        Directory.CreateDirectory(targetDirectory);
                    }
                    File.Copy(sourceFilePath, targetFilePath, overwrite: true);
                    txtProductImg.Text = targetFilePath;
                    MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadProductData()
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string querry = "SELECT * FROM Product";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgProduct.DataSource = dataTable;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushProductID();
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductImg.Text= string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = buttonStatus;
        }
        private void FlushProductID()
        {
            this.productID = 0;
            ChangeButtonStatus(false);
        }
        private void AddProduct()
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryID = Convert.ToInt32(cbCategory.SelectedValue);
                if (ValidateData(productCode, productName, price, quantity))
                {
                    string sql = "INSERT INTO Product VALUES (" +
                        "@productCode, @productName, @productPrice, @productQuantity, @productImg, @categoryID)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("productCode", productCode);
                    command.Parameters.AddWithValue("productName", productName);
                    command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("productImg", productImg);
                    command.Parameters.AddWithValue("categoryID", categoryID);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(
                        "Successfully add new product",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information );
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                        "Cannot add mew product",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                connection.Close();
            }
        }
        private void UpdateProduct()
        {
            SqlConnection connection = DatabaseConection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryID = Convert.ToInt32(cbCategory.SelectedValue);
                if (ValidateData(productCode, productName, price, quantity))
                {
                    string sql = "UPDATE Product SET ProductCode = @productCode, " +
                        "ProductName = @productName, " +
                        "InventoryQuantity = @productQuantity, " +
                        "ProductImage = @productImg, " +
                        "CategoryID = @categoryID " +
                        "WHERE ProductID = @productID";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("productCode", productCode);
                    command.Parameters.AddWithValue("productName", productName);
                    command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("productImg", productImg);
                    command.Parameters.AddWithValue("categoryID", categoryID);
                    command.Parameters.AddWithValue("productID", this.productID);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(
                        "Successfully update product",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                        "Cannot update product",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                connection.Close();
            }
        }
        private void DeleteProduct()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the product",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                if(!IsProductInOrder(this.productID))
                {
                    SqlConnection connection = DatabaseConection.GetConnection();
                    if (connection != null)
                    {
                        connection.Open();
                        string sql = "DELETE Product WHERE ProductID = @productID";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("productID", this.productID);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show(
                            "Successfully delete product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            ClearData();
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show(
                            "Cannot delete product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                        connection.Close() ;
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Product is in another order\nCannot delete",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
        private bool IsProductInOrder(int productID)
        {
            SqlConnection connection = DatabaseConection.GetConnection ();
            if (connection != null)
            {
                connection.Open ();
                string sql = "SELECT COUNT(*) FROM OrderDetail WHERE ProductID = @productID";
                SqlCommand command = new SqlCommand (sql, connection);
                command.Parameters.AddWithValue("productID", productID);
                int result = (int)command.ExecuteScalar();
                connection.Close();
                return result > 0;
            }
            return false;
        }
        private void SearchProduct(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadProductData();
            }
            else
            {
                SqlConnection connection = DatabaseConection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string sql = "SELECT p.ProductID, p.ProductCode, p.ProductName, p.Price, " +
                        "p.InventoryQuantity, p.ProductImage, c.CategoryName " +
                        "FROM Product p " +
                        "INNER JOIN Category c " +
                        "ON p.CategoryID = c.CategoryID " +
                        "WHERE p.ProductCode LIKE @search " +
                        "OR p.ProductName LIKE @search " +
                        "OR c.CategoryName LIKE @search ";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" +  search + "%");
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dtgProduct.DataSource = data;
                    connection.Close();
                }
            }
        }
        private void ManageProduct_Load(object sender, EventArgs e)
        {
            LoadProductData ();
            LoadCategoryCombobox();
            ChangeButtonStatus(false);
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (AuthorityLevel)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(this.AuthorityLevel, this.userID);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.AuthorityLevel, this.userID);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(this.AuthorityLevel, this.userID);
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
        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgProduct.CurrentCell.RowIndex;
            if (index != -1 && !dtgProduct.Rows[index].IsNewRow)
            {
                productID = Convert.ToInt32(dtgProduct.Rows[index].Cells[0].Value);
                ChangeButtonStatus(true);
                txtProductCode.Text = dtgProduct.Rows[index].Cells[1].Value.ToString();
                txtProductName.Text = dtgProduct.Rows[index].Cells[2].Value.ToString();
                txtProductPrice.Text = dtgProduct.Rows[index].Cells[3].Value.ToString();
                txtProductQuantity.Text = dtgProduct.Rows[index].Cells[4].Value.ToString();
                txtProductImg.Text = dtgProduct.Rows[index].Cells[5].Value.ToString();
                string categoryName = dtgProduct.Rows[index].Cells[6].Value.ToString();
                for (int i = 0; i < cbCategory.Items.Count; i++)
                {
                    if (cbCategory.SelectedText == categoryName)
                    {
                        cbCategory.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchProduct(search);
        }
        public ManageProduct_form()
        {
            InitializeComponent();
        }

        private void ManageProduct_form_Load(object sender, EventArgs e)
        {

        }
    }
}
