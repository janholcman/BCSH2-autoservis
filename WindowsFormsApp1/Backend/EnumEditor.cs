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
    public partial class EnumEditor : Form
    {
        public EnumEditor()
        {
            InitializeComponent();
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            Account form = new Account();
            form.Show();
            this.Hide();
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            ContractList form = new ContractList();
            form.Show();
            this.Hide();
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            CarList form = new CarList();
            form.Show();
            this.Hide();
        }

        private void KlientListBtn_Click(object sender, EventArgs e)
        {
            KlientList form = new KlientList();
            form.Show();
            this.Hide();
        }

        private void workerListBtn_Click(object sender, EventArgs e)
        {
            WorkerList form = new WorkerList();
            form.Show();
            this.Hide();
        }
    }
}
