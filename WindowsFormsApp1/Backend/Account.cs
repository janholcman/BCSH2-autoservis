using GUI.Objects;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Account : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        Zakaznik zakaznik;
        Zamestnanec zamestnanec;
        int idPozice;

        public Account(Homepage form, SqlConnection conn, Zakaznik zakaznik)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
            this.zakaznik = zakaznik;

            this.idPozice = 3;
            KlientListBtn.Visible = false;
            workerListBtn.Visible = false;
            enumEditBtn.Visible = false;

            workerGroupBox.Visible = false;

            klientFirstNameLabel.Text = zakaznik.Jmeno;
            klientSecondNameLabel.Text = zakaznik.Prijmeni;
            klientIdLabel.Text = zakaznik.Id.ToString();
            klientCompanyLabel.Text = zakaznik.JmenoFirmy;
            klientUserNameLabel.Text = zakaznik.NazevUctu;
            klientPasswordLabel.Text = zakaznik.Heslo;

        }
        public Account(Homepage form, SqlConnection conn, Zamestnanec zamestnanec)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
            this.zamestnanec = zamestnanec;

            this.idPozice = zamestnanec.Pozice;

            klientGroupBox.Visible = false;

            workerFirstNameLabel.Text = zamestnanec.Jmeno;
            workerSecondnameLabel.Text = zamestnanec.Prijmeni;
            workerIdLabel.Text = zamestnanec.Id.ToString();

            if (this.idPozice == 1)
            {
                positionLabel.Text = "Nadřízený";
            } else
            {
                positionLabel.Text = "Zaměstnanec";
                enumEditBtn.Visible = false;
            }

            workerMoneyLabel.Text = zamestnanec.HodinovaMzda.ToString();
            startWorkLabel.Text = zamestnanec.DatumNastupu.ToString();
            birthNumberLabel.Text = zamestnanec.RodneCislo;
            workerUserNameLabel.Text = zamestnanec.UserName;
            workerPasswordLabel.Text = zamestnanec.Password;
        }

        private void contractListBtn_Click(object sender, EventArgs e)
        {
            if (this.idPozice == 3)
            {
                ContractList formKlient = new ContractList(hmpForm, conn, zakaznik);
                formKlient.Show();
                this.Close();
            } else
            {
                ContractList form = new ContractList(hmpForm, conn, zamestnanec);
                form.Show();
                this.Close();
            }
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            if (this.idPozice == 3)
            {
                CarList formKlient = new CarList(hmpForm, conn, zakaznik);
                formKlient.Show();
                this.Close();
            } else {
                CarList form = new CarList(hmpForm, conn, zamestnanec);
                form.Show();
                this.Close();
            }
        }

        private void KlientListBtn_Click(object sender, EventArgs e)
        {
            KlientList form = new KlientList(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void workerListBtn_Click(object sender, EventArgs e)
        {
            WorkerList form = new WorkerList(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void enumEditBtn_Click(object sender, EventArgs e)
        {
            EnumEditor form = new EnumEditor(hmpForm, conn, zamestnanec);
            form.Show();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            hmpForm.Show();
        }

        private void showPasswordKlient_Click(object sender, EventArgs e)
        {
            if (klientPasswordLabel.Visible == true)
            {
                klientPasswordLabel.Visible = false;
            } else
            {
                klientPasswordLabel.Visible = true;
            }
            
        }

        private void showPasswordWorker_Click(object sender, EventArgs e)
        {
            if (workerPasswordLabel.Visible == true)
            {
                workerPasswordLabel.Visible = false;
            }
            else
            {
                workerPasswordLabel.Visible = true;
            }
        }
    }
}
