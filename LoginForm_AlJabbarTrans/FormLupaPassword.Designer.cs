namespace AlJabbarTrans
{
    partial class FormLupaPassword
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
            textBox1 = new TextBox();
            labelLogin = new Label();
            labelEmail = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(32, 75);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(154, 25);
            labelLogin.TabIndex = 11;
            labelLogin.Text = "Lupa Password?";
            labelLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = SystemColors.Control;
            labelEmail.Location = new Point(32, 143);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(123, 21);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Masukkan Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 203);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 15;
            label1.Text = "Masukkan Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(32, 266);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 17;
            label2.Text = "Konfirmasi Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(32, 290);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 23);
            textBox3.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 167, 206);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 335);
            button1.Name = "button1";
            button1.Size = new Size(212, 23);
            button1.TabIndex = 19;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(201, 15);
            label3.TabIndex = 20;
            label3.Text = "Masukkan email dengan akun terkait";
            // 
            // FormLupaPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 109, 110);
            ClientSize = new Size(290, 505);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(labelEmail);
            Controls.Add(labelLogin);
            Controls.Add(textBox1);
            Name = "FormLupaPassword";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label labelLogin;
        private Label labelEmail;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button button1;
        private Label label3;
    }
}