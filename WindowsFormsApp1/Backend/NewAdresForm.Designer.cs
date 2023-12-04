namespace WindowsFormsApp1.Backend
{
    partial class NewAdresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAdresForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.pscTF = new System.Windows.Forms.TextBox();
            this.houseNumberTF = new System.Windows.Forms.TextBox();
            this.streetTF = new System.Windows.Forms.TextBox();
            this.cityTF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTT = new System.Windows.Forms.PictureBox();
            this.secondNameTT = new System.Windows.Forms.PictureBox();
            this.houseNumberTT = new System.Windows.Forms.PictureBox();
            this.pscTT = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNameTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumberTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pscTT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pscTT);
            this.groupBox1.Controls.Add(this.houseNumberTT);
            this.groupBox1.Controls.Add(this.secondNameTT);
            this.groupBox1.Controls.Add(this.firstNameTT);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.confirmBtn);
            this.groupBox1.Controls.Add(this.pscTF);
            this.groupBox1.Controls.Add(this.houseNumberTF);
            this.groupBox1.Controls.Add(this.streetTF);
            this.groupBox1.Controls.Add(this.cityTF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(7, 139);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(111, 140);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "Přidat";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // pscTF
            // 
            this.pscTF.Location = new System.Drawing.Point(87, 101);
            this.pscTF.Name = "pscTF";
            this.pscTF.Size = new System.Drawing.Size(100, 20);
            this.pscTF.TabIndex = 7;
            // 
            // houseNumberTF
            // 
            this.houseNumberTF.Location = new System.Drawing.Point(87, 74);
            this.houseNumberTF.Name = "houseNumberTF";
            this.houseNumberTF.Size = new System.Drawing.Size(100, 20);
            this.houseNumberTF.TabIndex = 6;
            // 
            // streetTF
            // 
            this.streetTF.Location = new System.Drawing.Point(87, 47);
            this.streetTF.Name = "streetTF";
            this.streetTF.Size = new System.Drawing.Size(100, 20);
            this.streetTF.TabIndex = 5;
            // 
            // cityTF
            // 
            this.cityTF.Location = new System.Drawing.Point(87, 19);
            this.cityTF.Name = "cityTF";
            this.cityTF.Size = new System.Drawing.Size(100, 20);
            this.cityTF.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PSČ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Číslo popisné:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ulice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Město:";
            // 
            // firstNameTT
            // 
            this.firstNameTT.Image = ((System.Drawing.Image)(resources.GetObject("firstNameTT.Image")));
            this.firstNameTT.Location = new System.Drawing.Point(193, 20);
            this.firstNameTT.Name = "firstNameTT";
            this.firstNameTT.Size = new System.Drawing.Size(16, 16);
            this.firstNameTT.TabIndex = 17;
            this.firstNameTT.TabStop = false;
            this.firstNameTT.Visible = false;
            // 
            // secondNameTT
            // 
            this.secondNameTT.Image = ((System.Drawing.Image)(resources.GetObject("secondNameTT.Image")));
            this.secondNameTT.Location = new System.Drawing.Point(193, 47);
            this.secondNameTT.Name = "secondNameTT";
            this.secondNameTT.Size = new System.Drawing.Size(16, 16);
            this.secondNameTT.TabIndex = 18;
            this.secondNameTT.TabStop = false;
            this.secondNameTT.Visible = false;
            // 
            // houseNumberTT
            // 
            this.houseNumberTT.Image = ((System.Drawing.Image)(resources.GetObject("houseNumberTT.Image")));
            this.houseNumberTT.Location = new System.Drawing.Point(193, 74);
            this.houseNumberTT.Name = "houseNumberTT";
            this.houseNumberTT.Size = new System.Drawing.Size(16, 16);
            this.houseNumberTT.TabIndex = 19;
            this.houseNumberTT.TabStop = false;
            this.houseNumberTT.Visible = false;
            // 
            // pscTT
            // 
            this.pscTT.Image = ((System.Drawing.Image)(resources.GetObject("pscTT.Image")));
            this.pscTT.Location = new System.Drawing.Point(193, 101);
            this.pscTT.Name = "pscTT";
            this.pscTT.Size = new System.Drawing.Size(16, 16);
            this.pscTT.TabIndex = 20;
            this.pscTT.TabStop = false;
            this.pscTT.Visible = false;
            // 
            // NewAdresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 221);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAdresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nová adresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNameTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumberTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pscTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox pscTF;
        private System.Windows.Forms.TextBox houseNumberTF;
        private System.Windows.Forms.TextBox streetTF;
        private System.Windows.Forms.TextBox cityTF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pscTT;
        private System.Windows.Forms.PictureBox houseNumberTT;
        private System.Windows.Forms.PictureBox secondNameTT;
        private System.Windows.Forms.PictureBox firstNameTT;
    }
}