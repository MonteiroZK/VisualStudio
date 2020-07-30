using BancoDadosAcoes;
using BancoDadosAcoesEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TesteBancoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"\b(\w+?)\s*\1\b";
            //string input = " is this        this a  nice    nice day. What about this? This tastes good. I saw a a dog.";
            //foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
            //    Console.WriteLine("{0} (duplicates '{1}') at position {2}",
            //                      match.Value, match.Groups[1].Value, match.Index);
            //Console.ReadKey();
            //ClassDB db = new ClassDB();

            //Console.WriteLine("Escreva seu login");
            //string login = Console.ReadLine();

            //Console.WriteLine("Escreva seu Senha");
            //string senha = Console.ReadLine();

            //db.Registrar(login, senha);



            var db = new Context();
            var cli = new Client();

            cli. = Console.ReadLine();
            cli.Senha = Console.ReadLine();

        }
    }
}
