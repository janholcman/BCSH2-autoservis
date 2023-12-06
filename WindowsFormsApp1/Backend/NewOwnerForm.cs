using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Backend
{
    public partial class NewOwnerForm : Form
    {
        SqlConnection conn;
        NewCarForm newCarForm;

        public NewOwnerForm(SqlConnection conn, NewCarForm form)
        {
            this.newCarForm = form;
            InitializeComponent();
            this.conn = conn;
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, System.EventArgs e)
        {
            if (firstNameTF.Text == "" || secondNameTF.Text == "" )
            {
                if (firstNameTF.Text == "") { firstNameTT.Visible = true; } else { firstNameTT.Visible = false; }
                if (secondNameTF.Text == "") { secondNameTT.Visible = true; } else { secondNameTT.Visible = false; }
            }else
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO majitel (jmeno_majitele, prijmeni_majitele, vlastni_od) VALUES (@jmeno_majitele, @prijmeni_majitele, @vlastni_od)";
                cmd.Parameters.AddWithValue("@jmeno_majitele", firstNameTF.Text);
                cmd.Parameters.AddWithValue("@prijmeni_majitele", secondNameTF.Text);
                cmd.Parameters.AddWithValue("@vlastni_od", dateTimePicker.Value);

                cmd.ExecuteNonQuery();
                conn.Close();
                newCarForm.resetOwnerCB();
                this.Close();
            }
            
        }
    }
}
