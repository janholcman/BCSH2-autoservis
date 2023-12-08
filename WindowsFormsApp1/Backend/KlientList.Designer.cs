namespace WindowsFormsApp1
{
    partial class KlientList
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
            this.editBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addKlientBtn = new System.Windows.Forms.Button();
            this.KlientDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenozakaznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmenizakaznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenofirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewButtonColumn();
            this.zakaznikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new WindowsFormsApp1.Database1DataSet4();
            this.zakaznikTableAdapter = new WindowsFormsApp1.Database1DataSet4TableAdapters.zakaznikTableAdapter();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KlientDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
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
            this.workerListBtn.Location = new System.Drawing.Point(417, 12);
            this.workerListBtn.Name = "workerListBtn";
            this.workerListBtn.Size = new System.Drawing.Size(108, 23);
            this.workerListBtn.TabIndex = 12;
            this.workerListBtn.Text = "Výpis zaměstnanců";
            this.workerListBtn.UseVisualStyleBackColor = true;
            this.workerListBtn.Click += new System.EventHandler(this.workerListBtn_Click);
            // 
            // KlientListBtn
            // 
            this.KlientListBtn.Enabled = false;
            this.KlientListBtn.Location = new System.Drawing.Point(317, 12);
            this.KlientListBtn.Name = "KlientListBtn";
            this.KlientListBtn.Size = new System.Drawing.Size(93, 23);
            this.KlientListBtn.TabIndex = 11;
            this.KlientListBtn.Text = "Výpis zákazníků";
            this.KlientListBtn.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.refreshBtn);
            this.groupBox1.Controls.Add(this.addKlientBtn);
            this.groupBox1.Controls.Add(this.KlientDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 396);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam zákazníků";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(625, 79);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(144, 23);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "Upravit položku";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(626, 50);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(144, 23);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Znovu načíst seznam";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addKlientBtn
            // 
            this.addKlientBtn.Location = new System.Drawing.Point(626, 20);
            this.addKlientBtn.Name = "addKlientBtn";
            this.addKlientBtn.Size = new System.Drawing.Size(144, 23);
            this.addKlientBtn.TabIndex = 1;
            this.addKlientBtn.Text = "Přidat zákazníka";
            this.addKlientBtn.UseVisualStyleBackColor = true;
            this.addKlientBtn.Click += new System.EventHandler(this.addKlientBtn_Click);
            // 
            // KlientDataGrid
            // 
            this.KlientDataGrid.AutoGenerateColumns = false;
            this.KlientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KlientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.jmenozakaznikDataGridViewTextBoxColumn,
            this.prijmenizakaznikDataGridViewTextBoxColumn,
            this.jmenofirmyDataGridViewTextBoxColumn,
            this.login});
            this.KlientDataGrid.DataSource = this.zakaznikBindingSource;
            this.KlientDataGrid.Location = new System.Drawing.Point(7, 20);
            this.KlientDataGrid.Name = "KlientDataGrid";
            this.KlientDataGrid.Size = new System.Drawing.Size(612, 370);
            this.KlientDataGrid.TabIndex = 0;
            this.KlientDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.klientGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idzakaznik";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // jmenozakaznikDataGridViewTextBoxColumn
            // 
            this.jmenozakaznikDataGridViewTextBoxColumn.DataPropertyName = "jmeno_zakaznik";
            this.jmenozakaznikDataGridViewTextBoxColumn.HeaderText = "Jméno";
            this.jmenozakaznikDataGridViewTextBoxColumn.Name = "jmenozakaznikDataGridViewTextBoxColumn";
            this.jmenozakaznikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prijmenizakaznikDataGridViewTextBoxColumn
            // 
            this.prijmenizakaznikDataGridViewTextBoxColumn.DataPropertyName = "prijmeni_zakaznik";
            this.prijmenizakaznikDataGridViewTextBoxColumn.HeaderText = "Příjmení";
            this.prijmenizakaznikDataGridViewTextBoxColumn.Name = "prijmenizakaznikDataGridViewTextBoxColumn";
            this.prijmenizakaznikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jmenofirmyDataGridViewTextBoxColumn
            // 
            this.jmenofirmyDataGridViewTextBoxColumn.DataPropertyName = "jmeno_firmy";
            this.jmenofirmyDataGridViewTextBoxColumn.HeaderText = "Název firmy";
            this.jmenofirmyDataGridViewTextBoxColumn.Name = "jmenofirmyDataGridViewTextBoxColumn";
            this.jmenofirmyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // login
            // 
            this.login.HeaderText = "Přihlášení";
            this.login.Name = "login";
            this.login.Text = "Přihlášení";
            this.login.ToolTipText = "Přihlášení";
            this.login.UseColumnTextForButtonValue = true;
            // 
            // zakaznikBindingSource
            // 
            this.zakaznikBindingSource.DataMember = "zakaznik";
            this.zakaznikBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakaznikTableAdapter
            // 
            this.zakaznikTableAdapter.ClearBeforeFill = true;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // KlientList
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
            this.Name = "KlientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zákazníci";
            this.Load += new System.EventHandler(this.KlientList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KlientDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
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
        private System.Windows.Forms.DataGridView KlientDataGrid;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource zakaznikBindingSource;
        private Database1DataSet4TableAdapters.zakaznikTableAdapter zakaznikTableAdapter;
        private System.Windows.Forms.Button addKlientBtn;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button refreshBtn;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenozakaznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmenizakaznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenofirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn login;
        private System.Windows.Forms.Button editBtn;
    }
}