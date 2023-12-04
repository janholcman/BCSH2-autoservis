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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPerHourNumpicker)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(303, 276);
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
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(9, 235);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.UseVisualStyleBackColor = true;
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
            this.userPasswordTF.PasswordChar = '*';
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
            // NewWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nový zaměstnanec";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPerHourNumpicker)).EndInit();
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
    }
}