using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_Video_Games
{
    public partial class Form1 : Form
    {
        Cadastro cad;
        Login log;
        Meu_carrinho car;
        Assistência assis;
        Jogos_a_venda games;
        Consoles_a_venda consoles;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastro();
            log = new Login();
            car = new Meu_carrinho();
            assis = new Assistência();
            games = new Jogos_a_venda();
            consoles = new Consoles_a_venda();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//fim do botão cadastrar
        private void Entrar_Click(object sender, EventArgs e)
        {
            log.ShowDialog();
        }
        private void Carrinho_Click(object sender, EventArgs e)
        {
            car.ShowDialog();
        }
        private void PrecisandoDeAjuda_Click(object sender, EventArgs e)
        {
            assis.ShowDialog();
        }
        private void JogosAVenda_Click(object sender, EventArgs e)
        {
            games.ShowDialog();
        }
        private void ConsolesAVenda_Click(object sender, EventArgs e)
        {
            consoles.ShowDialog();
        }
    }
}
