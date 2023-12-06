using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;

namespace WindowsFormsApp1
{
    public partial class ContractList : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        public ContractList(Homepage form, SqlConnection conn)
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

        private void workerListBtn_Click(object sender, EventArgs e)
        {
            WorkerList form = new WorkerList(hmpForm, conn);
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

        private void ContractList_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet1.zakazka'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zakazkaTableAdapter.Fill(this.database1DataSet1.zakazka);

        }

        private void addContractBtn_Click(object sender, EventArgs e)
        {
            NewContractForm form = new NewContractForm(conn);
            form.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            contractDataGrid.DataSource = null;
            loaddata();
        }

        private void loaddata()
        {
            conn.Open();

            string query = "SELECT * FROM zakazka";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            contractDataGrid.DataSource = dt;

            conn.Close();
        }
    }
}
