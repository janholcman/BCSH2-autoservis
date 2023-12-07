using GUI.Objects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Backend
{
    public partial class LoginForm : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        public LoginForm(Homepage form, SqlConnection conn)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                if (nameTextBox.Text == "") { userNameTT.Visible = true; } else { userNameTT.Visible = false; }
                if (passwordTextBox.Text == "") { userPasswordTT.Visible = true; } else { userPasswordTT.Visible = false; }
            } 
            //else
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT idzakaznik, jmeno_zakaznik, prijmeni_zakaznik, jmeno_firmy, adresa_idadresa FROM zakaznik WHERE nazev_uctu = @nazev_uctu AND heslo = @heslo", conn);
            //    cmd.Parameters.Add(new SqlParameter("@nazev_uctu", SqlDbType.VarChar));
            //    cmd.Parameters["@nazev_uctu"].Value = nameTextBox.Text;
            //    cmd.Parameters.Add(new SqlParameter("@heslo", SqlDbType.VarChar));
            //    cmd.Parameters["@heslo"].Value = passwordTextBox.Text;
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    reader.Read();

            //    if (reader.HasRows)
            //    {
            //        pripojeno.Text = reader.GetInt32(0).ToString();

            //        int id = reader.GetInt32(0);
            //        string firstName = reader.GetString(1);
            //        string secondName = reader.GetString(2);
            //        string companyName = reader.GetString(3);
            //        int idAdress = reader.GetInt32(4);

            //        Zakaznik zakaznik = new Zakaznik(id, firstName, secondName, companyName, idAdress, nameTextBox.Text, passwordTextBox.Text);

            //        Account form = new Account(hmpForm, conn, zakaznik);
            //        conn.Close();

            //        //debug
            //        pripojeno.Text = id.ToString();

            //        form.Show();
            //        this.Close();
            //        hmpForm.Hide();
            //    }
            //    else
            //    {
            //        reader.Close();
                    

            //        cmd = new SqlCommand("SELECT idzamestnanec, jmeno_zamestnanec, prijmeni_zamestnanec, rodne_cislo, datum_nastupu, hodinova_mzda, mzda, pozice_idpozice FROM zamestnanec WHERE nazev_uctu = @nazev_uctu AND heslo = @heslo", conn);
            //        cmd.Parameters.Add(new SqlParameter("@nazev_uctu", SqlDbType.VarChar));
            //        cmd.Parameters["@nazev_uctu"].Value = nameTextBox.Text;
            //        cmd.Parameters.Add(new SqlParameter("@heslo", SqlDbType.VarChar));
            //        cmd.Parameters["@heslo"].Value = passwordTextBox.Text;
            //        reader = cmd.ExecuteReader();
            //        reader.Read();

            //        if (reader.HasRows)
            //        {
            //            pripojeno.Text = reader.GetInt32(0).ToString();

            //            int id = reader.GetInt32(0);
            //            string firstName = reader.GetString(1);
            //            string secondName = reader.GetString(2);
            //            string birthNumber = reader.GetString(3);
            //            DateTime startWork = reader.GetDateTime(4);
            //            int hourMoney = reader.GetInt32(5);
            //            int monthMoney = 0;
            //            if (!reader.IsDBNull(6))
            //            {
            //                monthMoney = reader.GetInt32(6);
            //            }
            //            int idPosition = reader.GetInt32(7);
            //            string userName = nameTextBox.Text;
            //            string password = passwordTextBox.Text;

            //            Zamestnanec zamestnanec = new Zamestnanec(id, firstName, secondName, birthNumber, startWork, hourMoney, monthMoney, idPosition, userName, password);

            //            Account form = new Account(hmpForm, conn, zamestnanec);
            //            conn.Close();

            //            //debug
            //            pripojeno.Text = id.ToString();

            //            form.Show();
            //            this.Close();
            //            hmpForm.Hide();
            //        }
            //        else
            //        {
            //            errorMessage.Text = "Chybné přihlašovací údaje";
            //            conn.Close();
            //        }
            //    }
            //}

            if (nameTextBox.Text == "a" && passwordTextBox.Text == "a")
            {
                Zakaznik zakaznik = new Zakaznik(1, "Pepa", "Pole",  "Firma", 2, "a" , "a");
                Account form = new Account(hmpForm, conn, zakaznik);
                form.Show();
                this.Close();
                hmpForm.Hide();

            }
            else if (nameTextBox.Text == "b" && passwordTextBox.Text == "b")
            {
                Zamestnanec zakaznik = new Zamestnanec(1, "Pepa", "Pole", "141414/1548", new DateTime(), 15,0, 1, "b", "b"); ;
                Account form = new Account(hmpForm, conn, zakaznik);
                form.Show();
                this.Close();
                hmpForm.Hide();
            }
            else
            {
                errorMessage.Text = "Chybné přihlašovací údaje";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
