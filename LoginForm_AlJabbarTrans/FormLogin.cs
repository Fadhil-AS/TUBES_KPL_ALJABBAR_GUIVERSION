using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RegisterFormsApp;

namespace LoginForm_AlJabbarTrans
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            /*Color customColor = Color.FromArgb(71, 169, 146);
            this.BackColor = customColor;*/
        }

        // Method textBoxPassword_TextChanged digunakan untuk mengganti bentuk teks menjadi asterisk
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.Text = new string('*', textBoxPassword.TextLength);
        }

        // Method textBoxPassword_KeyPress digunakan untuk menghapus asterisk dengan kondisi tertentu
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa jika tombol yang ditekan adalah "Backspace" atau "Delete"
            if (e.KeyChar == '\b' || e.KeyChar == (char)Keys.Delete)
            {
                // Menyimpan posisi kursor saat ini
                int cursorPosition = textBoxPassword.SelectionStart;

                // Jika ada karakter yang dipilih, hapus karakter yang dipilih
                if (textBoxPassword.SelectionLength > 0)
                {
                    textBoxPassword.Text = textBoxPassword.Text.Remove(textBoxPassword.SelectionStart, textBoxPassword.SelectionLength);
                }
                // Jika tidak ada karakter yang dipilih, hapus satu karakter sebelum kursor
                else if (cursorPosition > 0)
                {
                    textBoxPassword.Text = textBoxPassword.Text.Remove(cursorPosition - 1, 1);
                }

                // Menset posisi kursor kembali ke posisi awal
                textBoxPassword.SelectionStart = cursorPosition - 1;

                // Mencegah karakter yang ditekan ditampilkan di TextBox
                e.Handled = true;
            }
        }

        // Method buttonMasuk_Click digunakan untuk masuk ke halaman dashboard/awal dengan menggunakan validasi
        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            // Memeriksa jika email atau password kosong
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan eksekusi dan tetap berada di halaman login
            }
            else 
            {
                //
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Method buttonDaftar_Click digunakan untuk menampilkan halaman Daftar
        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            // Membuat objek dari form selanjutnya
            FormDaftar nextFormDaftar = new FormDaftar();

            // Menampilkan form selanjutnya
            nextFormDaftar.Show();

            // Menyembunyikan form saat ini
            this.Hide();
        }

        // Method formLogin_FormClosed digunakan untuk menutup formLogin
        private void formLogin_FormClosed(object sender, FormClosedEventArgs e) { 
            // Menutup aplikasi saat formLogin ditutup
            Application.Exit();
        }
    }
}