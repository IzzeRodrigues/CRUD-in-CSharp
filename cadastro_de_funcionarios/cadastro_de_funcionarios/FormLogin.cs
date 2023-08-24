using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cadastro_de_funcionarios
{
    public partial class FormLogin : Form
    {
       public string sql = "server=localhost; port=3306; database=db_faculdade; uid=root;";
        public string cadastro;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = textUsuario.Text;
            usuario.senha = textSenha.Text;

            string COMMAND = "SELECT cd_senha FROM tb_usuarios WHERE nm_usuario = @user;";
            MySqlConnection verify = new MySqlConnection(sql);
            MySqlCommand mysql = new MySqlCommand(COMMAND,verify);
            mysql.Parameters.AddWithValue("@user", textUsuario.Text);
            verify.Open();

            MySqlDataReader register;
            register = mysql.ExecuteReader();
            register.Read();

            if (register.HasRows)
            {
                cadastro = register["cd_senha"].ToString();
            }
            if (usuario.senha == cadastro)
            {
                FormMenu menu = new FormMenu(textUsuario.Text);
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou Senha Incorretos");
                MessageBox.Show("Por Favor, tente novamente mais tarde.");
                this.Close();
            }
            /*   funciona pra mostrar a senha, mas eu não quero exibir por motivos de segurança.
                    if (usuario.verificar(usuario.mostraNome(),usuario.mostraSenha())) {
                    FormMenu menu = new FormMenu(textUsuario.Text);
                    this.Hide();
                    menu.ShowDialog();
                }
            */
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textUsuario.Text.Trim() == "" || textSenha.Text.Trim() == "")
            {
                MessageBox.Show("Nome de usuário ou senha inconclusivos");
                MessageBox.Show("Por Favor, tente novamente mais tarde.");
               //this.Close();
            }
            else { 
            string COMMAND = "SELECT nm_usuario FROM tb_usuarios WHERE nm_usuario = @user;";
            MySqlConnection verify = new MySqlConnection(sql);
            MySqlCommand mysql = new MySqlCommand(COMMAND, verify);
            mysql.Parameters.AddWithValue("@user", textUsuario.Text);
                verify.Open();

            MySqlDataReader register;
            register = mysql.ExecuteReader();
            register.Read();

            if (register.HasRows)
            {
                cadastro = register["nm_usuario"].ToString();
                MessageBox.Show("Nome de usuário incorreto ou repetido");
                MessageBox.Show("Por Favor, tente novamente mais tarde.");
            }
            else
            {
                MySqlConnection bdConn = new MySqlConnection("server=localhost;database=db_faculdade;uid= root;");

                bdConn.Open();

                string user = textUsuario.Text;
                string senha = textSenha.Text;
                string sql = "INSERT INTO tb_usuarios (nm_usuario, cd_senha, priv_usuario) VALUES ('"
                    + user
                    + "','"
                    + senha
                    + "','"
                    + "user"
                    + "')";
                MySqlCommand inserir = new MySqlCommand(sql, bdConn);
                inserir.BeginExecuteNonQuery();
                MessageBox.Show("Usuario Cadastrado!");
                // this.Close();
            }
           }
        }
    }
}
