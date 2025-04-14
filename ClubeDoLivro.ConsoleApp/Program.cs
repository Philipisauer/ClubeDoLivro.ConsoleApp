using ClubeDoLivro.ConsoleApp.ModuloAmigos;

namespace ClubeDoLivro.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaAmigos telaAmigo = new TelaAmigos();
            MenuPrincipal telaPrincipal = new MenuPrincipal();

            while (true)
            {
                char opcaoPrincipal = telaPrincipal.ApresentarMenuInicial();

                if (opcaoPrincipal == '1')
                {
                    char opcaoEscolhida = telaAmigo.ApresentarMenu();

                    switch (opcaoEscolhida)
                    {
                        case '1': telaAmigo.CadastrarAmigo();
                            break;

                        case '2': telaAmigo.EditarAmigo();
                            break;
                    }
                }
                
            }
        }
    }
}
