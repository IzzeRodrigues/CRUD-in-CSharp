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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }
        public string mySqlString = "server=localhost; port=3306; uid=root; database= db_faculdade";
        public MySqlDataAdapter adapter;
        public DataSet data;
        private void FormConsulta_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mySqlString);
            string sql = "SELECT nm_funcionario, cd_funcionarios FROM tb_funcionarios";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            try
            {
                conn.Open();
                cmd.BeginExecuteNonQuery();
                gridConst.DataSource = data;

                DataGridViewButtonColumn excluirUsuario = new DataGridViewButtonColumn();
                excluirUsuario.HeaderText = "Exclui";
                excluirUsuario.Name = "excluir_usuario";
                excluirUsuario.Text = "Excluir";
                excluirUsuario.UseColumnTextForButtonValue = true;
                gridConst.Columns.Add(excluirUsuario);

                DataGridViewButtonColumn alterarUsuario = new DataGridViewButtonColumn();
                alterarUsuario.HeaderText = "Altera";
                alterarUsuario.Name = "alterar_usuario";
                alterarUsuario.Text = "Alterar";
                alterarUsuario.UseColumnTextForButtonValue = true;
                gridConst.Columns.Add(alterarUsuario);

            }
            catch (MySqlException ex)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormCadastrar volta = new FormCadastrar();
            this.Hide();
            volta.Show();
        }

        private void gridConst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridConst.Columns["excluir_usuario"].Index)
            {
                MySqlConnection conn = new MySqlConnection(mySqlString);

                string id = (string)gridConst.Rows[e.RowIndex].Cells["nm_funcionario"].Value;
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM tb_funcionarios WHERE nm_funcionario = @id", conn);
                deleteCommand.Parameters.AddWithValue("@id", id);
                conn.Open();
                deleteCommand.ExecuteNonQuery();
                conn.Close();
                gridConst.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Usuário excluído com sucesso!");
            }
            if (e.ColumnIndex == gridConst.Columns["alterar_usuario"].Index)
            {
                MySqlConnection conn = new MySqlConnection(mySqlString);
                int id = (int)gridConst.Rows[e.RowIndex].Cells["cd_funcionarios"].Value;
                string nome = (string)gridConst.Rows[e.RowIndex].Cells["nm_funcionario"].Value;
                MySqlCommand updateCommand = new MySqlCommand("UPDATE tb_funcionarios SET nm_funcionario = @nome WHERE cd_funcionarios = @id;", conn);
                updateCommand.Parameters.AddWithValue("@nome", nome);
                updateCommand.Parameters.AddWithValue("@id", id);
                conn.Open();
                updateCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuário alterado com sucesso!");
            }
        }
    }
}
