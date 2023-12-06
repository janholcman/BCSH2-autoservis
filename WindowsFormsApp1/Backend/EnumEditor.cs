using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnumEditor : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        public EnumEditor(Homepage form, SqlConnection conn)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            Account form = new Account(hmpForm, conn);
            form.Show();
            this.Close();
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            hmpForm.Show();
        }

        private void EnumEditor_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet3.pozice'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.poziceTableAdapter.Fill(this.database1DataSet3.pozice);
            // TODO: Tento řádek načte data do tabulky 'database1DataSet2.pojistovna'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.pojistovnaTableAdapter.Fill(this.database1DataSet2.pojistovna);

        }
    }
}
