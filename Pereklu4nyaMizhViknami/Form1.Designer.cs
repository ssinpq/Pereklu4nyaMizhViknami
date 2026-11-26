namespace Pereklu4nyaMizhViknami
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            picPhoto = new PictureBox();
            btnChoosePhoto = new Button();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(112, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Реєстрація";
            lblTitle.Click += label1_Click;
            // 
            // picPhoto
            // 
            picPhoto.BorderStyle = BorderStyle.FixedSingle;
            picPhoto.Location = new Point(130, 52);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(120, 120);
            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picPhoto.TabIndex = 1;
            picPhoto.TabStop = false;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.Location = new Point(133, 175);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(120, 23);
            btnChoosePhoto.TabIndex = 2;
            btnChoosePhoto.Text = "Обрати фото";
            btnChoosePhoto.UseVisualStyleBackColor = true;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F);
            lblLogin.Location = new Point(167, 201);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 21);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Логін";
            lblLogin.Click += lblLogin_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(73, 225);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 23);
            txtLogin.TabIndex = 4;
            txtLogin.TextChanged += this.txtLogin_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(162, 267);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 21);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Пошта";
            lblEmail.Click += this.lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(73, 291);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += this.txtEmail_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(162, 333);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 21);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Пароль";
            lblPassword.Click += this.lblPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(73, 357);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 23);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += this.txtPassword_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DeepSkyBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(97, 386);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 40);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Зареєструватись";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += this.btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(404, 521);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(btnChoosePhoto);
            Controls.Add(picPhoto);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація";
            Load += this.Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox picPhoto;
        private Button btnChoosePhoto;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnRegister;
    }
}
