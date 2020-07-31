using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPedraPapelTesoura
{
    public partial class Jogo : Form
    {
        enum opcao { Pedra, Papel, Tesoura };
        enum Resultado { Jogador,CPU,Empate}
        opcao jogador = new opcao();
        opcao cpu = new opcao();
        Random rdm = new Random();
        Resultado ganhador = new Resultado();
        public Jogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbljogadaCPU.Text = "0";
            lbljogPlacar.Text = "0";
        }

        private void picturePedra_Click(object sender, EventArgs e)
        {
            jogador = opcao.Pedra;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        private void picturePapel_Click(object sender, EventArgs e)
        {
            jogador = opcao.Papel;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        private void pictureTesoura_Click(object sender, EventArgs e)
        {
            jogador = opcao.Tesoura;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();
        }

        void EscolhaJogador()
        {
            switch (jogador)
            {
                case opcao.Pedra:
                    picJogador.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\pedra.png"); 
                    break;
                case opcao.Papel:
                    picJogador.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\papel.png");
                    break;
                case opcao.Tesoura:
                    picJogador.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\tesoura.png");
                    break;
            }
        }

        void EscolhaCpu()
        {
            int numero = rdm.Next(1, 4);

            if(numero == 1)
            {
                cpu = opcao.Pedra;
                picCPU.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\pedra.png");
            }
            else if (numero == 2)
            {
                cpu = opcao.Papel;
                picCPU.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\papel.png");

            }
            else if (numero == 3)
            {
                cpu = opcao.Tesoura;
                picCPU.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\tesoura.png");


            }
        }

        void VerificarGanhador()
        {
            switch (jogador)
            {
                case opcao.Pedra:
                    if (cpu == opcao.Pedra)
                        ganhador = Resultado.Empate;
                    else if (cpu == opcao.Papel)
                        ganhador = Resultado.CPU;
                    else if (cpu == opcao.Tesoura)
                        ganhador = Resultado.Jogador;
                    break;

                  case opcao.Papel:
                    if (cpu == opcao.Pedra)
                        ganhador = Resultado.Jogador;
                    else if (cpu == opcao.Papel)
                        ganhador = Resultado.Empate;
                    else if (cpu == opcao.Tesoura)
                        ganhador = Resultado.CPU;
                    break;

                case opcao.Tesoura:
                    if (cpu == opcao.Pedra)
                        ganhador = Resultado.CPU;
                    else if (cpu == opcao.Papel)
                        ganhador = Resultado.Jogador;
                    else if (cpu == opcao.Tesoura)
                        ganhador = Resultado.Empate;
                    break;
            }
            if(ganhador == Resultado.Jogador)
            {
                int vlPlayer = Convert.ToInt32(lbljogPlacar.Text) + 1;
                lbljogPlacar.Text = "" + vlPlayer ;
                picbob.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\olhafoca.png");
            }
            else if(ganhador == Resultado.CPU)
            {
                picbob.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\ficasussa.png");
           
                int vlCPU = Convert.ToInt32(lbljogadaCPU.Text) + 1;
                lbljogadaCPU.Text = "" + vlCPU ;
            }else
            {
                picbob.Image = Image.FromFile(@"C:\Users\thiag\source\repos\JogoPedraPapelTesoura\JogoPedraPapelTesoura\ArquivosJoKenPo\dormideboas.png");
                MessageBox.Show("Empate", "Empate");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
