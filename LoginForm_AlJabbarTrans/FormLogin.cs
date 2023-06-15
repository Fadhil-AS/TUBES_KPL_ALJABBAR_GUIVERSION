using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using TextBox = System.Windows.Forms.TextBox;
using AlJabbarTrans;
using AlJabbarLibraries;
using static AlJabbarLibraries.Automata;

namespace LoginForm_AlJabbarTrans
{
    public partial class formLogin : Form
    {
        private Automata menu;

        public formLogin()
        {
            InitializeComponent();
            menu = new Automata();

            // Mengatur state adalah Login
            menu.currentState = prosesPesan.LOGIN;
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
                prosesPesan nextState = menu.activateTrigger(Trigger.MASUK);
                Beranda nextDashboardApp = new Beranda(nextState);
                nextDashboardApp.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            prosesPesan nextState = menu.activateTrigger(Trigger.DAFTAR);
            FormRegister register = new FormRegister(nextState);
            register.Show();
            this.Hide();
        }

        private void labelLupaPassword_Click(object sender, EventArgs e)
        {
            prosesPesan nextState = menu.activateTrigger(Trigger.LUPA);
            FormLupaPassword formLupaPassword = new FormLupaPassword(nextState);
            formLupaPassword.Show();
            this.Hide();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}