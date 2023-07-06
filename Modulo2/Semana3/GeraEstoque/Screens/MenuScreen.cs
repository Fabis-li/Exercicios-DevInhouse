using GeraEstoque.Models;
using GeraEstoque.Repositories;
namespace GeraEstoque.Screens
{
   public static class MenuScreen
    {
        public static void Iniciar(ProdutoRepository repository)
        {
            Console.Clear();
            PrintTitleLine(); 
            ShowOptions();           

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: CriarProdutoScreen.Iniciar(repository); Iniciar(repository); break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: ListarProdutosScreen.Iniciar(repository);Iniciar(repository);break;
                case 0: 
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Environment.Exit(0); break;
            }

            Console.ReadLine();
        }

        static void PrintTitleLine ()
        {
             
            Console.WriteLine("Seja bem vindo ao GeraEstoque 1.0" );
                for (int i = 0; i <= 35; i++)            
                    Console.Write("-");              
            Console.WriteLine();           
            
        }

        static void ShowOptions()
        {
            Console.WriteLine("1 Cadastrar Produto");
            Console.WriteLine("2 Consultar Produto");
            Console.WriteLine("3 Modificar Produto");
            Console.WriteLine("4 Excluir Produto");
            Console.WriteLine("5 Listar Todos os Produtos");
            Console.WriteLine("0 Sair");
            Console.WriteLine();
            Console.Write("Digite a opção: ");
        }

        public static void Cadastar()
       {
        
      }
    }
}