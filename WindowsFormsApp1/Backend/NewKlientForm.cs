using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApp1.Backend
{
    public partial class NewKlientForm : Form
    {
        KlientList klientForm;
        SqlConnection conn;

        public NewKlientForm(KlientList klientForm, SqlConnection conn)
        {
            InitializeComponent();
            this.klientForm = klientForm;
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
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    adresCB.Items.Add(dt.Rows[i]["mesto"].ToString() + ", " + 
                        dt.Rows[i]["ulice"].ToString() + " " + 
                        dt.Rows[i]["cislo_popisne"].ToString() + ", " + 
                        dt.Rows[i]["psc"].ToString());
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
            if (firstNameTF.Text == "" || secondNameTF.Text == "" || adresCB.SelectedItem == null || userNameTF.Text == "" || userPasswordTF.Text == "")
            {
                if (firstNameTF.Text == "") { firstNameTT.Visible = true; } else { firstNameTT.Visible = false; }
                if (secondNameTF.Text == "") { secondNameTT.Visible = true; } else { secondNameTT.Visible = false; }
                if (userNameTF.Text == "") { userNameTT.Visible = true; } else { userNameTT.Visible = false; }
                if (userPasswordTF.Text == "") { userPasswordTT.Visible = true; } else { userPasswordTT.Visible = false; }
                if (adresCB.Text == "") { adressTT.Visible = true; } else { adressTT.Visible = false; }
                this.Refresh();
            }
            else
            {

            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAdresBtn_Click(object sender, EventArgs e)
        {
            NewAdresForm form = new NewAdresForm(this, conn);
            form.Show();
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
