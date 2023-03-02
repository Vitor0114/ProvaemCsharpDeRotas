namespace View
{
    public class Rota
    {
        public static void CadastrarRota()
        {
            Console.WriteLine("\n----CADASTRAR ROTA----\n");
            Console.Write("Id: ");
            string id = Console.ReadLine();

            Console.Write("\nOrigem: ");
            string origemId = Console.ReadLine();

            Console.Write("\nDestino: ");
            string destinoId = Console.ReadLine();

            Console.Write("\nCaminhão: ");
            string caminhaoId = Console.ReadLine();

            Console.Write("\nData: ");
            string data = Console.ReadLine();

            Console.Write("\nValor R$: ");
            string valor = Console.ReadLine();

            try 
            {
                Controller.Rota.CadastrarRota(id, origemId, destinoId, caminhaoId, data, valor);
                Console.WriteLine("\n----ROTA CADASTRADA COM SUCESSO----\n");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListarRotas() 
        {
            Console.WriteLine("\n----LISTAR ROTAS----\n");
            foreach (string rota in Controller.Rota.ListarRotas()) 
            {
                Console.WriteLine(rota);
            }
        } 

        public static void AlterarRota() 
        {
            Console.WriteLine("\n----ALTERAR ROTA----\n");
            Console.WriteLine("Id: ");
            string id = Console.ReadLine();

            Console.Write("\nOrigem: ");
            string origemId = Console.ReadLine();

            Console.Write("\nDestino: ");
            string destinoId = Console.ReadLine();

            Console.Write("\nCaminhão: ");
            string caminhaoId = Console.ReadLine();

            Console.Write("\nData: ");
            string data = Console.ReadLine();

            Console.Write("\nValor R$: ");
            string valor = Console.ReadLine();

            try 
            {
                Controller.Rota.AlterarRota(id, origemId, destinoId, caminhaoId, data, valor);
                Console.WriteLine("\n----ROTA ALTERADA COM SUCESSO----\n");
            } catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ExcluirRota() {
            Console.WriteLine("\n----EXCLUIR ROTA----\n");
            Console.Write("Id: ");
            string id = Console.ReadLine();

            try 
            {
                Controller.Rota.ExcluirRota(id);
                Console.WriteLine("\n----ROTA EXCLUIDA COM SUCESSO----\n");
            } catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ExibeMediaFrete()
        {
            double media = Controller.Rota.MediaDeFrete();
            Console.WriteLine($"\nA média de todos os fretes é: R${media}");
        }
    }
}