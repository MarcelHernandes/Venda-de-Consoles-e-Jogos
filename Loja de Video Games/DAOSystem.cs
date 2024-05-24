using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Importar o MySQL

namespace Loja_de_Video_Games
{
    class DAOSystem
    {
        public MySqlConnection conexao;
        public string[] nome;
        public string[] senha;
        public string[] ConfSenha;
        public string[] email;
        public int i;
        public int contador;

        public DAOSystem()
        {
            conexao = new MySqlConnection("server=localhost;Database=LojaDeGames;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//fim do construtor

        public string Inserir(string nome, string senha, string ConfSenha, string email)
        {
            string inserir = $"Insert into CadastroInicial(nome, senha, ConfSenha, email) values" +
                $"('{nome}','{senha}','{ConfSenha}','{email}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";
            return resultado;
        }//fim do método
        public void PreencherVetor()
        {
            string query = "select * from CadastroInicial";

            //Instanciar
            this.nome = new string[100];
            this.senha = new string[100];
            this.ConfSenha = new string[100];
            this.email = new string[100];

            //Fazer o comando de seleção do banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //Leitor do banco
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                nome[i] = (leitura["nome"] + "");
                senha[i] = leitura["senha"] + "";
                ConfSenha[i] = leitura["ConfSenha"] + "";
                email[i] = (leitura["email"] + "");
                i++;//Percorrer o vetor
                contador++;//Contar quantos dados eu tenho
            }//fim do while

            //Encerro a comunicação com o software
            leitura.Close();
        }//fim do preencher

        //Criar o método para retornar o contador
        public int QuantidadeDados()
        {
            return contador;
        }//fim do quantidade de dados
    }
}
