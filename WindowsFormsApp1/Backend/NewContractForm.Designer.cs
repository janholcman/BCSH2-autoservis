namespace WindowsFormsApp1.Backend
{
    partial class NewContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewContractForm));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.workerTT = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.workerCB = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KlientCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addKlientBtn = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.klientTT = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.endDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientTT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.endDateTimePicker1);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.workerTT);
            this.groupBox.Controls.Add(this.cancelBtn);
            this.groupBox.Controls.Add(this.confirmBtn);
            this.groupBox.Controls.Add(this.workerCB);
            this.groupBox.Controls.Add(this.dateTime);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(12, 69);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(300, 160);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // workerTT
            // 
            this.workerTT.Image = ((System.Drawing.Image)(resources.GetObject("workerTT.Image")));
            this.workerTT.Location = new System.Drawing.Point(278, 72);
            this.workerTT.Name = "workerTT";
            this.workerTT.Size = new System.Drawing.Size(16, 16);
            this.workerTT.TabIndex = 19;
            this.workerTT.TabStop = false;
            this.toolTip1.SetToolTip(this.workerTT, "Pole nesmí být prázdné!");
            this.workerTT.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(9, 131);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(219, 131);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Přidat";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // workerCB
            // 
            this.workerCB.FormattingEnabled = true;
            this.workerCB.Location = new System.Drawing.Point(87, 72);
            this.workerCB.Name = "workerCB";
            this.workerCB.Size = new System.Drawing.Size(185, 21);
            this.workerCB.TabIndex = 5;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(87, 20);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(207, 20);
            this.dateTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zaměstnanec:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Začátek:";
            // 
            // KlientCB
            // 
            this.KlientCB.FormattingEnabled = true;
            this.KlientCB.Location = new System.Drawing.Point(99, 13);
            this.KlientCB.Name = "KlientCB";
            this.KlientCB.Size = new System.Drawing.Size(191, 21);
            this.KlientCB.TabIndex = 1;
            this.KlientCB.SelectedIndexChanged += new System.EventHandler(this.klientCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zákazník:";
            // 
            // addKlientBtn
            // 
            this.addKlientBtn.Location = new System.Drawing.Point(177, 40);
            this.addKlientBtn.Name = "addKlientBtn";
            this.addKlientBtn.Size = new System.Drawing.Size(113, 23);
            this.addKlientBtn.TabIndex = 3;
            this.addKlientBtn.Text = "Přidat zákazníka";
            this.addKlientBtn.UseVisualStyleBackColor = true;
            this.addKlientBtn.Click += new System.EventHandler(this.addKlientBtn_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // klientTT
            // 
            this.klientTT.Image = ((System.Drawing.Image)(resources.GetObject("klientTT.Image")));
            this.klientTT.Location = new System.Drawing.Point(296, 13);
            this.klientTT.Name = "klientTT";
            this.klientTT.Size = new System.Drawing.Size(16, 16);
            this.klientTT.TabIndex = 18;
            this.klientTT.TabStop = false;
            this.toolTip1.SetToolTip(this.klientTT, "Pole nesmí být prázdné!");
            this.klientTT.Visible = false;
            // 
            // endDateTimePicker1
            // 
            this.endDateTimePicker1.Location = new System.Drawing.Point(87, 46);
            this.endDateTimePicker1.Name = "endDateTimePicker1";
            this.endDateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.endDateTimePicker1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Konec:";
            // 
            // NewContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 241);
            this.Controls.Add(this.klientTT);
            this.Controls.Add(this.addKlientBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KlientCB);
            this.Controls.Add(this.groupBox);
            this.Name = "NewContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nová zakázka";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ComboBox workerCB;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox KlientCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addKlientBtn;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox workerTT;
        private System.Windows.Forms.PictureBox klientTT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}