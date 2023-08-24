using MySql.Data.MySqlClient;
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
    public partial class FormAdministar : Form
    {
        public FormAdministar()
        {
            InitializeComponent();
        }
        public string mySqlString = "server=localhost; port=3306; uid=root; database= db_faculdade";
        private void FormAdministar_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mySqlString);
            string sql = "SELECT * FROM tb_usuarios";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                gridAdm.DataSource = data;

            }
            catch(MySqlException ex)
            {
                throw new Exception($"Erro ao carregar tabela: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            FormMenu Volta = new FormMenu();
            this.Hide();
            Volta.Show();
        }
    }
}
