using GUI.Objects;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1.Backend
{
    public partial class NewAdresForm : Form
    {
        SqlConnection conn;
        NewKlientForm newKlienForm;

        public NewAdresForm(SqlConnection conn, NewKlientForm form)
        {
            this.newKlienForm = form;
            InitializeComponent();
            this.conn = conn;
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, System.EventArgs e)
        {
            if (cityTF.Text == "" || streetTF.Text == "" || houseNumberTF.Text == "" || pscTF.Text == "")
            {
                if (cityTF.Text == "") { firstNameTT.Visible = true; } else { firstNameTT.Visible = false; }
                if (streetTF.Text == "") { secondNameTT.Visible = true; } else { secondNameTT.Visible = false; }
                if (houseNumberTF.Text == "") { houseNumberTT.Visible = true; } else { houseNumberTT.Visible = false; }
                if (pscTF.Text == "") { pscTT.Visible = true; } else { pscTT.Visible = false; }
            } else
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO adresa (mesto, ulice, cislo_popisne, psc) VALUES (@mesto, @ulice, @cislo_popisne, @psc)";
                cmd.Parameters.AddWithValue("@mesto", cityTF.Text);
                cmd.Parameters.AddWithValue("@ulice", streetTF.Text);
                cmd.Parameters.AddWithValue("@cislo_popisne", houseNumberTF.Text);
                cmd.Parameters.AddWithValue("@psc", pscTF.Text);
                
                cmd.ExecuteNonQuery();
                conn.Close();
                newKlienForm.resetAdresCB();
                this.Close();
            }
            
        }
    }
}
