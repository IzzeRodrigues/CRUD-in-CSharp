using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormCadastrar : Form
    {
       public string sql = "server=localhost; port=3306; database=db_faculdade; uid=root;";
        public ArrayList funcionarios = new ArrayList();
        string nome;

       

        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FormCadastrar_Load(object sender, EventArgs e)
        {

        }


        private void lblCad_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textNome.Text.Trim() == "")
            {
                MessageBox.Show("Cadastro Incorreto");
                MessageBox.Show("Por Favor, tente novamente mais tarde.");
                // this.Close();
            }
            else
            {
                nome = textNome.Text;
                funcionarios.Add(nome);
            }
        }

        private void btnForm_Click_1(object sender, EventArgs e)
        {
            
           
            if (textNome.Text.Trim() == "")
            {
                MessageBox.Show("Cadastro Incorreto");
                MessageBox.Show("Por Favor, tente novamente mais tarde.");
                // this.Close();
            }
            else
            {
                FormInfos infos = new FormInfos(funcionarios);
                this.Hide();
                infos.ShowDialog();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            if (textNome.Text.Trim() == "" )
            {
                MessageBox.Show("Você não pode consultar o banco sem inserir um novo funcionário.");
                MessageBox.Show("Por Favor, tente novamente mais tarde.");
               // this.Close();
            }
            else
            {
                string COMMAND = "SELECT nm_funcionario FROM tb_funcionarios WHERE nm_funcionario = @user;";
                MySqlConnection ver = new MySqlConnection("server=localhost;database=db_faculdade;uid= root;");
                MySqlCommand mysql = new MySqlCommand(COMMAND, ver);
                mysql.Parameters.AddWithValue("@user", textNome.Text);
                ver.Open();

                MySqlDataReader register;
                register = mysql.ExecuteReader();
                register.Read();

                if (register.HasRows)
                {
                    string cadastro;
                    cadastro = register["nm_funcionario"].ToString();
                    MessageBox.Show("Nome de usuário incorreto ou repetido");
                    MessageBox.Show("Por Favor, tente novamente mais tarde.");
                    // this.Close();
                }
                else
                {
                    MySqlConnection bdConn = new MySqlConnection("server=localhost;database=db_faculdade;uid= root;");
                    bdConn.Open();
                    string nome = textNome.Text;
                    string sql = "INSERT INTO tb_funcionarios (nm_funcionario) VALUES ('" + nome + "')";
                    MySqlCommand inserir = new MySqlCommand(sql, bdConn);
                    inserir.BeginExecuteNonQuery();

                    FormConsulta profs = new FormConsulta();
                    this.Hide();
                    profs.Show();

                }
            }
            
        }

        private void btnVolar_Click(object sender, EventArgs e)
        {
            FormMenu volta = new FormMenu();
            this.Hide();
            volta.ShowDialog();
        }
    }
    }

