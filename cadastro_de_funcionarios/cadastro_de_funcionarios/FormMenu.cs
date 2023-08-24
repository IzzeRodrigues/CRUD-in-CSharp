using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_de_funcionarios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public FormMenu(string login)
        {
            InitializeComponent();
            lblWel.Text = "Bem vindo(a), " + login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastrar cadastro = new FormCadastrar();
            this.Hide();
            cadastro.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAdministar Adm = new FormAdministar();
            this.Hide();
            Adm.Show();
        }

        private void lblWel_Click(object sender, EventArgs e)
        {

        }
    }
}
