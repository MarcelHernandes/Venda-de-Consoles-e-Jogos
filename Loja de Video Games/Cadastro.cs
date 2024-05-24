using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja_de_Video_Games
{
    public partial class Cadastro : Form
    {
        DAOSystem bd;
        public Cadastro()
        {
            InitializeComponent();
            bd = new DAOSystem();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void ColocarNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColocarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColocarEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConcluirCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados do Banco
                string nome = ColocarNome.Text;
                string senha = ColocarSenha.Text;
                string ConfSenha = ConfirmarSenha.Text;
                string email = ColocarEmail.Text;
                //Cadastrar
                MessageBox.Show(bd.Inserir(nome, senha, ConfSenha, email));//Insere dados no BD
                                                                           //Limpar a tela
                ColocarNome.Text = "";
                ColocarSenha.Text = "";
                ConfirmarSenha.Text = "";
                ColocarEmail.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//fim do botão cadastrar


    }
}
