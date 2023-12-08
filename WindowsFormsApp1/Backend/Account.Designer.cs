namespace WindowsFormsApp1
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userInfoBtn = new System.Windows.Forms.Button();
            this.contractListBtn = new System.Windows.Forms.Button();
            this.carListBtn = new System.Windows.Forms.Button();
            this.KlientListBtn = new System.Windows.Forms.Button();
            this.workerListBtn = new System.Windows.Forms.Button();
            this.enumEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.klientFirstNameLabel = new System.Windows.Forms.Label();
            this.klientSecondNameLabel = new System.Windows.Forms.Label();
            this.klientUserNameLabel = new System.Windows.Forms.Label();
            this.klientPasswordLabel = new System.Windows.Forms.Label();
            this.klientGroupBox = new System.Windows.Forms.GroupBox();
            this.workerGroupBox = new System.Windows.Forms.GroupBox();
            this.showPasswordWorker = new System.Windows.Forms.PictureBox();
            this.workerPasswordLabel = new System.Windows.Forms.Label();
            this.birthNumberLabel = new System.Windows.Forms.Label();
            this.workerUserNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.startWorkLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.workerMoneyLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.workerSecondnameLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.workerFirstNameLabel = new System.Windows.Forms.Label();
            this.showPasswordKlient = new System.Windows.Forms.PictureBox();
            this.klientCompanyLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.klientGroupBox.SuspendLayout();
            this.workerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordKlient)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(708, 13);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Odhlásit";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // userInfoBtn
            // 
            this.userInfoBtn.Enabled = false;
            this.userInfoBtn.Location = new System.Drawing.Point(13, 13);
            this.userInfoBtn.Name = "userInfoBtn";
            this.userInfoBtn.Size = new System.Drawing.Size(120, 23);
            this.userInfoBtn.TabIndex = 1;
            this.userInfoBtn.Text = "Uživatelské informace";
            this.userInfoBtn.UseVisualStyleBackColor = true;
            // 
            // contractListBtn
            // 
            this.contractListBtn.Location = new System.Drawing.Point(139, 13);
            this.contractListBtn.Name = "contractListBtn";
            this.contractListBtn.Size = new System.Drawing.Size(90, 23);
            this.contractListBtn.TabIndex = 2;
            this.contractListBtn.Text = "Výpis zakázek";
            this.contractListBtn.UseVisualStyleBackColor = true;
            this.contractListBtn.Click += new System.EventHandler(this.contractListBtn_Click);
            // 
            // carListBtn
            // 
            this.carListBtn.Location = new System.Drawing.Point(236, 13);
            this.carListBtn.Name = "carListBtn";
            this.carListBtn.Size = new System.Drawing.Size(75, 23);
            this.carListBtn.TabIndex = 3;
            this.carListBtn.Text = "Výpis aut";
            this.carListBtn.UseVisualStyleBackColor = true;
            this.carListBtn.Click += new System.EventHandler(this.carListBtn_Click);
            // 
            // KlientListBtn
            // 
            this.KlientListBtn.Location = new System.Drawing.Point(318, 13);
            this.KlientListBtn.Name = "KlientListBtn";
            this.KlientListBtn.Size = new System.Drawing.Size(93, 23);
            this.KlientListBtn.TabIndex = 4;
            this.KlientListBtn.Text = "Výpis zákazníků";
            this.KlientListBtn.UseVisualStyleBackColor = true;
            this.KlientListBtn.Click += new System.EventHandler(this.KlientListBtn_Click);
            // 
            // workerListBtn
            // 
            this.workerListBtn.Location = new System.Drawing.Point(418, 13);
            this.workerListBtn.Name = "workerListBtn";
            this.workerListBtn.Size = new System.Drawing.Size(108, 23);
            this.workerListBtn.TabIndex = 5;
            this.workerListBtn.Text = "Výpis zaměstnanců";
            this.workerListBtn.UseVisualStyleBackColor = true;
            this.workerListBtn.Click += new System.EventHandler(this.workerListBtn_Click);
            // 
            // enumEditBtn
            // 
            this.enumEditBtn.Location = new System.Drawing.Point(533, 13);
            this.enumEditBtn.Name = "enumEditBtn";
            this.enumEditBtn.Size = new System.Drawing.Size(99, 23);
            this.enumEditBtn.TabIndex = 6;
            this.enumEditBtn.Text = "Úprava číselníků";
            this.enumEditBtn.UseVisualStyleBackColor = true;
            this.enumEditBtn.Click += new System.EventHandler(this.enumEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Příjmení";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Název účtu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Heslo:";
            // 
            // klientFirstNameLabel
            // 
            this.klientFirstNameLabel.AutoSize = true;
            this.klientFirstNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.klientFirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.klientFirstNameLabel.Location = new System.Drawing.Point(144, 33);
            this.klientFirstNameLabel.Name = "klientFirstNameLabel";
            this.klientFirstNameLabel.Size = new System.Drawing.Size(37, 15);
            this.klientFirstNameLabel.TabIndex = 13;
            this.klientFirstNameLabel.Text = "label7";
            // 
            // klientSecondNameLabel
            // 
            this.klientSecondNameLabel.AutoSize = true;
            this.klientSecondNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.klientSecondNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.klientSecondNameLabel.Location = new System.Drawing.Point(144, 60);
            this.klientSecondNameLabel.Name = "klientSecondNameLabel";
            this.klientSecondNameLabel.Size = new System.Drawing.Size(37, 15);
            this.klientSecondNameLabel.TabIndex = 14;
            this.klientSecondNameLabel.Text = "label8";
            // 
            // klientUserNameLabel
            // 
            this.klientUserNameLabel.AutoSize = true;
            this.klientUserNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.klientUserNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.klientUserNameLabel.Location = new System.Drawing.Point(144, 115);
            this.klientUserNameLabel.Name = "klientUserNameLabel";
            this.klientUserNameLabel.Size = new System.Drawing.Size(43, 15);
            this.klientUserNameLabel.TabIndex = 17;
            this.klientUserNameLabel.Text = "label11";
            // 
            // klientPasswordLabel
            // 
            this.klientPasswordLabel.AutoSize = true;
            this.klientPasswordLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.klientPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.klientPasswordLabel.Location = new System.Drawing.Point(144, 146);
            this.klientPasswordLabel.Name = "klientPasswordLabel";
            this.klientPasswordLabel.Size = new System.Drawing.Size(43, 15);
            this.klientPasswordLabel.TabIndex = 18;
            this.klientPasswordLabel.Text = "label12";
            this.klientPasswordLabel.Visible = false;
            // 
            // klientGroupBox
            // 
            this.klientGroupBox.Controls.Add(this.showPasswordKlient);
            this.klientGroupBox.Controls.Add(this.klientCompanyLabel);
            this.klientGroupBox.Controls.Add(this.label8);
            this.klientGroupBox.Controls.Add(this.label1);
            this.klientGroupBox.Controls.Add(this.klientPasswordLabel);
            this.klientGroupBox.Controls.Add(this.label2);
            this.klientGroupBox.Controls.Add(this.klientUserNameLabel);
            this.klientGroupBox.Controls.Add(this.label5);
            this.klientGroupBox.Controls.Add(this.klientSecondNameLabel);
            this.klientGroupBox.Controls.Add(this.label6);
            this.klientGroupBox.Controls.Add(this.klientFirstNameLabel);
            this.klientGroupBox.Location = new System.Drawing.Point(13, 62);
            this.klientGroupBox.Name = "klientGroupBox";
            this.klientGroupBox.Size = new System.Drawing.Size(290, 227);
            this.klientGroupBox.TabIndex = 19;
            this.klientGroupBox.TabStop = false;
            // 
            // workerGroupBox
            // 
            this.workerGroupBox.Controls.Add(this.showPasswordWorker);
            this.workerGroupBox.Controls.Add(this.workerPasswordLabel);
            this.workerGroupBox.Controls.Add(this.birthNumberLabel);
            this.workerGroupBox.Controls.Add(this.workerUserNameLabel);
            this.workerGroupBox.Controls.Add(this.label7);
            this.workerGroupBox.Controls.Add(this.label11);
            this.workerGroupBox.Controls.Add(this.label13);
            this.workerGroupBox.Controls.Add(this.label10);
            this.workerGroupBox.Controls.Add(this.startWorkLabel);
            this.workerGroupBox.Controls.Add(this.label12);
            this.workerGroupBox.Controls.Add(this.workerMoneyLabel);
            this.workerGroupBox.Controls.Add(this.positionLabel);
            this.workerGroupBox.Controls.Add(this.label16);
            this.workerGroupBox.Controls.Add(this.label18);
            this.workerGroupBox.Controls.Add(this.workerSecondnameLabel);
            this.workerGroupBox.Controls.Add(this.label20);
            this.workerGroupBox.Controls.Add(this.workerFirstNameLabel);
            this.workerGroupBox.Location = new System.Drawing.Point(12, 52);
            this.workerGroupBox.Name = "workerGroupBox";
            this.workerGroupBox.Size = new System.Drawing.Size(290, 299);
            this.workerGroupBox.TabIndex = 21;
            this.workerGroupBox.TabStop = false;
            // 
            // showPasswordWorker
            // 
            this.showPasswordWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordWorker.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordWorker.Image")));
            this.showPasswordWorker.Location = new System.Drawing.Point(104, 222);
            this.showPasswordWorker.Name = "showPasswordWorker";
            this.showPasswordWorker.Size = new System.Drawing.Size(16, 16);
            this.showPasswordWorker.TabIndex = 23;
            this.showPasswordWorker.TabStop = false;
            this.showPasswordWorker.Click += new System.EventHandler(this.showPasswordWorker_Click);
            // 
            // workerPasswordLabel
            // 
            this.workerPasswordLabel.AutoSize = true;
            this.workerPasswordLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.workerPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerPasswordLabel.Location = new System.Drawing.Point(144, 222);
            this.workerPasswordLabel.Name = "workerPasswordLabel";
            this.workerPasswordLabel.Size = new System.Drawing.Size(43, 15);
            this.workerPasswordLabel.TabIndex = 24;
            this.workerPasswordLabel.Text = "label12";
            this.workerPasswordLabel.Visible = false;
            // 
            // birthNumberLabel
            // 
            this.birthNumberLabel.AutoSize = true;
            this.birthNumberLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.birthNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthNumberLabel.Location = new System.Drawing.Point(144, 169);
            this.birthNumberLabel.Name = "birthNumberLabel";
            this.birthNumberLabel.Size = new System.Drawing.Size(43, 15);
            this.birthNumberLabel.TabIndex = 20;
            this.birthNumberLabel.Text = "label12";
            // 
            // workerUserNameLabel
            // 
            this.workerUserNameLabel.AutoSize = true;
            this.workerUserNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.workerUserNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerUserNameLabel.Location = new System.Drawing.Point(144, 195);
            this.workerUserNameLabel.Name = "workerUserNameLabel";
            this.workerUserNameLabel.Size = new System.Drawing.Size(43, 15);
            this.workerUserNameLabel.TabIndex = 23;
            this.workerUserNameLabel.Text = "label11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rodné číslo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Název účtu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Heslo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Jméno:";
            // 
            // startWorkLabel
            // 
            this.startWorkLabel.AutoSize = true;
            this.startWorkLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startWorkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startWorkLabel.Location = new System.Drawing.Point(144, 142);
            this.startWorkLabel.Name = "startWorkLabel";
            this.startWorkLabel.Size = new System.Drawing.Size(43, 15);
            this.startWorkLabel.TabIndex = 18;
            this.startWorkLabel.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Příjmení";
            // 
            // workerMoneyLabel
            // 
            this.workerMoneyLabel.AutoSize = true;
            this.workerMoneyLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.workerMoneyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerMoneyLabel.Location = new System.Drawing.Point(144, 111);
            this.workerMoneyLabel.Name = "workerMoneyLabel";
            this.workerMoneyLabel.Size = new System.Drawing.Size(43, 15);
            this.workerMoneyLabel.TabIndex = 17;
            this.workerMoneyLabel.Text = "label11";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.positionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionLabel.Location = new System.Drawing.Point(144, 85);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(43, 15);
            this.positionLabel.TabIndex = 16;
            this.positionLabel.Text = "label10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Pozice:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Hodinová mzda:";
            // 
            // workerSecondnameLabel
            // 
            this.workerSecondnameLabel.AutoSize = true;
            this.workerSecondnameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.workerSecondnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerSecondnameLabel.Location = new System.Drawing.Point(144, 60);
            this.workerSecondnameLabel.Name = "workerSecondnameLabel";
            this.workerSecondnameLabel.Size = new System.Drawing.Size(37, 15);
            this.workerSecondnameLabel.TabIndex = 14;
            this.workerSecondnameLabel.Text = "label8";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Datum nástupu:";
            // 
            // workerFirstNameLabel
            // 
            this.workerFirstNameLabel.AutoSize = true;
            this.workerFirstNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.workerFirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workerFirstNameLabel.Location = new System.Drawing.Point(144, 33);
            this.workerFirstNameLabel.Name = "workerFirstNameLabel";
            this.workerFirstNameLabel.Size = new System.Drawing.Size(37, 15);
            this.workerFirstNameLabel.TabIndex = 13;
            this.workerFirstNameLabel.Text = "label7";
            // 
            // showPasswordKlient
            // 
            this.showPasswordKlient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordKlient.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordKlient.Image")));
            this.showPasswordKlient.Location = new System.Drawing.Point(112, 146);
            this.showPasswordKlient.Name = "showPasswordKlient";
            this.showPasswordKlient.Size = new System.Drawing.Size(16, 16);
            this.showPasswordKlient.TabIndex = 23;
            this.showPasswordKlient.TabStop = false;
            this.showPasswordKlient.Click += new System.EventHandler(this.showPasswordKlient_Click);
            // 
            // klientCompanyLabel
            // 
            this.klientCompanyLabel.AutoSize = true;
            this.klientCompanyLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.klientCompanyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.klientCompanyLabel.Location = new System.Drawing.Point(144, 86);
            this.klientCompanyLabel.Name = "klientCompanyLabel";
            this.klientCompanyLabel.Size = new System.Drawing.Size(43, 15);
            this.klientCompanyLabel.TabIndex = 20;
            this.klientCompanyLabel.Text = "label12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Firma:";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.workerGroupBox);
            this.Controls.Add(this.klientGroupBox);
            this.Controls.Add(this.enumEditBtn);
            this.Controls.Add(this.workerListBtn);
            this.Controls.Add(this.KlientListBtn);
            this.Controls.Add(this.carListBtn);
            this.Controls.Add(this.contractListBtn);
            this.Controls.Add(this.userInfoBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Účet";
            this.klientGroupBox.ResumeLayout(false);
            this.klientGroupBox.PerformLayout();
            this.workerGroupBox.ResumeLayout(false);
            this.workerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordKlient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button userInfoBtn;
        private System.Windows.Forms.Button contractListBtn;
        private System.Windows.Forms.Button carListBtn;
        private System.Windows.Forms.Button KlientListBtn;
        private System.Windows.Forms.Button workerListBtn;
        private System.Windows.Forms.Button enumEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label klientFirstNameLabel;
        private System.Windows.Forms.Label klientSecondNameLabel;
        private System.Windows.Forms.Label klientUserNameLabel;
        private System.Windows.Forms.Label klientPasswordLabel;
        private System.Windows.Forms.GroupBox klientGroupBox;
        private System.Windows.Forms.Label klientCompanyLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox workerGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label startWorkLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label workerMoneyLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label workerSecondnameLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label workerFirstNameLabel;
        private System.Windows.Forms.Label workerPasswordLabel;
        private System.Windows.Forms.Label birthNumberLabel;
        private System.Windows.Forms.Label workerUserNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox showPasswordWorker;
        private System.Windows.Forms.PictureBox showPasswordKlient;
    }
}