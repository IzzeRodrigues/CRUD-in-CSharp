using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_de_funcionarios
{
    public partial class FormInfos : Form
    {

        string nome;
        public FormInfos()
        {
            InitializeComponent();
        }
        public FormInfos(ArrayList funcionarios)
        {
            InitializeComponent();

            foreach (object nome in funcionarios)
            {
                textInfos.Text += nome;
                textInfos.Text += Environment.NewLine;
            }
        }

        private void textInfos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormCadastrar Voltar = new FormCadastrar();
            this.Hide();
            Voltar.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "arquivo texto | *.txt";
            sfd.ShowDialog();

            if( string.IsNullOrEmpty(sfd.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(textInfos.Text);
                        writer.Flush();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível salvar o arquivo.");
                    this.Close();
                }
            }
        }
    }
}
