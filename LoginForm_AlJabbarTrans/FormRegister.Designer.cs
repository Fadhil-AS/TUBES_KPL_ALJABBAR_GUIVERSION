namespace AlJabbarTrans
{
    partial class FormRegister
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
            labelPassword = new Label();
            labelEmail = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelLogin = new Label();
            buttonDaftar = new Button();
            label1 = new Label();
            textBoxKonfirmasiPassword = new TextBox();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.Control;
            labelPassword.Location = new Point(15, 154);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(151, 21);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Masukkan Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = SystemColors.Control;
            labelEmail.Location = new Point(15, 96);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(123, 21);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Masukkan Email";
            labelEmail.Click += labelEmail_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(15, 176);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(224, 27);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(15, 119);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(224, 29);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(15, 47);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(121, 25);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "Daftar Akun";
            labelLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonDaftar
            // 
            buttonDaftar.BackColor = Color.FromArgb(25, 167, 206);
            buttonDaftar.ForeColor = Color.White;
            buttonDaftar.Location = new Point(15, 296);
            buttonDaftar.Margin = new Padding(3, 2, 3, 2);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(223, 25);
            buttonDaftar.TabIndex = 15;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = false;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 212);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 17;
            label1.Text = "Konfirmasi Password";
            // 
            // textBoxKonfirmasiPassword
            // 
            textBoxKonfirmasiPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKonfirmasiPassword.Location = new Point(15, 235);
            textBoxKonfirmasiPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxKonfirmasiPassword.Name = "textBoxKonfirmasiPassword";
            textBoxKonfirmasiPassword.Size = new Size(224, 27);
            textBoxKonfirmasiPassword.TabIndex = 16;
            textBoxKonfirmasiPassword.UseSystemPasswordChar = true;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 109, 110);
            ClientSize = new Size(252, 373);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(textBoxKonfirmasiPassword);
            Controls.Add(buttonDaftar);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelLogin);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private Label labelEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelLogin;
        private Button buttonDaftar;
        private Label label1;
        private TextBox textBoxKonfirmasiPassword;
    }
}