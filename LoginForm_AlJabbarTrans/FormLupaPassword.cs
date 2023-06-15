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


        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
            menu.activateTrigger(Trigger.MASUK);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLupaPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
