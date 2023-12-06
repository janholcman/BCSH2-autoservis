namespace WindowsFormsApp1
{
    partial class WorkerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enumEditBtn = new System.Windows.Forms.Button();
            this.workerListBtn = new System.Windows.Forms.Button();
            this.KlientListBtn = new System.Windows.Forms.Button();
            this.carListBtn = new System.Windows.Forms.Button();
            this.contractListBtn = new System.Windows.Forms.Button();
            this.userInfoBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addWorkerBtn = new System.Windows.Forms.Button();
            this.workerDataGrid = new System.Windows.Forms.DataGridView();
            this.idzamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenozamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmenizamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodnecisloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumnastupuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodinovamzdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mzdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poziceidpoziceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewButtonColumn();
            this.zamestnanecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet5 = new WindowsFormsApp1.Database1DataSet5();
            this.zamestnanecTableAdapter = new WindowsFormsApp1.Database1DataSet5TableAdapters.zamestnanecTableAdapter();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // enumEditBtn
            // 
            this.enumEditBtn.Location = new System.Drawing.Point(532, 12);
            this.enumEditBtn.Name = "enumEditBtn";
            this.enumEditBtn.Size = new System.Drawing.Size(99, 23);
            this.enumEditBtn.TabIndex = 13;
            this.enumEditBtn.Text = "Úprava číselníků";
            this.enumEditBtn.UseVisualStyleBackColor = true;
            this.enumEditBtn.Click += new System.EventHandler(this.enumEditBtn_Click);
            // 
            // workerListBtn
            // 
            this.workerListBtn.Enabled = false;
            this.workerListBtn.Location = new System.Drawing.Point(417, 12);
            this.workerListBtn.Name = "workerListBtn";
            this.workerListBtn.Size = new System.Drawing.Size(108, 23);
            this.workerListBtn.TabIndex = 12;
            this.workerListBtn.Text = "Výpis zaměstnanců";
            this.workerListBtn.UseVisualStyleBackColor = true;
            // 
            // KlientListBtn
            // 
            this.KlientListBtn.Location = new System.Drawing.Point(317, 12);
            this.KlientListBtn.Name = "KlientListBtn";
            this.KlientListBtn.Size = new System.Drawing.Size(93, 23);
            this.KlientListBtn.TabIndex = 11;
            this.KlientListBtn.Text = "Výpis zákazníků";
            this.KlientListBtn.UseVisualStyleBackColor = true;
            this.KlientListBtn.Click += new System.EventHandler(this.KlientListBtn_Click);
            // 
            // carListBtn
            // 
            this.carListBtn.Location = new System.Drawing.Point(235, 12);
            this.carListBtn.Name = "carListBtn";
            this.carListBtn.Size = new System.Drawing.Size(75, 23);
            this.carListBtn.TabIndex = 10;
            this.carListBtn.Text = "Výpis aut";
            this.carListBtn.UseVisualStyleBackColor = true;
            this.carListBtn.Click += new System.EventHandler(this.carListBtn_Click);
            // 
            // contractListBtn
            // 
            this.contractListBtn.Location = new System.Drawing.Point(138, 12);
            this.contractListBtn.Name = "contractListBtn";
            this.contractListBtn.Size = new System.Drawing.Size(90, 23);
            this.contractListBtn.TabIndex = 9;
            this.contractListBtn.Text = "Výpis zakázek";
            this.contractListBtn.UseVisualStyleBackColor = true;
            this.contractListBtn.Click += new System.EventHandler(this.contractListBtn_Click);
            // 
            // userInfoBtn
            // 
            this.userInfoBtn.Location = new System.Drawing.Point(12, 12);
            this.userInfoBtn.Name = "userInfoBtn";
            this.userInfoBtn.Size = new System.Drawing.Size(120, 23);
            this.userInfoBtn.TabIndex = 8;
            this.userInfoBtn.Text = "Uživatelské informace";
            this.userInfoBtn.UseVisualStyleBackColor = true;
            this.userInfoBtn.Click += new System.EventHandler(this.userInfoBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(707, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Odhlásit";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshBtn);
            this.groupBox1.Controls.Add(this.addWorkerBtn);
            this.groupBox1.Controls.Add(this.workerDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 396);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam pracovníků";
            // 
            // addWorkerBtn
            // 
            this.addWorkerBtn.Location = new System.Drawing.Point(625, 20);
            this.addWorkerBtn.Name = "addWorkerBtn";
            this.addWorkerBtn.Size = new System.Drawing.Size(144, 23);
            this.addWorkerBtn.TabIndex = 1;
            this.addWorkerBtn.Text = "Přidat zaměstnance";
            this.addWorkerBtn.UseVisualStyleBackColor = true;
            this.addWorkerBtn.Click += new System.EventHandler(this.addWorkerBtn_Click);
            // 
            // workerDataGrid
            // 
            this.workerDataGrid.AutoGenerateColumns = false;
            this.workerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzamestnanecDataGridViewTextBoxColumn,
            this.jmenozamestnanecDataGridViewTextBoxColumn,
            this.prijmenizamestnanecDataGridViewTextBoxColumn,
            this.rodnecisloDataGridViewTextBoxColumn,
            this.datumnastupuDataGridViewTextBoxColumn,
            this.hodinovamzdaDataGridViewTextBoxColumn,
            this.mzdaDataGridViewTextBoxColumn,
            this.poziceidpoziceDataGridViewTextBoxColumn,
            this.login});
            this.workerDataGrid.DataSource = this.zamestnanecBindingSource;
            this.workerDataGrid.Location = new System.Drawing.Point(6, 20);
            this.workerDataGrid.Name = "workerDataGrid";
            this.workerDataGrid.Size = new System.Drawing.Size(612, 370);
            this.workerDataGrid.TabIndex = 0;
            // 
            // idzamestnanecDataGridViewTextBoxColumn
            // 
            this.idzamestnanecDataGridViewTextBoxColumn.DataPropertyName = "idzamestnanec";
            this.idzamestnanecDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idzamestnanecDataGridViewTextBoxColumn.Name = "idzamestnanecDataGridViewTextBoxColumn";
            this.idzamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jmenozamestnanecDataGridViewTextBoxColumn
            // 
            this.jmenozamestnanecDataGridViewTextBoxColumn.DataPropertyName = "jmeno_zamestnanec";
            this.jmenozamestnanecDataGridViewTextBoxColumn.HeaderText = "Jmeno";
            this.jmenozamestnanecDataGridViewTextBoxColumn.Name = "jmenozamestnanecDataGridViewTextBoxColumn";
            this.jmenozamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prijmenizamestnanecDataGridViewTextBoxColumn
            // 
            this.prijmenizamestnanecDataGridViewTextBoxColumn.DataPropertyName = "prijmeni_zamestnanec";
            this.prijmenizamestnanecDataGridViewTextBoxColumn.HeaderText = "Příjmení";
            this.prijmenizamestnanecDataGridViewTextBoxColumn.Name = "prijmenizamestnanecDataGridViewTextBoxColumn";
            this.prijmenizamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodnecisloDataGridViewTextBoxColumn
            // 
            this.rodnecisloDataGridViewTextBoxColumn.DataPropertyName = "rodne_cislo";
            this.rodnecisloDataGridViewTextBoxColumn.HeaderText = "Rodné číslo";
            this.rodnecisloDataGridViewTextBoxColumn.Name = "rodnecisloDataGridViewTextBoxColumn";
            this.rodnecisloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumnastupuDataGridViewTextBoxColumn
            // 
            this.datumnastupuDataGridViewTextBoxColumn.DataPropertyName = "datum_nastupu";
            this.datumnastupuDataGridViewTextBoxColumn.HeaderText = "Datum nástupu";
            this.datumnastupuDataGridViewTextBoxColumn.Name = "datumnastupuDataGridViewTextBoxColumn";
            this.datumnastupuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hodinovamzdaDataGridViewTextBoxColumn
            // 
            this.hodinovamzdaDataGridViewTextBoxColumn.DataPropertyName = "hodinova_mzda";
            this.hodinovamzdaDataGridViewTextBoxColumn.HeaderText = "Hodinová mzda";
            this.hodinovamzdaDataGridViewTextBoxColumn.Name = "hodinovamzdaDataGridViewTextBoxColumn";
            this.hodinovamzdaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mzdaDataGridViewTextBoxColumn
            // 
            this.mzdaDataGridViewTextBoxColumn.DataPropertyName = "mzda";
            this.mzdaDataGridViewTextBoxColumn.HeaderText = "mzda";
            this.mzdaDataGridViewTextBoxColumn.Name = "mzdaDataGridViewTextBoxColumn";
            this.mzdaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poziceidpoziceDataGridViewTextBoxColumn
            // 
            this.poziceidpoziceDataGridViewTextBoxColumn.DataPropertyName = "pozice_idpozice";
            this.poziceidpoziceDataGridViewTextBoxColumn.HeaderText = "ID pozice";
            this.poziceidpoziceDataGridViewTextBoxColumn.Name = "poziceidpoziceDataGridViewTextBoxColumn";
            this.poziceidpoziceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // login
            // 
            this.login.HeaderText = "Přihlášení";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.login.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.login.Text = "Přihlášení";
            this.login.ToolTipText = "Přihlášení";
            this.login.UseColumnTextForButtonValue = true;
            // 
            // zamestnanecBindingSource
            // 
            this.zamestnanecBindingSource.DataMember = "zamestnanec";
            this.zamestnanecBindingSource.DataSource = this.database1DataSet5;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamestnanecTableAdapter
            // 
            this.zamestnanecTableAdapter.ClearBeforeFill = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(625, 50);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(144, 23);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Znovu načíst seznam";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // WorkerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.enumEditBtn);
            this.Controls.Add(this.workerListBtn);
            this.Controls.Add(this.KlientListBtn);
            this.Controls.Add(this.carListBtn);
            this.Controls.Add(this.contractListBtn);
            this.Controls.Add(this.userInfoBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "WorkerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pracovníci";
            this.Load += new System.EventHandler(this.WorkerList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enumEditBtn;
        private System.Windows.Forms.Button workerListBtn;
        private System.Windows.Forms.Button KlientListBtn;
        private System.Windows.Forms.Button carListBtn;
        private System.Windows.Forms.Button contractListBtn;
        private System.Windows.Forms.Button userInfoBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource zamestnanecBindingSource;
        private Database1DataSet5TableAdapters.zamestnanecTableAdapter zamestnanecTableAdapter;
        private System.Windows.Forms.DataGridView workerDataGrid;
        private System.Windows.Forms.Button addWorkerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzamestnanecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenozamestnanecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmenizamestnanecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodnecisloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumnastupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodinovamzdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mzdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poziceidpoziceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn login;
        private System.Windows.Forms.Button refreshBtn;
    }
}