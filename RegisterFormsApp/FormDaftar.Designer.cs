namespace RegisterFormsApp
{
    partial class FormDaftar
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
            buttonDaftar = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelLogin = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonDaftar
            // 
            buttonDaftar.BackColor = Color.FromArgb(25, 167, 206);
            buttonDaftar.ForeColor = Color.White;
            buttonDaftar.Location = new Point(29, 371);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(255, 33);
            buttonDaftar.TabIndex = 12;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = false;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(29, 229);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(255, 32);
            textBoxPassword.TabIndex = 10;
            textBoxPassword.Text = "Masukkan Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(29, 166);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(255, 34);
            textBoxEmail.TabIndex = 9;
            textBoxEmail.Text = "Masukkan Email";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(29, 111);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(82, 31);
            labelLogin.TabIndex = 8;
            labelLogin.Text = "Daftar";
            labelLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 33);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 14;
            label2.Text = "JabbarTrans";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(29, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 32);
            textBox1.TabIndex = 16;
            textBox1.Text = "Konfirmasi Password";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 109, 110);
            ClientSize = new Size(312, 466);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(buttonDaftar);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDaftar";
            Text = "Form1";
            Load += FormDaftar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDaftar;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelLogin;
        private Label label2;
        private TextBox textBox1;
    }
}