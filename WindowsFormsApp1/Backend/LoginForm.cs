using System;
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
            if (nameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                Account form = new Account(hmpForm, conn);
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
