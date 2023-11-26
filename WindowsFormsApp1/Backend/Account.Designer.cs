﻿namespace WindowsFormsApp1
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userInfoBtn = new System.Windows.Forms.Button();
            this.contractListBtn = new System.Windows.Forms.Button();
            this.carListBtn = new System.Windows.Forms.Button();
            this.KlientListBtn = new System.Windows.Forms.Button();
            this.workerListBtn = new System.Windows.Forms.Button();
            this.enumEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(92, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pozice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hodinová mzda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Datum nástupu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(237, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(237, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(237, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(237, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(237, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(237, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "label12";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enumEditBtn);
            this.Controls.Add(this.workerListBtn);
            this.Controls.Add(this.KlientListBtn);
            this.Controls.Add(this.carListBtn);
            this.Controls.Add(this.contractListBtn);
            this.Controls.Add(this.userInfoBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}