
using System.Runtime.CompilerServices;

namespace ClubeDoLivro.ConsoleApp
{
    public class Amigo
    {
        public int Id;
        public string Nome;
        public string Telefone;
        public string NomeResponsavel;
       
        public Amigo(string nome, string telefone, string nomeResponsavel)
        {
            Nome = nome;
            Telefone = telefone;
            NomeResponsavel = nomeResponsavel;
        }

        public string Validar()
        {
            string erros = "";

            if (string.IsNullOrWhiteSpace(Nome))
                erros += "O 'nome' é obrigatorio\n";

            if (string.IsNullOrWhiteSpace(Telefone))
                erros += "O 'telefone' é obrigatorio\n";

            if (string.IsNullOrWhiteSpace(NomeResponsavel))
                erros = "'Nome do responsavel' é obrigatorio\n";

            return erros;
        }
    }
}
    

