using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;

namespace WindowsFormsApp1
{
    public partial class WorkerList : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        public WorkerList(Homepage form, SqlConnection conn)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            Account form = new Account(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            ContractList form = new ContractList(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            CarList form = new CarList(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void KlientListBtn_Click(object sender, EventArgs e)
        {
            KlientList form = new KlientList(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void enumEditBtn_Click(object sender, EventArgs e)
        {
            EnumEditor form = new EnumEditor(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            hmpForm.Show();
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet5.zamestnanec'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zamestnanecTableAdapter.Fill(this.database1DataSet5.zamestnanec);

        }

        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            NewWorkerForm form = new NewWorkerForm(conn);
            form.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            workerDataGrid.DataSource = null;
            loaddata();
        }
        private void loaddata()
        {
            conn.Open();

            string query = "SELECT * FROM zamestnanec";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            workerDataGrid.DataSource = dt;

            conn.Close();
        }
    }
}
