namespace WindowsFormsApp1
{
    partial class EnumEditor
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
            this.idpojistovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojistovnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojistovnaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new WindowsFormsApp1.Database1DataSet2();
            this.pojistovnaEditBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idpoziceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevpoziceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poziceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new WindowsFormsApp1.Database1DataSet3();
            this.pojistovnaTableAdapter = new WindowsFormsApp1.Database1DataSet2TableAdapters.pojistovnaTableAdapter();
            this.poziceTableAdapter = new WindowsFormsApp1.Database1DataSet3TableAdapters.poziceTableAdapter();
            this.poziceEditbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojistovnaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poziceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // enumEditBtn
            // 
            this.enumEditBtn.Enabled = false;
            this.enumEditBtn.Location = new System.Drawing.Point(532, 12);
            this.enumEditBtn.Name = "enumEditBtn";
            this.enumEditBtn.Size = new System.Drawing.Size(99, 23);
            this.enumEditBtn.TabIndex = 13;
            this.enumEditBtn.Text = "Úprava číselníků";
            this.enumEditBtn.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 368);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Číselník pojišťoven";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpojistovnaDataGridViewTextBoxColumn,
            this.pojistovnaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pojistovnaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpojistovnaDataGridViewTextBoxColumn
            // 
            this.idpojistovnaDataGridViewTextBoxColumn.DataPropertyName = "idpojistovna";
            this.idpojistovnaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idpojistovnaDataGridViewTextBoxColumn.Name = "idpojistovnaDataGridViewTextBoxColumn";
            this.idpojistovnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pojistovnaDataGridViewTextBoxColumn
            // 
            this.pojistovnaDataGridViewTextBoxColumn.DataPropertyName = "pojistovna";
            this.pojistovnaDataGridViewTextBoxColumn.HeaderText = "pojistovna";
            this.pojistovnaDataGridViewTextBoxColumn.Name = "pojistovnaDataGridViewTextBoxColumn";
            this.pojistovnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pojistovnaBindingSource
            // 
            this.pojistovnaBindingSource.DataMember = "pojistovna";
            this.pojistovnaBindingSource.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pojistovnaEditBtn
            // 
            this.pojistovnaEditBtn.Location = new System.Drawing.Point(19, 415);
            this.pojistovnaEditBtn.Name = "pojistovnaEditBtn";
            this.pojistovnaEditBtn.Size = new System.Drawing.Size(163, 23);
            this.pojistovnaEditBtn.TabIndex = 16;
            this.pojistovnaEditBtn.Text = "Upravit číselník pojišťoven";
            this.pojistovnaEditBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(333, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 368);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Číselník Pozic";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpoziceDataGridViewTextBoxColumn,
            this.nazevpoziceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.poziceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(285, 326);
            this.dataGridView2.TabIndex = 0;
            // 
            // idpoziceDataGridViewTextBoxColumn
            // 
            this.idpoziceDataGridViewTextBoxColumn.DataPropertyName = "idpozice";
            this.idpoziceDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idpoziceDataGridViewTextBoxColumn.Name = "idpoziceDataGridViewTextBoxColumn";
            this.idpoziceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazevpoziceDataGridViewTextBoxColumn
            // 
            this.nazevpoziceDataGridViewTextBoxColumn.DataPropertyName = "nazev_pozice";
            this.nazevpoziceDataGridViewTextBoxColumn.HeaderText = "Pozice";
            this.nazevpoziceDataGridViewTextBoxColumn.Name = "nazevpoziceDataGridViewTextBoxColumn";
            this.nazevpoziceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poziceBindingSource
            // 
            this.poziceBindingSource.DataMember = "pozice";
            this.poziceBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pojistovnaTableAdapter
            // 
            this.pojistovnaTableAdapter.ClearBeforeFill = true;
            // 
            // poziceTableAdapter
            // 
            this.poziceTableAdapter.ClearBeforeFill = true;
            // 
            // poziceEditbtn
            // 
            this.poziceEditbtn.Location = new System.Drawing.Point(498, 415);
            this.poziceEditbtn.Name = "poziceEditbtn";
            this.poziceEditbtn.Size = new System.Drawing.Size(132, 23);
            this.poziceEditbtn.TabIndex = 17;
            this.poziceEditbtn.Text = "Upravit číselník pozic";
            this.poziceEditbtn.UseVisualStyleBackColor = true;
            // 
            // EnumEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.poziceEditbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pojistovnaEditBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.enumEditBtn);
            this.Controls.Add(this.workerListBtn);
            this.Controls.Add(this.KlientListBtn);
            this.Controls.Add(this.carListBtn);
            this.Controls.Add(this.contractListBtn);
            this.Controls.Add(this.userInfoBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "EnumEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Číselníky";
            this.Load += new System.EventHandler(this.EnumEditor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojistovnaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poziceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
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
        private System.Windows.Forms.Button pojistovnaEditBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource pojistovnaBindingSource;
        private Database1DataSet2TableAdapters.pojistovnaTableAdapter pojistovnaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource poziceBindingSource;
        private Database1DataSet3TableAdapters.poziceTableAdapter poziceTableAdapter;
        private System.Windows.Forms.Button poziceEditbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpojistovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pojistovnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpoziceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevpoziceDataGridViewTextBoxColumn;
    }
}