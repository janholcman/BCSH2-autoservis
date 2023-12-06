using System.Data.SqlClient;
using System.Windows.Forms;
using GUI.Objects;
using System;
using System.Data;

namespace WindowsFormsApp1.Backend
{
    public partial class NewContractForm : Form
    {
        SqlConnection conn;

        public NewContractForm(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            importKlientIntoCombobox();
            importWorkerIntoCombobox();
        }

        private void importKlientIntoCombobox()
        {
            try
            {
                string query = "select jmeno_zakaznik, prijmeni_zakaznik, jmeno_firmy from zakaznik";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Zakaznik zakaznik = new Zakaznik(dt.Rows[i]["jmeno_zakaznik"].ToString(), dt.Rows[i]["prijmeni_zakaznik"].ToString(), dt.Rows[i]["jmeno_firmy"].ToString());

                    KlientCB.Items.Add(zakaznik);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void importWorkerIntoCombobox()
        {
            try
            {
                string query = "select jmeno_zamestnanec, prijmeni_zamestnanec from zamestnanec";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Zamestnanec zamestnanec = new Zamestnanec(dt.Rows[i]["jmeno_zamestnanec"].ToString(), dt.Rows[i]["prijmeni_zamestnanec"].ToString());

                    workerCB.Items.Add(zamestnanec);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void addKlientBtn_Click(object sender, EventArgs e)
        {
            NewKlientForm form = new NewKlientForm(conn, this);
            form.Show();
        }

        public void resetKlientCB()
        {
            KlientCB.Items.Clear();
            importKlientIntoCombobox();
        }

        private void klientCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KlientCB.SelectedIndex != null) { groupBox.Enabled = true; } else { groupBox.Enabled = false; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (KlientCB.SelectedItem == null || workerCB.SelectedItem == null)
            {
                if (KlientCB.SelectedItem == null) { klientTT.Visible = true; } else { klientTT.Visible = false; }
                if (workerCB.SelectedItem == null) { workerTT.Visible = true; } else { workerTT.Visible = false; }
            } else
            {
                int klientId = findKlientId();
                int workerId = findWorkerId();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO zakazka (start_zakazky, zamestnanec_idzamestnanec) VALUES (@start_zakazky, @zamestnanec_idzamestnanec)", conn);
                cmd.Parameters.AddWithValue("@start_zakazky", dateTime.Value);
                cmd.Parameters.AddWithValue("@zamestnanec_idzamestnanec", workerId);
                cmd.ExecuteNonQuery();

                conn.Close();

                int contractId = findContractId();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO zakaznik_zakazka (zakaznik_idzakaznik, zakazka_idzakazka) VALUES (@zakaznik_idzakaznik, @zakazka_idzakazka)", conn);
                cmd.Parameters.AddWithValue("@zakaznik_idzakaznik", klientId);
                cmd.Parameters.AddWithValue("@zakazka_idzakazka", workerId);
                cmd.ExecuteNonQuery();

                conn.Close();
                this.Close();
            }
        }

        private int findWorkerId()
        {
            Zamestnanec zamestnanec = workerCB.SelectedItem as Zamestnanec;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idzamestnanec FROM zamestnanec WHERE jmeno_zamestnanec = @jmeno_zamestnanec AND prijmeni_zamestnanec = @prijmeni_zamestnanec", conn);
            cmd.Parameters.Add(new SqlParameter("@jmeno_zamestnanec", SqlDbType.VarChar));
            cmd.Parameters["@jmeno_zamestnanec"].Value = zamestnanec.Jmeno;
            cmd.Parameters.Add(new SqlParameter("@prijmeni_zamestnanec", SqlDbType.VarChar));
            cmd.Parameters["@prijmeni_zamestnanec"].Value = zamestnanec.Prijmeni;
            
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }

        private int findContractId()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idzakazka FROM zakazka WHERE start_zakazky = @start_zakazky AND zamestnanec_idzamestnanec = @zamestnanec_idzamestnanec", conn);
            cmd.Parameters.Add(new SqlParameter("@start_zakazky", SqlDbType.VarChar));
            cmd.Parameters["@start_zakazky"].Value =dateTime.Value;
            cmd.Parameters.Add(new SqlParameter("@zamestnanec_idzamestnanec", SqlDbType.VarChar));
            cmd.Parameters["@zamestnanec_idzamestnanec"].Value = findWorkerId();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }

        private int findKlientId()
        {
            Zakaznik zakaznik = KlientCB.SelectedItem as Zakaznik;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idzakaznik FROM zakaznik WHERE jmeno_zakaznik = @jmeno_zakaznik AND prijmeni_zakaznik = @prijmeni_zakaznik", conn);
            cmd.Parameters.Add(new SqlParameter("@jmeno_zakaznik", SqlDbType.VarChar));
            cmd.Parameters["@jmeno_zakaznik"].Value = zakaznik.Jmeno;
            cmd.Parameters.Add(new SqlParameter("@prijmeni_zakaznik", SqlDbType.VarChar));
            cmd.Parameters["@prijmeni_zakaznik"].Value = zakaznik.Prijmeni;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }
    }
}
