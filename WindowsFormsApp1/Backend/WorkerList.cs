using GUI.Objects;
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
        Zamestnanec zamestnanec;

        public WorkerList(Homepage form, SqlConnection conn, Zamestnanec zamestnanec)
        {
            this.zamestnanec = zamestnanec;
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;

            if (zamestnanec.Pozice == 2)
            {
                enumEditBtn.Visible = false;
                addWorkerBtn.Visible = false;
                refreshBtn.Visible = false;
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

        private void KlientListBtn_Click(object sender, EventArgs e)
        {
            KlientList form = new KlientList(hmpForm, conn, zamestnanec);
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

        private void workerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (workerDataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (zamestnanec.Pozice == 1)
                {
                    DataGridViewCell cell = workerDataGrid.Rows[e.RowIndex].Cells[0];
                    int id = Convert.ToInt32(cell.Value);

                    string query = "SELECT * FROM zamestnanec WHERE idzamestnanec = @idzamestnanec";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand.Parameters.AddWithValue("@idzamestnanec", id);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Zamestnanec prihlasenyZamestnanec = new Zamestnanec(id, dt.Rows[0]["jmeno_zamestnanec"].ToString(), dt.Rows[0]["prijmeni_zamestnanec"].ToString(), dt.Rows[0]["rodne_cislo"].ToString(), Convert.ToDateTime(dt.Rows[0]["datum_nastupu"]), Convert.ToInt32(dt.Rows[0]["hodinova_mzda"]), Convert.ToInt32(dt.Rows[0]["mzda"]), Convert.ToInt32(dt.Rows[0]["pozice_idpozice"]), dt.Rows[0]["nazev_uctu"].ToString(), dt.Rows[0]["heslo"].ToString());

                    Account form = new Account(hmpForm, conn, prihlasenyZamestnanec);
                    form.Show();
                    conn.Close();
                } else
                {
                    MessageBox.Show("Nemáte příslušná práva!");
                }
                
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (zamestnanec.Pozice == 1)
            {
                int selectedRow = workerDataGrid.CurrentCell.RowIndex;
                DataGridViewCell cell = workerDataGrid.Rows[selectedRow].Cells[0];
                int id = Convert.ToInt32(cell.Value);
                string query = "SELECT * FROM zamestnanec WHERE idzamestnanec = @idzamestnanec";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@idzamestnanec", id);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Zamestnanec editovanyZamestnanec = new Zamestnanec(id, dt.Rows[0]["jmeno_zamestnanec"].ToString(), dt.Rows[0]["prijmeni_zamestnanec"].ToString(), dt.Rows[0]["rodne_cislo"].ToString(), Convert.ToDateTime(dt.Rows[0]["datum_nastupu"]), Convert.ToInt32(dt.Rows[0]["hodinova_mzda"]), Convert.ToInt32(dt.Rows[0]["mzda"]), Convert.ToInt32(dt.Rows[0]["pozice_idpozice"]), dt.Rows[0]["nazev_uctu"].ToString(), dt.Rows[0]["heslo"].ToString());
                conn.Close();
                NewWorkerForm form = new NewWorkerForm(conn, editovanyZamestnanec);
                form.Show();
            }
            else
            {
                MessageBox.Show("Nemáte příslušná práva!");
            }


        }
    }
}
