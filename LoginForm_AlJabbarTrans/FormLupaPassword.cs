using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlJabbarLibraries;
using LoginForm_AlJabbarTrans;
using static AlJabbarLibraries.Automata;

namespace AlJabbarTrans
{
    public partial class FormLupaPassword : Form
    {
        private Automata menu;

        public FormLupaPassword(prosesPesan currentState)
        {
            InitializeComponent();
            menu = new Automata();
            menu.currentState = currentState;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string konfirmasiPass = textBoxKonfirmasiPass.Text;

            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password) && string.IsNullOrEmpty(konfirmasiPass))
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
            else if (string.IsNullOrEmpty(konfirmasiPass))
            {
                MessageBox.Show("Konfirmasi Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password != konfirmasiPass)
            {
                MessageBox.Show("Password dan Konfirmasi Password harus sama!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Email harus memiliki domain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Password telah berhasil di ganti!");
                menu.activateTrigger(Trigger.MASUK);
                formLogin login = new formLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
