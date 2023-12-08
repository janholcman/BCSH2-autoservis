namespace WindowsFormsApp1
{
    partial class CarList
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
            this.resetBtn = new System.Windows.Forms.Button();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.carListDataGrid = new System.Windows.Forms.DataGridView();
            this.automobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.automobilTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.automobilTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokvyrobyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
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
            this.carListBtn.Enabled = false;
            this.carListBtn.Location = new System.Drawing.Point(235, 12);
            this.carListBtn.Name = "carListBtn";
            this.carListBtn.Size = new System.Drawing.Size(75, 23);
            this.carListBtn.TabIndex = 10;
            this.carListBtn.Text = "Výpis aut";
            this.carListBtn.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.addCarBtn);
            this.groupBox1.Controls.Add(this.carListDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 397);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seznam opravovaných aut";
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
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(626, 50);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(144, 23);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Znovu načíst seznam";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(626, 20);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(144, 23);
            this.addCarBtn.TabIndex = 1;
            this.addCarBtn.Text = "Přidat auto";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // carListDataGrid
            // 
            this.carListDataGrid.AutoGenerateColumns = false;
            this.carListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.vinDataGridViewTextBoxColumn,
            this.spzDataGridViewTextBoxColumn,
            this.rokvyrobyDataGridViewTextBoxColumn});
            this.carListDataGrid.DataSource = this.automobilBindingSource;
            this.carListDataGrid.Location = new System.Drawing.Point(6, 19);
            this.carListDataGrid.Name = "carListDataGrid";
            this.carListDataGrid.Size = new System.Drawing.Size(613, 372);
            this.carListDataGrid.TabIndex = 0;
            // 
            // automobilBindingSource
            // 
            this.automobilBindingSource.DataMember = "automobil";
            this.automobilBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automobilTableAdapter
            // 
            this.automobilTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idautomobil";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // vinDataGridViewTextBoxColumn
            // 
            this.vinDataGridViewTextBoxColumn.DataPropertyName = "vin";
            this.vinDataGridViewTextBoxColumn.HeaderText = "vin";
            this.vinDataGridViewTextBoxColumn.Name = "vinDataGridViewTextBoxColumn";
            this.vinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spzDataGridViewTextBoxColumn
            // 
            this.spzDataGridViewTextBoxColumn.DataPropertyName = "spz";
            this.spzDataGridViewTextBoxColumn.HeaderText = "spz";
            this.spzDataGridViewTextBoxColumn.Name = "spzDataGridViewTextBoxColumn";
            this.spzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokvyrobyDataGridViewTextBoxColumn
            // 
            this.rokvyrobyDataGridViewTextBoxColumn.DataPropertyName = "rok_vyroby";
            this.rokvyrobyDataGridViewTextBoxColumn.HeaderText = "Rok výroby";
            this.rokvyrobyDataGridViewTextBoxColumn.Name = "rokvyrobyDataGridViewTextBoxColumn";
            this.rokvyrobyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CarList
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
            this.Name = "CarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobily";
            this.Load += new System.EventHandler(this.CarList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView carListDataGrid;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource automobilBindingSource;
        private Database1DataSetTableAdapters.automobilTableAdapter automobilTableAdapter;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokvyrobyDataGridViewTextBoxColumn;
    }
}