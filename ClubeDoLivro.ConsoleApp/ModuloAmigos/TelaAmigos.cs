

using System.Security.Cryptography.X509Certificates;

namespace ClubeDoLivro.ConsoleApp.ModuloAmigos
{
    

    public class TelaAmigos
    {
        string Nome;
        string Telefone;
        string NomeResponsavel;

        public RepositorioAmigo repositorioAmigo;

        public TelaAmigos()
        {
            repositorioAmigo = new RepositorioAmigo();
        }
        public char ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("digite a operaçao desejada");
            Console.WriteLine("1- cadastrar amigo");
            Console.WriteLine("2- editar informaçoes de amigo");
            Console.WriteLine("3- desvincular amigo");

            char opcaoEscolhida = Console.ReadLine()![0];
            ;

            return opcaoEscolhida;
        }
        public void CadastrarAmigo()
        {
            Amigo novoAmigo = ObterDadosAmigo();

            string erros = novoAmigo.Validar();

            repositorioAmigo.CadastrarAmigo(novoAmigo);

            Console.WriteLine("Amigo adicionado com sucesso");

        }
        public Amigo ObterDadosAmigo()
        {
            Console.WriteLine("Digite o nome do amigo:");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Digite o Telefone do amigo:");
            string telefone = Console.ReadLine()!;

            Console.WriteLine("Digite o responsavel do amigo:");
            string nomeResponsavel = Console.ReadLine()!;

            Amigo amigo = new Amigo(nome, telefone, nomeResponsavel);

            return amigo;
        }

        public void EditarAmigo()
        {

            Console.Write("Digite o Id do Amigo que deseja editar: ");
            string Id = (Console.ReadLine()!);
        }
        public void VerAmigos()
        {
            Console.WriteLine($"Nome:{Nome}");
            Console.WriteLine($"Telefone:{Telefone}");
            Console.WriteLine($"Nome do responsavel:{NomeResponsavel}");
        }
    }
}

