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

namespace AlJabbarTrans
{
    public partial class FormRegister : Form
    {
        private string email;
        private string password;
        private string konfirmasi;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            email = textBoxEmail.Text;
            password = textBoxPassword.Text;
            konfirmasi = textBoxKonfirmasiPassword.Text;

            if (email.Contains("@") && !password.Equals("") && !konfirmasi.Equals(""))
            {
                MessageBox.Show("Akun berhasil didaftarkan!");
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
    }
}
