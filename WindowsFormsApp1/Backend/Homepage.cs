using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;

namespace WindowsFormsApp1
{
    public partial class Homepage : Form
    {
        SqlConnection conn;
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
                String Database1ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\honza\\Source\\Repos\\janholcman\\autoservis\\WindowsFormsApp1\\Database\\Database1.mdf;Integrated Security=True";
                conn = new SqlConnection(Database1ConnectionString);
                conn.Open();
                labelPripojeno.Text = "pripojeno";
                Console.WriteLine("Aplikace pripojena k databazi");
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            LoginForm form = new LoginForm(this, conn);
            form.Show();
        }
    }
}
