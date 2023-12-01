using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KlientList : Form
    {
        Homepage hmpForm;
        public KlientList(Homepage form)
        {
            this.hmpForm = form;
            InitializeComponent();
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            Account form = new Account(hmpForm);
            form.Show();
            this.Hide();
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            ContractList form = new ContractList(hmpForm);
            form.Show();
            this.Hide();
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            CarList form = new CarList(hmpForm);
            form.Show();
            this.Hide();
        }

        private void workerListBtn_Click(object sender, EventArgs e)
        {
            WorkerList form = new WorkerList(hmpForm);
            form.Show();
            this.Hide();
        }

        private void enumEditBtn_Click(object sender, EventArgs e)
        {
            EnumEditor form = new EnumEditor(hmpForm);
            form.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            hmpForm.Show();
        }

        private void KlientList_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet4.zakaznik'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zakaznikTableAdapter.Fill(this.database1DataSet4.zakaznik);

        }
    }
}
