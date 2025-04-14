
using System.Threading.Channels;

namespace ClubeDoLivro.ConsoleApp
{
    public class MenuPrincipal
    {
        public char ApresentarMenuInicial()
        {
            Console.Clear();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Clube do livro");
            Console.WriteLine("---------------------------------\n");

            Console.WriteLine("1- Gerenciar Amigos");
            Console.WriteLine("2- ver caixas");
            Console.WriteLine("3- ver atrasos");
            Console.WriteLine("S- sair");

            Console.Write("Digite a função desejada:");

            char opcaoEscolhida = Console.ReadLine()![0];

            return opcaoEscolhida;
        }
    }
}
