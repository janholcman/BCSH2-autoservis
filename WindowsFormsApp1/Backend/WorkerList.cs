using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WorkerList : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        public WorkerList(Homepage form, SqlConnection conn)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            Account form = new Account(hmpForm, conn);
            form.Show();
            this.Hide();
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            ContractList form = new ContractList(hmpForm, conn);
            form.Show();
            this.Hide();
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            CarList form = new CarList(hmpForm, conn);
            form.Show();
            this.Hide();
        }

        private void KlientListBtn_Click(object sender, EventArgs e)
        {
            KlientList form = new KlientList(hmpForm, conn);
            form.Show();
            this.Hide();
        }

        private void enumEditBtn_Click(object sender, EventArgs e)
        {
            EnumEditor form = new EnumEditor(hmpForm, conn);
            form.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            hmpForm.Show();
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet5.zamestnanec'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zamestnanecTableAdapter.Fill(this.database1DataSet5.zamestnanec);

        }
    }
}
