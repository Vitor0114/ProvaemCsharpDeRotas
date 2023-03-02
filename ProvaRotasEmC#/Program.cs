namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int menu = 0;

            do
            {
                Console.WriteLine("\n( 1 ) - Cadastrar Caminhao");
                Console.WriteLine("( 2 ) - Listar Caminhao");
                Console.WriteLine("( 3 ) - Alterar Caminhao");
                Console.WriteLine("( 4 ) - Excluir Caminhao");
                Console.WriteLine("\n( 5 ) - Cadastrar Cidade");
                Console.WriteLine("( 6 ) - Listar Cidade");
                Console.WriteLine("( 7 ) - Alterar Cidade");
                Console.WriteLine("( 8 ) - Excluir Cidade");
                Console.WriteLine("\n( 9 ) - Cadastrar Rota");
                Console.WriteLine("( 10 ) - Listar Rota");
                Console.WriteLine("( 11 ) - Alterar Rota");
                Console.WriteLine("( 12 ) - Excluir Rota");
                Console.WriteLine("\n( 13 ) - Listar as rotas da frota");
                Console.WriteLine("( 14 ) - Listar o valor total das rotas da frota");
                Console.WriteLine("( 15 ) - Listar a media (R$)  das rotas");
                Console.WriteLine("( 16 ) - Sair");
                Console.Write("\nDigite a opcao: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        View.Caminhao.CadastrarCaminhao();
                        break;
                    case 2:
                        View.Caminhao.ListarCaminhoes();
                        break;
                    case 3:
                        View.Caminhao.AlterarCaminhao();
                        break;
                    case 4:
                        View.Caminhao.ExcluirCaminhao();
                        break;
                    case 5:
                        View.Cidade.CadastrarCidade();
                        break;
                    case 6:
                        View.Cidade.ListarCidades();
                        break;
                    case 7:
                        View.Cidade.AlterarCidade();
                        break;
                    case 8:
                        View.Cidade.ExcluirCidade();
                        break;
                    case 9:
                        View.Rota.CadastrarRota();
                        break;
                    case 10:
                        View.Rota.ListarRotas();
                        break;
                    case 11:
                        View.Rota.AlterarRota();
                        break;
                    case 12:
                        View.Rota.ExcluirRota();
                        break;
                    case 13:
                        View.Caminhao.ListarRotasCaminhao();
                        break;
                    case 14:
                        View.Caminhao.ListarValorRotas();
                        break;
                    case 15:
                        View.Rota.ExibeMediaFrete();
                        break;
                    case 16:
                        Console.WriteLine("Obrigado volte sempre!");
                        break;

                    default:
                        Console.WriteLine("opcao invalida!");
                        break;
                }
            } while (menu != 0);
        }
    }
}