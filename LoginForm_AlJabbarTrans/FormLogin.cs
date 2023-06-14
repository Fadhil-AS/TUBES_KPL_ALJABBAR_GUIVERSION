using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using TextBox = System.Windows.Forms.TextBox;
using AlJabbarTrans;

namespace LoginForm_AlJabbarTrans
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        // Method buttonMasuk_Click digunakan untuk masuk ke halaman dashboard/awal dengan menggunakan validasi
        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Email harus memiliki domain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                /*Beranda nextDashboardApp = new Beranda();
                nextDashboardApp.Show();
                this.Hide();*/
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Method buttonDaftar_Click digunakan untuk menampilkan halaman Daftar
        /*private void buttonDaftar_Click(object sender, EventArgs e)
        {
            // Membuat objek dari form selanjutnya
            FormDaftar nextFormDaftar = new FormDaftar();

            // Menampilkan form selanjutnya
            nextFormDaftar.Show();

            // Menyembunyikan form saat ini
            this.Hide();
        }*/

        // Method formLogin_FormClosed digunakan untuk menutup formLogin
        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menutup aplikasi saat formLogin ditutup
            Application.Exit();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister(); 
            register.Show();
            this.Hide();
        }

        // Method labelLupaPassword_Click untuk menampilkan halaman LupaPasswordFormApp
        /*private void labelLupaPassword_Click(object sender, EventArgs e)
        {
            lupaPassword nextLupaPasswordFormApp = new lupaPassword();
            nextLupaPasswordFormApp.Show();
            this.Hide();
        }*/
    }
}