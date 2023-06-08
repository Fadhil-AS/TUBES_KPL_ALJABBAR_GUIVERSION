using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RegisterFormsApp;
using DashboardApp;
using LupaPasswordFormsApp;
using System.Diagnostics.Contracts;
using System.Diagnostics;

namespace LoginForm_AlJabbarTrans
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();

            // Melakukan set State awal
            currentState = State.Idle;
        }

        // Daftar state dalam state machine
        private enum State
        { 
            Idle,
            InputEmail,
            InputPassword,
            LoggedIn
        }

        private State currentState;

        // Table transisi untuk state machine
        private readonly State[,] transitionTable =
        {
            // State awal     Event                       Next State
            /* Idle */   { State.InputEmail,           State.Idle,         State.Idle},
            /* InputEmail */  { State.InputEmail,  State.InputPassword,  State.Idle},
            /* LoggedIn */  { State.InputEmail,     State.InputPassword, State.LoggedIn}
        };

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

        // Mendapatkan indeks event berdasarkan state saat ini
        private int GetEventIndex()
        {
            switch (currentState)
            {
                case State.Idle:
                    return 0;
                case State.InputEmail:
                    return 1;
                case State.InputPassword:
                    return 2;
                case State.LoggedIn:
                    return 3;
                default:
                    return -1;
            }
        }

        // Method buttonMasuk_Click digunakan untuk masuk ke halaman dashboard/awal dengan menggunakan validasi
        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            // Precondition: Email dan password tidak boleh kosong
            Contract.Requires(email != "");
            Contract.Requires(password != "");
            Debug.Assert(!string.IsNullOrEmpty(email), "Email tidak boleh kosong!");
            Debug.Assert(!string.IsNullOrEmpty(password), "Password tidak boleh kosong!");

            // Precondition: Email harus memiliki domain atau symbol "@"
            Contract.Requires(email == "@");
            Debug.Assert(email.Contains("@"), "Email harus memiliki domain");


            // Melakukan pengechekan event saat ini dan memperoleh next state dari tabel transisi
            State nextState = transitionTable[(int)currentState, GetEventIndex()];

            // Postcondition: nextState harus State.LoggedIn
            Contract.Ensures(nextState == State.LoggedIn);
            Debug.Assert(nextState == State.Idle, "Masih berada di halaman Login");
            

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                currentState = nextState;
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Email harus memiliki domain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                currentState = nextState;
            }
            else
            {
                dashboardApp nextDashboardApp = new dashboardApp();
                nextDashboardApp.Show();
                this.Hide();
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
        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menutup aplikasi saat formLogin ditutup
            Application.Exit();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLupaPassword_Click(object sender, EventArgs e)
        {
            lupaPassword nextLupaPasswordFormApp = new lupaPassword();
            nextLupaPasswordFormApp.Show();
            this.Hide();
        }
    }
}