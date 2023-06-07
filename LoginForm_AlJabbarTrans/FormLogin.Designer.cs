namespace LoginForm_AlJabbarTrans
{
    partial class formLogin
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
            labelLogin = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonMasuk = new Button();
            buttonDaftar = new Button();
            labelLupaPassword = new Label();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(14, 137);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(75, 31);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(14, 192);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(255, 34);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.Text = "Masukkan Email";
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(14, 255);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(255, 32);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.Text = "Masukkan Password";
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonMasuk
            // 
            buttonMasuk.BackColor = Color.FromArgb(25, 167, 206);
            buttonMasuk.ForeColor = Color.White;
            buttonMasuk.Location = new Point(14, 345);
            buttonMasuk.Name = "buttonMasuk";
            buttonMasuk.Size = new Size(255, 33);
            buttonMasuk.TabIndex = 5;
            buttonMasuk.Text = "Masuk";
            buttonMasuk.UseVisualStyleBackColor = false;
            buttonMasuk.Click += buttonMasuk_Click;
            // 
            // buttonDaftar
            // 
            buttonDaftar.BackColor = Color.FromArgb(241, 246, 249);
            buttonDaftar.ForeColor = Color.FromArgb(155, 164, 181);
            buttonDaftar.Location = new Point(14, 397);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(255, 33);
            buttonDaftar.TabIndex = 6;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = false;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // labelLupaPassword
            // 
            labelLupaPassword.AutoSize = true;
            labelLupaPassword.ForeColor = Color.White;
            labelLupaPassword.Location = new Point(156, 313);
            labelLupaPassword.Name = "labelLupaPassword";
            labelLupaPassword.Size = new Size(113, 20);
            labelLupaPassword.TabIndex = 7;
            labelLupaPassword.Text = "Lupa Password?";
            labelLupaPassword.Click += labelLupaPassword_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 109, 110);
            ClientSize = new Size(303, 568);
            Controls.Add(labelLupaPassword);
            Controls.Add(buttonDaftar);
            Controls.Add(buttonMasuk);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelLogin);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonMasuk;
        private Button buttonDaftar;
        private Label labelLupaPassword;
    }
}