namespace WindowsFormsApp1
{
    partial class ContractList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zakazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet1();
            this.zakazkaTableAdapter = new WindowsFormsApp1.Database1DataSet1TableAdapters.zakazkaTableAdapter();
            this.idzakazkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startzakazkyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koneczakazkyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecidzamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
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
            this.contractListBtn.Enabled = false;
            this.contractListBtn.Location = new System.Drawing.Point(138, 12);
            this.contractListBtn.Name = "contractListBtn";
            this.contractListBtn.Size = new System.Drawing.Size(90, 23);
            this.contractListBtn.TabIndex = 9;
            this.contractListBtn.Text = "Výpis zakázek";
            this.contractListBtn.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 396);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam zakázek";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzakazkaDataGridViewTextBoxColumn,
            this.startzakazkyDataGridViewTextBoxColumn,
            this.koneczakazkyDataGridViewTextBoxColumn,
            this.zamestnanecidzamestnanecDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // zakazkaBindingSource
            // 
            this.zakazkaBindingSource.DataMember = "zakazka";
            this.zakazkaBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazkaTableAdapter
            // 
            this.zakazkaTableAdapter.ClearBeforeFill = true;
            // 
            // idzakazkaDataGridViewTextBoxColumn
            // 
            this.idzakazkaDataGridViewTextBoxColumn.DataPropertyName = "idzakazka";
            this.idzakazkaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idzakazkaDataGridViewTextBoxColumn.Name = "idzakazkaDataGridViewTextBoxColumn";
            this.idzakazkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startzakazkyDataGridViewTextBoxColumn
            // 
            this.startzakazkyDataGridViewTextBoxColumn.DataPropertyName = "start_zakazky";
            this.startzakazkyDataGridViewTextBoxColumn.HeaderText = "Start zakázky";
            this.startzakazkyDataGridViewTextBoxColumn.Name = "startzakazkyDataGridViewTextBoxColumn";
            this.startzakazkyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koneczakazkyDataGridViewTextBoxColumn
            // 
            this.koneczakazkyDataGridViewTextBoxColumn.DataPropertyName = "konec_zakazky";
            this.koneczakazkyDataGridViewTextBoxColumn.HeaderText = "Konec zakázky";
            this.koneczakazkyDataGridViewTextBoxColumn.Name = "koneczakazkyDataGridViewTextBoxColumn";
            this.koneczakazkyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zamestnanecidzamestnanecDataGridViewTextBoxColumn
            // 
            this.zamestnanecidzamestnanecDataGridViewTextBoxColumn.DataPropertyName = "zamestnanec_idzamestnanec";
            this.zamestnanecidzamestnanecDataGridViewTextBoxColumn.HeaderText = "ID zaměstnance";
            this.zamestnanecidzamestnanecDataGridViewTextBoxColumn.Name = "zamestnanecidzamestnanecDataGridViewTextBoxColumn";
            this.zamestnanecidzamestnanecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ContractList
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
            this.Name = "ContractList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ContractList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource zakazkaBindingSource;
        private Database1DataSet1TableAdapters.zakazkaTableAdapter zakazkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startzakazkyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koneczakazkyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecidzamestnanecDataGridViewTextBoxColumn;
    }
}