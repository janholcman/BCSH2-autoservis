using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.Database;
using Oracle.ManagedDataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.ManagedDataAccess.Types;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Homepage : Form
    {
        OracleConnection con1 = new OracleConnection();
        public Homepage()
        {
            InitializeComponent();
            
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
                //csb.DataSource = "fei-sql3.upceucebny.cz:1521";
                //csb.InitialCatalog = "BDAS";
                //csb.Password = "abcde";
                //csb.UserID = "st64125";
                //SqlConnection con2 = new SqlConnection(csb.ConnectionString);


                //OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
                //ocsb.Password = "abcde";
                //ocsb.UserID = "st64125;
                //ocsb.DataSource = "fei-sql3.upceucebny.cz:1521/BDAS";
                //String str = "Data Source=fei-sql3.upceucebny.cz:1521/BDAS;User Id=st64125;Password=abcde";
                //String connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=BDAS)));User Id=st64125;Password=abcde;";
                //con1.ConnectionString = connectionString;
                //con2.Open();
                //MessageBox.Show("connect with sql server");
                //con2.Close();

                //OleDbConnection oleDbConnection = new OleDbConnection();
                //oleDbConnection.ConnectionString = "provider=;data source=BDAS;user id=st64125;password=abcde";

                String Database1ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\honza\\Source\\Repos\\janholcman\\autoservis\\WindowsFormsApp1\\Database\\Database1.mdf;Integrated Security=True";
                SqlConnection pripojeni = new SqlConnection(Database1ConnectionString);
                pripojeni.Open();
                labelPripojeno.Text = "pripojeno";
                Console.WriteLine("Aplikace pripojena k databazi");
                pripojeni.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            using (LoginForm loginForm = new LoginForm(this))
            {
                loginForm.ShowDialog();
            }
        }
    }
}
