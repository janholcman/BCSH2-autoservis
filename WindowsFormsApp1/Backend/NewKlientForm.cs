using GUI.Objects;
using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApp1.Backend
{
    public partial class NewKlientForm : Form
    {
        SqlConnection conn;
        NewContractForm contractForm = null;
        Zakaznik zakaznik;

        public NewKlientForm(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            importAdressDataIntoCombobox();
        }

        public NewKlientForm(SqlConnection conn, Zakaznik zakaznik)
        {
            this.zakaznik = zakaznik;
            InitializeComponent();
            this.conn = conn;
            importAdressDataIntoCombobox();

            firstNameTF.Text = zakaznik.Jmeno;
            secondNameTF.Text = zakaznik.Prijmeni;
            companyTF.Text = zakaznik.JmenoFirmy;
            adresCB.SelectedIndex = zakaznik.Idadresa - 1001;
            userNameTF.Text = zakaznik.NazevUctu;
            userPasswordTF.Text = zakaznik.Heslo;
        }

        public NewKlientForm(SqlConnection conn, NewContractForm form)
        {
            this.contractForm = form;
            InitializeComponent();
            this.conn = conn;
            importAdressDataIntoCombobox();
        }

        private void importAdressDataIntoCombobox()
        {
            try
            {
                string query = "select mesto, ulice, cislo_popisne, psc, idadresa from adresa";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Adresa adresa = new Adresa(dt.Rows[i]["mesto"].ToString(), dt.Rows[i]["ulice"].ToString(), dt.Rows[i]["cislo_popisne"].ToString(), dt.Rows[i]["psc"].ToString() );

                    adresCB.Items.Add(adresa);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            Boolean validUserName = compareUserName();

            if (firstNameTF.Text == "" || secondNameTF.Text == "" || adresCB.SelectedItem == null || userNameTF.Text == "" || userPasswordTF.Text == "" || validUserName != true)
            {
                if (firstNameTF.Text == "") { firstNameTT.Visible = true; } else { firstNameTT.Visible = false; }
                if (secondNameTF.Text == "") { secondNameTT.Visible = true; } else { secondNameTT.Visible = false; }
                if (userNameTF.Text == "") { userNameTT.Visible = true; } else { userNameTT.Visible = false; }
                if (userPasswordTF.Text == "") { userPasswordTT.Visible = true; } else { userPasswordTT.Visible = false; }
                if (adresCB.Text == "") { adressTT.Visible = true; } else { adressTT.Visible = false; }
            }
            else
            {
                int addressId = findAddressId();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO zakaznik (jmeno_zakaznik, prijmeni_zakaznik, jmeno_firmy, adresa_idadresa, nazev_uctu, heslo) VALUES (@jmeno_zakaznik, @prijmeni_zakaznik, @jmeno_firmy, @adresa_idadresa, @nazev_uctu, @heslo)", conn);

                cmd.Parameters.AddWithValue("@jmeno_zakaznik", firstNameTF.Text);
                cmd.Parameters.AddWithValue("@prijmeni_zakaznik", secondNameTF.Text);
                cmd.Parameters.AddWithValue("@jmeno_firmy", companyTF.Text);
                cmd.Parameters.AddWithValue("@adresa_idadresa", addressId);
                cmd.Parameters.AddWithValue("@nazev_uctu", userNameTF.Text);
                cmd.Parameters.AddWithValue("@heslo", userPasswordTF.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                if (contractForm != null)
                {
                    contractForm.resetKlientCB();
                }
                this.Close();
            }
            
        }

        private int findAddressId()
        {
            Adresa adresa = adresCB.SelectedItem as Adresa;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idadresa FROM adresa WHERE mesto = @mesto AND ulice = @ulice AND cislo_popisne = @cislo_popisne AND psc = @psc", conn);
            cmd.Parameters.Add(new SqlParameter("@mesto", SqlDbType.VarChar));
            cmd.Parameters["@mesto"].Value = adresa.Mesto;
            cmd.Parameters.Add(new SqlParameter("@ulice", SqlDbType.VarChar));
            cmd.Parameters["@ulice"].Value = adresa.Ulice;
            cmd.Parameters.Add(new SqlParameter("@cislo_popisne", SqlDbType.VarChar));
            cmd.Parameters["@cislo_popisne"].Value = adresa.CisloPopisne;
            cmd.Parameters.Add(new SqlParameter("@psc", SqlDbType.VarChar));
            cmd.Parameters["@psc"].Value = adresa.Psc;
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }

        private Boolean compareUserName()
        {
            Boolean validUserName = true;

            string query = "select nazev_uctu from zakaznik";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["nazev_uctu"].ToString().Equals(userNameTF.Text))
                {
                    validUserName = false;
                }
            }

            string query2 = "select nazev_uctu from zamestnanec";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i]["nazev_uctu"].ToString().Equals(userNameTF.Text))
                {
                    validUserName = false;
                }
            }

            conn.Close();

            if (validUserName == false) { userNameWarning.Visible = true; } else { userNameWarning.Visible = false; }

            return validUserName;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAdresBtn_Click(object sender, EventArgs e)
        {
            NewAdresForm form = new NewAdresForm(conn, this);
            form.Show();
        }

        public void resetAdresCB()
        {
            adresCB.Items.Clear();
            importAdressDataIntoCombobox();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (userPasswordTF.UseSystemPasswordChar == true)
            {
                userPasswordTF.UseSystemPasswordChar = false;
            }
            else
            {
                userPasswordTF.UseSystemPasswordChar = true;
            }

        }
    }
}
