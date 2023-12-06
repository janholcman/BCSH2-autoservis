namespace WindowsFormsApp1.Backend
{
    partial class NewOwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOwnerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondNameTT = new System.Windows.Forms.PictureBox();
            this.firstNameTT = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secondNameTF = new System.Windows.Forms.TextBox();
            this.firstNameTF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNameTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondNameTT);
            this.groupBox1.Controls.Add(this.firstNameTT);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.confirmBtn);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.secondNameTF);
            this.groupBox1.Controls.Add(this.firstNameTF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // secondNameTT
            // 
            this.secondNameTT.Image = ((System.Drawing.Image)(resources.GetObject("secondNameTT.Image")));
            this.secondNameTT.Location = new System.Drawing.Point(291, 47);
            this.secondNameTT.Name = "secondNameTT";
            this.secondNameTT.Size = new System.Drawing.Size(16, 16);
            this.secondNameTT.TabIndex = 19;
            this.secondNameTT.TabStop = false;
            this.toolTip1.SetToolTip(this.secondNameTT, "Pole musí být vyplněné!");
            this.secondNameTT.Visible = false;
            // 
            // firstNameTT
            // 
            this.firstNameTT.Image = ((System.Drawing.Image)(resources.GetObject("firstNameTT.Image")));
            this.firstNameTT.Location = new System.Drawing.Point(291, 20);
            this.firstNameTT.Name = "firstNameTT";
            this.firstNameTT.Size = new System.Drawing.Size(16, 16);
            this.firstNameTT.TabIndex = 18;
            this.firstNameTT.TabStop = false;
            this.toolTip1.SetToolTip(this.firstNameTT, "Pole musí být vyplněné!");
            this.firstNameTT.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(6, 109);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(231, 109);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Přidat";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(106, 73);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // secondNameTF
            // 
            this.secondNameTF.Location = new System.Drawing.Point(106, 47);
            this.secondNameTF.Name = "secondNameTF";
            this.secondNameTF.Size = new System.Drawing.Size(179, 20);
            this.secondNameTF.TabIndex = 4;
            // 
            // firstNameTF
            // 
            this.firstNameTF.Location = new System.Drawing.Point(106, 20);
            this.firstNameTF.Name = "firstNameTF";
            this.firstNameTF.Size = new System.Drawing.Size(179, 20);
            this.firstNameTF.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vlastní od:";
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
            // NewOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 167);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewOwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nový majitel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNameTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox secondNameTF;
        private System.Windows.Forms.TextBox firstNameTF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox secondNameTT;
        private System.Windows.Forms.PictureBox firstNameTT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}