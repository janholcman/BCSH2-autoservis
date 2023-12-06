namespace WindowsFormsApp1.Backend
{
    partial class NewCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCarForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spzWarning = new System.Windows.Forms.PictureBox();
            this.vinWarning = new System.Windows.Forms.PictureBox();
            this.ownerTT = new System.Windows.Forms.PictureBox();
            this.pojistovnaTT = new System.Windows.Forms.PictureBox();
            this.typeTT = new System.Windows.Forms.PictureBox();
            this.spzTT = new System.Windows.Forms.PictureBox();
            this.vinTT = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.addOwnerBtn = new System.Windows.Forms.Button();
            this.ownerCB = new System.Windows.Forms.ComboBox();
            this.pojistovnaCB = new System.Windows.Forms.ComboBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.createDateNS = new System.Windows.Forms.NumericUpDown();
            this.spzTF = new System.Windows.Forms.TextBox();
            this.vinTF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spzWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojistovnaTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spzTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createDateNS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spzWarning);
            this.groupBox1.Controls.Add(this.vinWarning);
            this.groupBox1.Controls.Add(this.ownerTT);
            this.groupBox1.Controls.Add(this.pojistovnaTT);
            this.groupBox1.Controls.Add(this.typeTT);
            this.groupBox1.Controls.Add(this.spzTT);
            this.groupBox1.Controls.Add(this.vinTT);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.confirmBtn);
            this.groupBox1.Controls.Add(this.addOwnerBtn);
            this.groupBox1.Controls.Add(this.ownerCB);
            this.groupBox1.Controls.Add(this.pojistovnaCB);
            this.groupBox1.Controls.Add(this.typeCB);
            this.groupBox1.Controls.Add(this.createDateNS);
            this.groupBox1.Controls.Add(this.spzTF);
            this.groupBox1.Controls.Add(this.vinTF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // spzWarning
            // 
            this.spzWarning.Image = ((System.Drawing.Image)(resources.GetObject("spzWarning.Image")));
            this.spzWarning.Location = new System.Drawing.Point(273, 45);
            this.spzWarning.Name = "spzWarning";
            this.spzWarning.Size = new System.Drawing.Size(16, 16);
            this.spzWarning.TabIndex = 25;
            this.spzWarning.TabStop = false;
            this.toolTip1.SetToolTip(this.spzWarning, "SPZ není jedinečná!");
            this.spzWarning.Visible = false;
            // 
            // vinWarning
            // 
            this.vinWarning.Image = ((System.Drawing.Image)(resources.GetObject("vinWarning.Image")));
            this.vinWarning.Location = new System.Drawing.Point(273, 19);
            this.vinWarning.Name = "vinWarning";
            this.vinWarning.Size = new System.Drawing.Size(16, 16);
            this.vinWarning.TabIndex = 24;
            this.vinWarning.TabStop = false;
            this.toolTip1.SetToolTip(this.vinWarning, "VIN není jedinečný!");
            this.vinWarning.Visible = false;
            // 
            // ownerTT
            // 
            this.ownerTT.Image = ((System.Drawing.Image)(resources.GetObject("ownerTT.Image")));
            this.ownerTT.Location = new System.Drawing.Point(251, 155);
            this.ownerTT.Name = "ownerTT";
            this.ownerTT.Size = new System.Drawing.Size(16, 16);
            this.ownerTT.TabIndex = 22;
            this.ownerTT.TabStop = false;
            this.toolTip1.SetToolTip(this.ownerTT, "Pole musí být vyplněné!");
            this.ownerTT.Visible = false;
            // 
            // pojistovnaTT
            // 
            this.pojistovnaTT.Image = ((System.Drawing.Image)(resources.GetObject("pojistovnaTT.Image")));
            this.pojistovnaTT.Location = new System.Drawing.Point(251, 127);
            this.pojistovnaTT.Name = "pojistovnaTT";
            this.pojistovnaTT.Size = new System.Drawing.Size(16, 16);
            this.pojistovnaTT.TabIndex = 21;
            this.pojistovnaTT.TabStop = false;
            this.toolTip1.SetToolTip(this.pojistovnaTT, "Pole musí být vyplněné!");
            this.pojistovnaTT.Visible = false;
            // 
            // typeTT
            // 
            this.typeTT.Image = ((System.Drawing.Image)(resources.GetObject("typeTT.Image")));
            this.typeTT.Location = new System.Drawing.Point(251, 99);
            this.typeTT.Name = "typeTT";
            this.typeTT.Size = new System.Drawing.Size(16, 16);
            this.typeTT.TabIndex = 20;
            this.typeTT.TabStop = false;
            this.toolTip1.SetToolTip(this.typeTT, "Pole musí být vyplněné!");
            this.typeTT.Visible = false;
            // 
            // spzTT
            // 
            this.spzTT.Image = ((System.Drawing.Image)(resources.GetObject("spzTT.Image")));
            this.spzTT.Location = new System.Drawing.Point(251, 45);
            this.spzTT.Name = "spzTT";
            this.spzTT.Size = new System.Drawing.Size(16, 16);
            this.spzTT.TabIndex = 18;
            this.spzTT.TabStop = false;
            this.toolTip1.SetToolTip(this.spzTT, "Pole musí být vyplněné!");
            this.spzTT.Visible = false;
            // 
            // vinTT
            // 
            this.vinTT.Image = ((System.Drawing.Image)(resources.GetObject("vinTT.Image")));
            this.vinTT.Location = new System.Drawing.Point(251, 19);
            this.vinTT.Name = "vinTT";
            this.vinTT.Size = new System.Drawing.Size(16, 16);
            this.vinTT.TabIndex = 17;
            this.vinTT.TabStop = false;
            this.toolTip1.SetToolTip(this.vinTT, "Pole musí být vyplněné!");
            this.vinTT.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(9, 197);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(289, 197);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 13;
            this.confirmBtn.Text = "Přidat";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // addOwnerBtn
            // 
            this.addOwnerBtn.Location = new System.Drawing.Point(273, 153);
            this.addOwnerBtn.Name = "addOwnerBtn";
            this.addOwnerBtn.Size = new System.Drawing.Size(91, 23);
            this.addOwnerBtn.TabIndex = 12;
            this.addOwnerBtn.Text = "Přidat majitele";
            this.addOwnerBtn.UseVisualStyleBackColor = true;
            this.addOwnerBtn.Click += new System.EventHandler(this.addOwnerBtn_Click);
            // 
            // ownerCB
            // 
            this.ownerCB.FormattingEnabled = true;
            this.ownerCB.Location = new System.Drawing.Point(125, 155);
            this.ownerCB.Name = "ownerCB";
            this.ownerCB.Size = new System.Drawing.Size(121, 21);
            this.ownerCB.TabIndex = 11;
            // 
            // pojistovnaCB
            // 
            this.pojistovnaCB.FormattingEnabled = true;
            this.pojistovnaCB.Location = new System.Drawing.Point(125, 127);
            this.pojistovnaCB.Name = "pojistovnaCB";
            this.pojistovnaCB.Size = new System.Drawing.Size(121, 21);
            this.pojistovnaCB.TabIndex = 10;
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(125, 99);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(121, 21);
            this.typeCB.TabIndex = 9;
            // 
            // createDateNS
            // 
            this.createDateNS.Location = new System.Drawing.Point(125, 72);
            this.createDateNS.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.createDateNS.Minimum = new decimal(new int[] {
            1886,
            0,
            0,
            0});
            this.createDateNS.Name = "createDateNS";
            this.createDateNS.Size = new System.Drawing.Size(120, 20);
            this.createDateNS.TabIndex = 8;
            this.createDateNS.Value = new decimal(new int[] {
            2003,
            0,
            0,
            0});
            // 
            // spzTF
            // 
            this.spzTF.Location = new System.Drawing.Point(125, 45);
            this.spzTF.Name = "spzTF";
            this.spzTF.Size = new System.Drawing.Size(120, 20);
            this.spzTF.TabIndex = 7;
            // 
            // vinTF
            // 
            this.vinTF.Location = new System.Drawing.Point(125, 19);
            this.vinTF.Name = "vinTF";
            this.vinTF.Size = new System.Drawing.Size(120, 20);
            this.vinTF.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Majitel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pojišťovna:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok výroby:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SPZ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIN:";
            // 
            // NewCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 263);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spzWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojistovnaTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spzTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createDateNS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addOwnerBtn;
        private System.Windows.Forms.ComboBox ownerCB;
        private System.Windows.Forms.ComboBox pojistovnaCB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.NumericUpDown createDateNS;
        private System.Windows.Forms.TextBox spzTF;
        private System.Windows.Forms.TextBox vinTF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.PictureBox spzTT;
        private System.Windows.Forms.PictureBox vinTT;
        private System.Windows.Forms.PictureBox ownerTT;
        private System.Windows.Forms.PictureBox pojistovnaTT;
        private System.Windows.Forms.PictureBox typeTT;
        private System.Windows.Forms.PictureBox spzWarning;
        private System.Windows.Forms.PictureBox vinWarning;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}