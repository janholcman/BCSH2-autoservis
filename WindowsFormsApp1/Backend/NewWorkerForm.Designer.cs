namespace WindowsFormsApp1.Backend
{
    partial class NewWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWorkerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.positionCB = new System.Windows.Forms.ComboBox();
            this.moneyPerHourNumpicker = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userPasswordTF = new System.Windows.Forms.TextBox();
            this.userNameTF = new System.Windows.Forms.TextBox();
            this.birthNumberTF = new System.Windows.Forms.TextBox();
            this.secondNameTF = new System.Windows.Forms.TextBox();
            this.firstNameTF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTT = new System.Windows.Forms.PictureBox();
            this.secondNameTT = new System.Windows.Forms.PictureBox();
            this.birthNumberTT = new System.Windows.Forms.PictureBox();
            this.workerPositionTT = new System.Windows.Forms.PictureBox();
            this.userNameTT = new System.Windows.Forms.PictureBox();
            this.moneyPerHourTT = new System.Windows.Forms.PictureBox();
            this.userPasswordTT = new System.Windows.Forms.PictureBox();
            this.workerStartTT = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.birthNumberWarning = new System.Windows.Forms.PictureBox();
            this.userNameWarning = new System.Windows.Forms.PictureBox();
            this.showBtn = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPerHourNumpicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNameTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthNumberTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerPositionTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPerHourTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPasswordTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerStartTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthNumberWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showBtn);
            this.groupBox1.Controls.Add(this.userNameWarning);
            this.groupBox1.Controls.Add(this.birthNumberWarning);
            this.groupBox1.Controls.Add(this.workerStartTT);
            this.groupBox1.Controls.Add(this.userPasswordTT);
            this.groupBox1.Controls.Add(this.moneyPerHourTT);
            this.groupBox1.Controls.Add(this.userNameTT);
            this.groupBox1.Controls.Add(this.workerPositionTT);
            this.groupBox1.Controls.Add(this.birthNumberTT);
            this.groupBox1.Controls.Add(this.secondNameTT);
            this.groupBox1.Controls.Add(this.firstNameTT);
            this.groupBox1.Controls.Add(this.confirmBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.positionCB);
            this.groupBox1.Controls.Add(this.moneyPerHourNumpicker);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.userPasswordTF);
            this.groupBox1.Controls.Add(this.userNameTF);
            this.groupBox1.Controls.Add(this.birthNumberTF);
            this.groupBox1.Controls.Add(this.secondNameTF);
            this.groupBox1.Controls.Add(this.firstNameTF);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(187, 235);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 22;
            this.confirmBtn.Text = "Přidat";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(9, 235);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // positionCB
            // 
            this.positionCB.FormattingEnabled = true;
            this.positionCB.Location = new System.Drawing.Point(93, 154);
            this.positionCB.Name = "positionCB";
            this.positionCB.Size = new System.Drawing.Size(170, 21);
            this.positionCB.TabIndex = 20;
            // 
            // moneyPerHourNumpicker
            // 
            this.moneyPerHourNumpicker.Location = new System.Drawing.Point(93, 128);
            this.moneyPerHourNumpicker.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.moneyPerHourNumpicker.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.moneyPerHourNumpicker.Name = "moneyPerHourNumpicker";
            this.moneyPerHourNumpicker.Size = new System.Drawing.Size(170, 20);
            this.moneyPerHourNumpicker.TabIndex = 19;
            this.moneyPerHourNumpicker.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(93, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker.TabIndex = 18;
            this.dateTimePicker.Value = new System.DateTime(2023, 12, 4, 17, 21, 30, 0);
            // 
            // userPasswordTF
            // 
            this.userPasswordTF.Location = new System.Drawing.Point(93, 208);
            this.userPasswordTF.Name = "userPasswordTF";
            this.userPasswordTF.Size = new System.Drawing.Size(170, 20);
            this.userPasswordTF.TabIndex = 17;
            this.userPasswordTF.UseSystemPasswordChar = true;
            // 
            // userNameTF
            // 
            this.userNameTF.Location = new System.Drawing.Point(93, 181);
            this.userNameTF.Name = "userNameTF";
            this.userNameTF.Size = new System.Drawing.Size(170, 20);
            this.userNameTF.TabIndex = 16;
            // 
            // birthNumberTF
            // 
            this.birthNumberTF.Location = new System.Drawing.Point(93, 74);
            this.birthNumberTF.Name = "birthNumberTF";
            this.birthNumberTF.Size = new System.Drawing.Size(170, 20);
            this.birthNumberTF.TabIndex = 11;
            // 
            // secondNameTF
            // 
            this.secondNameTF.Location = new System.Drawing.Point(93, 47);
            this.secondNameTF.Name = "secondNameTF";
            this.secondNameTF.Size = new System.Drawing.Size(170, 20);
            this.secondNameTF.TabIndex = 10;
            // 
            // firstNameTF
            // 
            this.firstNameTF.Location = new System.Drawing.Point(93, 20);
            this.firstNameTF.Name = "firstNameTF";
            this.firstNameTF.Size = new System.Drawing.Size(170, 20);
            this.firstNameTF.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Heslo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Název účtu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pozice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hodinová mzda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum nástupu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rodné číslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Přijmení:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // firstNameTT
            // 
            this.firstNameTT.Image = ((System.Drawing.Image)(resources.GetObject("firstNameTT.Image")));
            this.firstNameTT.Location = new System.Drawing.Point(269, 20);
            this.firstNameTT.Name = "firstNameTT";
            this.firstNameTT.Size = new System.Drawing.Size(16, 16);
            this.firstNameTT.TabIndex = 23;
            this.firstNameTT.TabStop = false;
            this.toolTip1.SetToolTip(this.firstNameTT, "Pole nesmí být prázdné!");
            this.firstNameTT.Visible = false;
            // 
            // secondNameTT
            // 
            this.secondNameTT.Image = ((System.Drawing.Image)(resources.GetObject("secondNameTT.Image")));
            this.secondNameTT.Location = new System.Drawing.Point(269, 47);
            this.secondNameTT.Name = "secondNameTT";
            this.secondNameTT.Size = new System.Drawing.Size(16, 16);
            this.secondNameTT.TabIndex = 24;
            this.secondNameTT.TabStop = false;
            this.toolTip1.SetToolTip(this.secondNameTT, "Pole nesmí být prázdné!");
            this.secondNameTT.Visible = false;
            // 
            // birthNumberTT
            // 
            this.birthNumberTT.Image = ((System.Drawing.Image)(resources.GetObject("birthNumberTT.Image")));
            this.birthNumberTT.Location = new System.Drawing.Point(269, 74);
            this.birthNumberTT.Name = "birthNumberTT";
            this.birthNumberTT.Size = new System.Drawing.Size(16, 16);
            this.birthNumberTT.TabIndex = 25;
            this.birthNumberTT.TabStop = false;
            this.toolTip1.SetToolTip(this.birthNumberTT, "Pole nesmí být prázdné!");
            this.birthNumberTT.Visible = false;
            // 
            // workerPositionTT
            // 
            this.workerPositionTT.Image = ((System.Drawing.Image)(resources.GetObject("workerPositionTT.Image")));
            this.workerPositionTT.Location = new System.Drawing.Point(269, 154);
            this.workerPositionTT.Name = "workerPositionTT";
            this.workerPositionTT.Size = new System.Drawing.Size(16, 16);
            this.workerPositionTT.TabIndex = 28;
            this.workerPositionTT.TabStop = false;
            this.toolTip1.SetToolTip(this.workerPositionTT, "Pole nesmí být prázdné!");
            this.workerPositionTT.Visible = false;
            // 
            // userNameTT
            // 
            this.userNameTT.Image = ((System.Drawing.Image)(resources.GetObject("userNameTT.Image")));
            this.userNameTT.Location = new System.Drawing.Point(269, 181);
            this.userNameTT.Name = "userNameTT";
            this.userNameTT.Size = new System.Drawing.Size(16, 16);
            this.userNameTT.TabIndex = 29;
            this.userNameTT.TabStop = false;
            this.toolTip1.SetToolTip(this.userNameTT, "Pole nesmí být prázdné!");
            this.userNameTT.Visible = false;
            // 
            // moneyPerHourTT
            // 
            this.moneyPerHourTT.Image = ((System.Drawing.Image)(resources.GetObject("moneyPerHourTT.Image")));
            this.moneyPerHourTT.Location = new System.Drawing.Point(269, 128);
            this.moneyPerHourTT.Name = "moneyPerHourTT";
            this.moneyPerHourTT.Size = new System.Drawing.Size(16, 16);
            this.moneyPerHourTT.TabIndex = 30;
            this.moneyPerHourTT.TabStop = false;
            this.toolTip1.SetToolTip(this.moneyPerHourTT, "Pole nesmí být prázdné!");
            this.moneyPerHourTT.Visible = false;
            // 
            // userPasswordTT
            // 
            this.userPasswordTT.Image = ((System.Drawing.Image)(resources.GetObject("userPasswordTT.Image")));
            this.userPasswordTT.Location = new System.Drawing.Point(291, 208);
            this.userPasswordTT.Name = "userPasswordTT";
            this.userPasswordTT.Size = new System.Drawing.Size(16, 16);
            this.userPasswordTT.TabIndex = 31;
            this.userPasswordTT.TabStop = false;
            this.toolTip1.SetToolTip(this.userPasswordTT, "Pole nesmí být prázdné!");
            this.userPasswordTT.Visible = false;
            // 
            // workerStartTT
            // 
            this.workerStartTT.Image = ((System.Drawing.Image)(resources.GetObject("workerStartTT.Image")));
            this.workerStartTT.Location = new System.Drawing.Point(269, 101);
            this.workerStartTT.Name = "workerStartTT";
            this.workerStartTT.Size = new System.Drawing.Size(16, 16);
            this.workerStartTT.TabIndex = 32;
            this.workerStartTT.TabStop = false;
            this.toolTip1.SetToolTip(this.workerStartTT, "Pole nesmí být prázdné!");
            this.workerStartTT.Visible = false;
            // 
            // birthNumberWarning
            // 
            this.birthNumberWarning.Image = ((System.Drawing.Image)(resources.GetObject("birthNumberWarning.Image")));
            this.birthNumberWarning.Location = new System.Drawing.Point(291, 74);
            this.birthNumberWarning.Name = "birthNumberWarning";
            this.birthNumberWarning.Size = new System.Drawing.Size(16, 16);
            this.birthNumberWarning.TabIndex = 33;
            this.birthNumberWarning.TabStop = false;
            this.toolTip1.SetToolTip(this.birthNumberWarning, "Rodné číslo není jedinečné!");
            this.birthNumberWarning.Visible = false;
            // 
            // userNameWarning
            // 
            this.userNameWarning.Image = ((System.Drawing.Image)(resources.GetObject("userNameWarning.Image")));
            this.userNameWarning.Location = new System.Drawing.Point(291, 181);
            this.userNameWarning.Name = "userNameWarning";
            this.userNameWarning.Size = new System.Drawing.Size(16, 16);
            this.userNameWarning.TabIndex = 34;
            this.userNameWarning.TabStop = false;
            this.toolTip1.SetToolTip(this.userNameWarning, "Název účtu není jedinečný");
            this.userNameWarning.Visible = false;
            // 
            // showBtn
            // 
            this.showBtn.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.Image")));
            this.showBtn.Location = new System.Drawing.Point(269, 208);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(16, 16);
            this.showBtn.TabIndex = 35;
            this.showBtn.TabStop = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // NewWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nový zaměstnanec";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPerHourNumpicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNameTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthNumberTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerPositionTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPerHourTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPasswordTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerStartTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthNumberWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userPasswordTF;
        private System.Windows.Forms.TextBox userNameTF;
        private System.Windows.Forms.TextBox birthNumberTF;
        private System.Windows.Forms.TextBox secondNameTF;
        private System.Windows.Forms.TextBox firstNameTF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown moneyPerHourNumpicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox positionCB;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox birthNumberTT;
        private System.Windows.Forms.PictureBox secondNameTT;
        private System.Windows.Forms.PictureBox firstNameTT;
        private System.Windows.Forms.PictureBox workerStartTT;
        private System.Windows.Forms.PictureBox userPasswordTT;
        private System.Windows.Forms.PictureBox moneyPerHourTT;
        private System.Windows.Forms.PictureBox userNameTT;
        private System.Windows.Forms.PictureBox workerPositionTT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox userNameWarning;
        private System.Windows.Forms.PictureBox birthNumberWarning;
        private System.Windows.Forms.PictureBox showBtn;
    }
}