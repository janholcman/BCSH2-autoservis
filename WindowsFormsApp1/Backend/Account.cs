using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Account : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        public Account(Homepage form, SqlConnection conn)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            ContractList form = new ContractList(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            CarList form = new CarList(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void KlientListBtn_Click(object sender, EventArgs e)
        {
            KlientList form = new KlientList(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void workerListBtn_Click(object sender, EventArgs e)
        {
            WorkerList form = new WorkerList(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void enumEditBtn_Click(object sender, EventArgs e)
        {
            EnumEditor form = new EnumEditor(hmpForm, conn);
            form.Show();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            hmpForm.Show();
        }
    }
}
