using GUI.Objects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;

namespace WindowsFormsApp1
{
    public partial class CarList : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        Zakaznik zakaznik;
        Zamestnanec zamestnanec;
        int idPozice;

        public CarList(Homepage form, SqlConnection conn, Zamestnanec zamestnanec)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
            this.zamestnanec = zamestnanec;

            if (zamestnanec.Pozice == 2)
            {
                enumEditBtn.Visible = false;
            }
        }

        public CarList(Homepage form, SqlConnection conn, Zakaznik zakaznik)
        {
            this.zakaznik = zakaznik;
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;

            this.idPozice = 3;
            KlientListBtn.Visible = false;
            workerListBtn.Visible = false;
            enumEditBtn.Visible = false;
            addCarBtn.Visible = false;
            resetBtn.Visible = false;
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            if (idPozice == 3)
            {
                Account formKlient = new Account(hmpForm, conn, zakaznik);
                formKlient.Show();
                this.Close();
            } else
            {
                Account form = new Account(hmpForm, conn, zamestnanec);
                form.Show();
                this.Close();
            }
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            if (idPozice == 3)
            {
                ContractList formKlient = new ContractList(hmpForm, conn, zakaznik);
                formKlient.Show();
                this.Close();
            } else
            {
                ContractList form = new ContractList(hmpForm, conn, zamestnanec);
                form.Show();
                this.Close();
            }
        }

        private void KlientListBtn_Click(object sender, EventArgs e)
        {
            KlientList form = new KlientList(hmpForm, conn, zamestnanec);
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

        private void CarList_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet.automobil'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.automobilTableAdapter.Fill(this.database1DataSet.automobil);

        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            NewCarForm form = new NewCarForm(conn);
            form.Show();
            this.Refresh();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            carListDataGrid.DataSource = null;
            loaddata();
        }

        private void loaddata()
        {
            conn.Open();
            //if (idPozice == 3) 
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT idmajitel FROM majitel WHERE jmeno_majitele = @jmeno_majitele AND prijmeni_majitele = @prijmeni_majitele", conn);
            //    cmd.Parameters.Add(new SqlParameter("@jmeno_majitele", SqlDbType.VarChar));
            //    cmd.Parameters["@jmeno_majitele"].Value = zakaznik.Jmeno;
            //    cmd.Parameters.Add(new SqlParameter("@prijmeni_majitele", SqlDbType.VarChar));
            //    cmd.Parameters["@prijmeni_majitele"].Value = zakaznik.Prijmeni;
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    reader.Read();

            //    if (reader.HasRows)
            //    {
            //        int idMajitel = reader.GetInt32(0);
            //        reader.Close();

            //        cmd = new SqlCommand("SELECT * FROM automobil WHERE majitel_idmajitel = @majitel_idmajitel",conn);
            //        cmd.Parameters.Add(new SqlParameter("@majitel_idmajitel", SqlDbType.VarChar));
            //        cmd.Parameters["@majitel_idmajitel"].Value = idMajitel;

            //        reader = cmd.ExecuteReader();

            //        reader.Read();

            //        for (int i = 0; i < reader.FieldCount; i++)
            //        {

            //        }

            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        adapter.Fill(dt);
            //        carListDataGrid.DataSource = dt;
            //    }

                    
            //}else
            //{
            //    string query = "SELECT * FROM automobil";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    carListDataGrid.DataSource = dt;
            //}

            string query = "SELECT * FROM automobil";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            carListDataGrid.DataSource = dt;
            conn.Close();
        }
    }
}
