﻿using GUI.Objects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.Database1DataSet4TableAdapters;

namespace WindowsFormsApp1
{
    public partial class ContractList : Form
    {
        Homepage hmpForm;
        SqlConnection conn;
        Zakaznik zakaznik;
        Zamestnanec zamestnanec;
        int idPozice;
        public ContractList(Homepage form, SqlConnection conn, Zamestnanec zamestnanec)
        {
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;
            this.zamestnanec = zamestnanec;

            if (zamestnanec.Pozice == 2)
            {
                enumEditBtn.Visible = false;
            }
        }

        public ContractList(Homepage form, SqlConnection conn, Zakaznik zakaznik)
        {
            this.zakaznik = zakaznik;
            this.hmpForm = form;
            InitializeComponent();
            this.conn = conn;

            this.idPozice = 3;
            KlientListBtn.Visible = false;
            workerListBtn.Visible = false;
            enumEditBtn.Visible = false;
            addContractBtn.Visible = false;
            resetBtn.Visible = false;
        }

        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            if (idPozice == 3)
            {
                Account formKlient = new Account(hmpForm, conn, zakaznik);
                formKlient.Show();
                this.Close();
            }
            else
            {
                Account form = new Account(hmpForm, conn, zamestnanec);
                form.Show();
                this.Close();
            }
        }

        private void carListBtn_Click(object sender, EventArgs e)
        {
            if (idPozice == 3)
            {
                CarList formKlient = new CarList(hmpForm, conn, zakaznik);
                formKlient.Show();
                this.Close();
            } else
            {
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

        private void ContractList_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet1.zakazka'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.zakazkaTableAdapter.Fill(this.database1DataSet1.zakazka);

        }

        private void addContractBtn_Click(object sender, EventArgs e)
        {
            NewContractForm form = new NewContractForm(conn);
            form.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            contractDataGrid.DataSource = null;
            loaddata();
        }

        private void loaddata()
        {
            conn.Open();

            string query = "SELECT * FROM zakazka WHERE";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            contractDataGrid.DataSource = dt;

            conn.Close();
        }
    }
}
