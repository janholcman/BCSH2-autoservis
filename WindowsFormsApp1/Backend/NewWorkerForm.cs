using GUI.Objects;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Backend
{
    public partial class NewWorkerForm : Form
    {
        SqlConnection conn;
        Zamestnanec Zamestnanec;

        public NewWorkerForm(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            importPositionDataIntoCombobox();
        }

        public NewWorkerForm(SqlConnection conn, Zamestnanec zamestnanec)
        {
            this.Zamestnanec = zamestnanec;
            this.conn = conn;
            InitializeComponent();
            importPositionDataIntoCombobox();

            firstNameTF.Text = zamestnanec.Jmeno;
            secondNameTF.Text = zamestnanec.Prijmeni;
            birthNumberTF.Text = zamestnanec.RodneCislo;
            dateTimePicker.Value = zamestnanec.DatumNastupu;
            moneyPerHourNumpicker.Value = Convert.ToDecimal(zamestnanec.HodinovaMzda);
            if (zamestnanec.Pozice == 1)
            {
                positionCB.SelectedIndex = 0;
            }
            else
            {
                positionCB.SelectedValue = 1;
            }
            userNameTF.Text = zamestnanec.UserName;
            userPasswordTF.Text = zamestnanec.Password;
        }

        private void importPositionDataIntoCombobox()
        {
            try
            {
                string query = "SELECT nazev_pozice FROM pozice";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["nazev_pozice"].ToString() != "Zakaznik")
                    {
                        Pozice pozice = new Pozice(dt.Rows[i]["nazev_pozice"].ToString());

                        positionCB.Items.Add(pozice);
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, System.EventArgs e)
        {
            Boolean validBirthNumber = compareBirthNumber();
            Boolean validUserName = compareUserName();

            if (firstNameTF.Text == "" || secondNameTF.Text == "" || birthNumberTF.Text == "" || dateTimePicker.Value == null || moneyPerHourNumpicker.Text == "" || positionCB.SelectedItem == null  || userNameTF.Text == "" || userPasswordTF.Text == "" || validUserName != true || validBirthNumber != true)
            {
                if (firstNameTF.Text == "") { firstNameTT.Visible = true; } else { firstNameTT.Visible = false; }
                if (secondNameTF.Text == "") { secondNameTT.Visible = true; } else { secondNameTT.Visible = false; }
                if (birthNumberTF.Text == "") { birthNumberTT.Visible = true; } else { birthNumberTT.Visible = false; }
                if (dateTimePicker.Value == null) { workerStartTT.Visible = true; } else { workerStartTT.Visible = false; }
                if (moneyPerHourNumpicker.Text == "") { moneyPerHourTT.Visible = true; } else { moneyPerHourTT.Visible = false; }
                if (positionCB.SelectedItem == null) { workerPositionTT.Visible = true; } else { workerPositionTT.Visible = false; }
                if (userNameTF.Text == "") { userNameTT.Visible = true; } else { userNameTT.Visible = false; }
                if (userPasswordTF.Text == "") { userPasswordTT.Visible = true; } else { userPasswordTT.Visible = false; }
            } else
            {
                int positionId = findPositionId();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO zamestnanec (jmeno_zamestnanec, prijmeni_zamestnanec, rodne_cislo, datum_nastupu, hodinova_mzda, mzda, pozice_idpozice, nazev_uctu, heslo) VALUES (@jmeno_zamestnanec, @prijmeni_zamestnanec, @rodne_cislo, @datum_nastupu, @hodinova_mzda, @mzda, @pozice_idpozice, @nazev_uctu, @heslo)", conn);

                cmd.Parameters.AddWithValue("@jmeno_zamestnanec", firstNameTF.Text);
                cmd.Parameters.AddWithValue("@prijmeni_zamestnanec", secondNameTF.Text);
                cmd.Parameters.AddWithValue("@rodne_cislo", birthNumberTF.Text);
                cmd.Parameters.AddWithValue("@datum_nastupu", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@hodinova_mzda", moneyPerHourNumpicker.Text);
                cmd.Parameters.AddWithValue("@mzda", 0);
                cmd.Parameters.AddWithValue("@pozice_idpozice", positionId);
                cmd.Parameters.AddWithValue("@nazev_uctu", userNameTF.Text);
                cmd.Parameters.AddWithValue("@heslo", userPasswordTF.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }

        private int findPositionId()
        {
            Pozice pozice = positionCB.SelectedItem as Pozice;

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idpozice FROM pozice WHERE nazev_pozice = @nazev_pozice", conn);
            cmd.Parameters.Add(new SqlParameter("@nazev_pozice", SqlDbType.VarChar));
            cmd.Parameters["@nazev_pozice"].Value = pozice.nazev;
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }

        private Boolean compareBirthNumber()
        {
            Boolean validBirthNumber = true;

            string query = "select rodne_cislo from zamestnanec";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["rodne_cislo"].ToString().Equals(birthNumberTF.Text))
                {
                    validBirthNumber = false;
                }
            }

            conn.Close();

            if (validBirthNumber == false) { birthNumberWarning.Visible = true; } else { birthNumberWarning.Visible = false; }

            return validBirthNumber;
        }

        private Boolean compareUserName()
        {
            Boolean validUserName = true;

            string query = "select nazev_uctu from zamestnanec";
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

            string query2 = "select nazev_uctu from zakaznik";
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
