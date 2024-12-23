using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class DatabaseConection
    {
        private static string _connectionString = "Data Source=DESKTOP-3NPHIS5\\SQLEXPRESS;Initial Catalog='SALE GAME';Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Error while connecting to the database",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            return connection;
        }
    }
}
