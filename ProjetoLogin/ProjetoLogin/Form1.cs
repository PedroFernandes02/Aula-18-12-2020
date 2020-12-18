using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdEntrar.Enabled = false;
        }

        private void textTextChanged(object sender, EventArgs e)
        {
            cmdEntrar.Enabled = textUtilizador.Text != "" && textPassword.Text != "" ? true : false;
        }

        private void textUtilizador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPassword.Focus();
            }
        }

        private void textPassword_KeyDow(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdEntrar_Click(this, EventArgs.Empty);
            }

        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou");
        }
    }
}
