using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Database
{
    internal class DatabaseConnection
    {
        private static SqlConnection _connection;
        private static string _connectionString;

        public static void SetConnectionString()
        {
            _connectionString = "Server=//fei-sql3.upceucebny.cz;Database=BDAS;Trusted_Connection=true;User Id=st64125;Password=abcde;";
        }

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    throw new InvalidOperationException("Connection string has not been set.");
                }

                _connection = new SqlConnection(_connectionString);
            }

            return _connection;
        }

        public static void OpenConnection()
        {
            if (_connection == null || _connection.State != System.Data.ConnectionState.Open)
            {
                GetConnection().Open();
                MessageBox.Show("Connection Open !");
            }
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
    }
}
