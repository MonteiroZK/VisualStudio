using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    class Program
    {

  
        
        static void Main(string[] args)
        {
            int cont =0;

            // verificarUserSenha(usuario, senha);
            while (cont<= 2)
            {
                Console.WriteLine("Usuario:");
                string usuario = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Senha:");
                string senha = Console.ReadLine();
                Console.WriteLine("");
                if (usuario == "teste" && senha == "teste")
                {
                    Console.WriteLine("Logou com sucesso");

                    break;
                }
                else
                {
                    cont =cont + 1;
                    Console.WriteLine("Login ou senha Invalida");
                    Console.WriteLine("Você tem {0}/3 tentativas",cont);
                }
            }

        }

        public void AbrirConta()
        {
            int operacao = 1;
            while (operacao < 0)
            {
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("");
                Console.WriteLine("F1 ou 1 - Sacar");
                Console.WriteLine("F2 ou 2 - Depositar");
                Console.WriteLine("F3 ou 3 - Ver Saldo");
                Console.WriteLine("ESC ou 4 - Sair");
            }
        }



    }
}
