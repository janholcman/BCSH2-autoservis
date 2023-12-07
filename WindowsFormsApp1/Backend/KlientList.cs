using GUI.Objects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;

namespace WindowsFormsApp1
{
    public partial class KlientList : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        Zamestnanec zamestnanec;
        public KlientList(Homepage form, SqlConnection conn, Zamestnanec zamestnanec)
        {
            this.zamestnanec = zamestnanec;
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;

            if (zamestnanec.Pozice == 2)
            {
                enumEditBtn.Visible = false;
            }
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            Account form = new Account(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            ContractList form = new ContractList(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            CarList form = new CarList(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void workerListBtn_Click(object sender, EventArgs e)
        {
            WorkerList form = new WorkerList(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void enumEditBtn_Click(object sender, EventArgs e)
        {
            EnumEditor form = new EnumEditor(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            hmpForm.Show();
        }

        private void KlientList_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet4.zakaznik'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zakaznikTableAdapter.Fill(this.database1DataSet4.zakaznik);

        }

        private void addKlientBtn_Click(object sender, EventArgs e)
        {
            NewKlientForm form = new NewKlientForm(conn);
            form.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            KlientDataGrid.DataSource = null;
            loaddata();
        }

        private void loaddata()
        {
            conn.Open();

            string query = "SELECT * FROM zakaznik";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            KlientDataGrid.DataSource = dt;

            conn.Close();
        }
    }
}
