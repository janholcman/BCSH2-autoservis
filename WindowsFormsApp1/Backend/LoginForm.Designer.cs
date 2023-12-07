namespace WindowsFormsApp1.Backend
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pripojeno = new System.Windows.Forms.Label();
            this.userPasswordTT = new System.Windows.Forms.PictureBox();
            this.userNameTT = new System.Windows.Forms.PictureBox();
            this.showBtn = new System.Windows.Forms.PictureBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPasswordTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pripojeno);
            this.groupBox1.Controls.Add(this.userPasswordTT);
            this.groupBox1.Controls.Add(this.userNameTT);
            this.groupBox1.Controls.Add(this.showBtn);
            this.groupBox1.Controls.Add(this.errorMessage);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pripojeno
            // 
            this.pripojeno.AutoSize = true;
            this.pripojeno.Location = new System.Drawing.Point(38, 11);
            this.pripojeno.Name = "pripojeno";
            this.pripojeno.Size = new System.Drawing.Size(0, 13);
            this.pripojeno.TabIndex = 26;
            // 
            // userPasswordTT
            // 
            this.userPasswordTT.Image = ((System.Drawing.Image)(resources.GetObject("userPasswordTT.Image")));
            this.userPasswordTT.Location = new System.Drawing.Point(238, 70);
            this.userPasswordTT.Name = "userPasswordTT";
            this.userPasswordTT.Size = new System.Drawing.Size(16, 16);
            this.userPasswordTT.TabIndex = 25;
            this.userPasswordTT.TabStop = false;
            this.userPasswordTT.Visible = false;
            // 
            // userNameTT
            // 
            this.userNameTT.Image = ((System.Drawing.Image)(resources.GetObject("userNameTT.Image")));
            this.userNameTT.Location = new System.Drawing.Point(216, 26);
            this.userNameTT.Name = "userNameTT";
            this.userNameTT.Size = new System.Drawing.Size(16, 16);
            this.userNameTT.TabIndex = 24;
            this.userNameTT.TabStop = false;
            this.userNameTT.Visible = false;
            // 
            // showBtn
            // 
            this.showBtn.Image = ((System.Drawing.Image)(resources.GetObject("showBtn.Image")));
            this.showBtn.Location = new System.Drawing.Point(216, 70);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(16, 16);
            this.showBtn.TabIndex = 23;
            this.showBtn.TabStop = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.errorMessage.Location = new System.Drawing.Point(3, 14);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(79, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(131, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heslo:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(6, 114);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Zrušit";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginBtn.Location = new System.Drawing.Point(186, 114);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Přihlásit";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(79, 70);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(131, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jméno:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 178);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přihlášení";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPasswordTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox showBtn;
        private System.Windows.Forms.PictureBox userPasswordTT;
        private System.Windows.Forms.PictureBox userNameTT;
        private System.Windows.Forms.Label pripojeno;
    }
}