using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_funcionarios
{
    public class Usuario //cria a classe pra usar
    {
        public Usuario() //construtor 
        {
            nome = "";
            senha = "";
            privilegio = "";
            sexo = 1;
            trabalho = 1;
            nasc = "";

        } 
        public bool verificar(string login, string entra)
        {
       
            if (login == "izze" && entra == "123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // declarando variáveis
        public string nome; 
        public string senha;
        public string privilegio;
        public int sexo;
        public int trabalho;
        public string nasc;
        // criando funções - metodos
        public string mostraNome()
        {
            return nome;
        }
        public string mostraSenha()
        {
            return senha;
        }
  
    }
}
