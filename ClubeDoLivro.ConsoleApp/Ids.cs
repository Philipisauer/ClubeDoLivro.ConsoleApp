
namespace ClubeDoLivro.ConsoleApp
{
    public static class Ids
    {
        public static int IdAmigo = 0;

    public static int GerarIdAmigo()
        {
            IdAmigo++;

            return IdAmigo;
        }
    }
}
