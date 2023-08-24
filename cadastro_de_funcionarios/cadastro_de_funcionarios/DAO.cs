using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cadastro_de_funcionarios
{
    public class DAO
    {
        public DAO()
        {
            nomeBanco = "db_faculdade";
            nomeUsuario = "root";
            senhaBanco = "";
            serverBanco = "localhost";
        }
        string nomeBanco, nomeUsuario, senhaBanco, serverBanco;
    }
}
