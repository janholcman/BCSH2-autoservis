using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Backend
{
    public partial class LoginForm : Form
    {
        Homepage hmpForm;
        public LoginForm(Homepage form)
        {
            this.hmpForm = form;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                Account form = new Account(hmpForm);
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
    }
}
