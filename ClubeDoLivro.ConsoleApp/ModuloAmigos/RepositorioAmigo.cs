
namespace ClubeDoLivro.ConsoleApp
{
    public class RepositorioAmigo
    {
        public Amigo[] amigo = new Amigo[100];
        public int contadorAmigo = 0;

        public void CadastrarAmigo(Amigo novoAmigo)
        {
            novoAmigo.Id = Ids.GerarIdAmigo();


            amigo[contadorAmigo++] = novoAmigo;
        }
    }
}

        



