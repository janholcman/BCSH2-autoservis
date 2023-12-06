using GUI.Objects;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Backend
{
    public partial class NewCarForm : Form
    {
        SqlConnection conn;
        public NewCarForm(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            importOwnerDataIntoCombobox();
            importCarTypeDataIntoCombobox();
            importPojistovnaDataIntoCombobox();
        }

        private void importOwnerDataIntoCombobox()
        {
            try
            {
                string query = "select jmeno_majitele, prijmeni_majitele, vlastni_od from majitel";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Majitel majitel = new Majitel(dt.Rows[i]["jmeno_majitele"].ToString(), dt.Rows[i]["prijmeni_majitele"].ToString());

                    ownerCB.Items.Add(majitel);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void importCarTypeDataIntoCombobox()
        {
            try
            {
                string query = "select nazev_modelu, typ_automobilu, nazev_vyrobce from modely";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Model model = new Model(dt.Rows[i]["nazev_modelu"].ToString(), dt.Rows[i]["typ_automobilu"].ToString(), dt.Rows[i]["nazev_vyrobce"].ToString());

                    typeCB.Items.Add(model);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void importPojistovnaDataIntoCombobox()
        {
            try
            {
                string query = "select pojistovna from pojistovna";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Pojistovna pojistovna = new Pojistovna(dt.Rows[i]["pojistovna"].ToString());

                    pojistovnaCB.Items.Add(pojistovna);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void addOwnerBtn_Click(object sender, EventArgs e)
        {
            NewOwnerForm form = new NewOwnerForm(conn, this);
            form.Show();
        }

        public void resetOwnerCB()
        {
            ownerCB.Items.Clear();
            importOwnerDataIntoCombobox();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Boolean validSPZ = compareSPZ();
            Boolean validVIN = compareVIN();

            if (vinTF.Text == "" || spzTF.Text == "" || typeCB.SelectedItem == null || pojistovnaCB.SelectedItem == null || ownerCB.SelectedItem == null || validSPZ != true || validVIN != true)
            {
                if (vinTF.Text == "") { vinTT.Visible = true; } else { vinTT.Visible = false; }
                if (spzTF.Text == "") { spzTT.Visible = true; } else { spzTT.Visible = false; }
                if (typeCB.SelectedItem == null) { typeTT.Visible = true; } else { typeTT.Visible = false; }
                if (pojistovnaCB.SelectedItem == null) { pojistovnaTT.Visible = true; } else { pojistovnaTT.Visible = false; }
                if (ownerCB.SelectedItem == null) { ownerTT.Visible = true; } else { ownerTT.Visible = false; }
            } else
            {
                int carTypeId = findModelId();
                int pojistovnaId = findPojistovnaId();
                int ownerId = findOwnerId();

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO automobil (vin, spz, rok_vyroby, modely_idmodel, pojistovna_idpojistovna, majitel_idmajitel) VALUES (@vin, @spz, @rok_vyroby, @modely_idmodel, @pojistovna_idpojistovna, @majitel_idmajitel)", conn);

                cmd.Parameters.AddWithValue("@vin", vinTF.Text);
                cmd.Parameters.AddWithValue("@spz", spzTF.Text);
                cmd.Parameters.AddWithValue("@rok_vyroby", createDateNS.Value);
                cmd.Parameters.AddWithValue("@modely_idmodel", carTypeId);
                cmd.Parameters.AddWithValue("@pojistovna_idpojistovna", pojistovnaId);
                cmd.Parameters.AddWithValue("@majitel_idmajitel", ownerId);

                cmd.ExecuteNonQuery();
                conn.Close();

                this.Close();
            }
        }

        private Boolean compareSPZ()
        {
            Boolean validSPZ = true;

            string query = "select spz from automobil";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["spz"].ToString().Equals(spzTF.Text))
                {
                    validSPZ = false;
                }
            }

            conn.Close();

            if (validSPZ == false) { spzWarning.Visible = true; } else { spzWarning.Visible = false; }

            return validSPZ;
        }

        private Boolean compareVIN()
        {
            Boolean validateVIN = true;

            string query = "select vin from automobil";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["vin"].ToString().Equals(vinTF.Text))
                {
                    validateVIN = false;
                }
            }

            conn.Close();

            if (validateVIN == false) { vinWarning.Visible = true; } else { vinWarning.Visible = false; }

            return validateVIN;
        }

        private int findModelId()
        {
            Model model = typeCB.SelectedItem as Model;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select idmodel from modely WHERE nazev_modelu = @nazev_modelu AND typ_automobilu = @typ_automobilu AND nazev_vyrobce = @nazev_vyrobce", conn);
            cmd.Parameters.Add(new SqlParameter("@nazev_modelu", SqlDbType.VarChar));
            cmd.Parameters["@nazev_modelu"].Value = model.Nazev;
            cmd.Parameters.Add(new SqlParameter("@typ_automobilu", SqlDbType.VarChar));
            cmd.Parameters["@typ_automobilu"].Value = model.Typ;
            cmd.Parameters.Add(new SqlParameter("@nazev_vyrobce", SqlDbType.VarChar));
            cmd.Parameters["@nazev_vyrobce"].Value = model.Vyrobce;
            
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }

        private int findPojistovnaId()
        {
            Pojistovna pojistovna = pojistovnaCB.SelectedItem as Pojistovna;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select idpojistovna from pojistovna WHERE pojistovna = @pojistovna", conn);
            cmd.Parameters.Add(new SqlParameter("@pojistovna", SqlDbType.VarChar));
            cmd.Parameters["@pojistovna"].Value = pojistovna.nazev;
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }

        private int findOwnerId()
        {
            Majitel majitel = ownerCB.SelectedItem as Majitel;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select idmajitel from majitel WHERE jmeno_majitele = @jmeno_majitele AND prijmeni_majitele = @prijmeni_majitele", conn);
            cmd.Parameters.Add(new SqlParameter("@jmeno_majitele", SqlDbType.VarChar));
            cmd.Parameters["@jmeno_majitele"].Value = majitel.Jmeno;
            cmd.Parameters.Add(new SqlParameter("@prijmeni_majitele", SqlDbType.VarChar));
            cmd.Parameters["@prijmeni_majitele"].Value = majitel.Prijmeni;
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            int id = reader.GetInt32(0);

            conn.Close();
            return id;
        }
    }
}
