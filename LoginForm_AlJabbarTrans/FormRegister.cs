using AlJabbarLibraries;
using LoginForm_AlJabbarTrans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlJabbarLibraries.Automata;

namespace AlJabbarTrans
{
    public partial class FormRegister : Form
    {
        private Automata menu;

        public FormRegister(prosesPesan currentState)
        {
            InitializeComponent();
            menu = new Automata();
            menu.currentState = currentState;
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string konfirmasi = textBoxKonfirmasiPassword.Text;

            if (email.Contains("@") && !password.Equals("") && !konfirmasi.Equals(""))
            {
                MessageBox.Show("Akun berhasil didaftarkan!");
                menu.activateTrigger(Trigger.MASUK);
                formLogin login = new formLogin();
                login.Show();
                this.Hide();
            }
            else if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(konfirmasi))
            {
                MessageBox.Show("Harap isi semua bidang dengan benar.");
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Email harus memiliki domain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
