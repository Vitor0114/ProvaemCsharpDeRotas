namespace View
{
    public class Caminhao
    {
        public static void CadastrarCaminhao()
        {
            Console.WriteLine("\n----CADASTRAR CAMINHAO----\n");
            Console.Write("Id: ");
            string id = Console.ReadLine();

            Console.Write("\nPlaca: ");
            string placa = Console.ReadLine();

            Console.Write("\nMotorista: ");
            string motorista = Console.ReadLine();

            try
            {
                Controller.Caminhao.CadastrarCaminhao(id, placa, motorista);
                Console.WriteLine("\n----CAMINHAO CADASTRADO COM SUCESSO!----\n");
            } catch (Exception e) 
            {
                Console.WriteLine($"Erro ao cadastrar caminhao: {e.Message}");
            }
        }

        public static void ListarCaminhoes() 
        {
            Console.WriteLine("\n----LISTAR CAMINHOES----\n");
            foreach (Model.Caminhao caminhao in Controller.Caminhao.ListarCaminhoes()) 
            {
                Console.WriteLine(caminhao);
            }
        }

        public static void AlterarCaminhao()
        {
            Console.WriteLine("\n----ALTERAR CAMINHAO----\n");
            Console.Write("Id: ");
            string id = Console.ReadLine();

            Console.Write("\nPlaca: ");
            string placa = Console.ReadLine();

            Console.Write("\nMotorista: ");
            string motorista = Console.ReadLine();

            try 
            {
                Controller.Caminhao.AlterarCaminhao(id, placa, motorista);
                Console.WriteLine("\n----CAMINHAO ALTERADO COM SUCESSO!----\n");
            } catch (Exception e) 
            {
                Console.WriteLine($"Erro ao alterar caminhao: {e.Message}");
            }
        }

        public static void ExcluirCaminhao()
        {
            Console.WriteLine("\n----EXCLUIR CAMINHAO----\n");
            Console.Write("Id: ");
            string id = Console.ReadLine();

            try 
            {
                Controller.Caminhao.ExcluirCaminhao(id);
                Console.WriteLine("\n----CAMINHAO EXCLUIDO COM SUCESSO----\n");
            } catch (Exception e) 
            {
                Console.WriteLine($"Erro ao excluir caminhao: {e.Message}");
            }
        }

        public static void ListarRotasCaminhao()
        {
            Console.WriteLine("\n----LISTAGEM DE ROTAS DA FROTA----\n");

            foreach (Model.Caminhao caminhao in Model.Caminhao.Caminhoes)
            {
                Console.WriteLine($"Caminhao: {caminhao.Id} - Rotas: {Controller.Caminhao.TotalRotas(caminhao.Id)}");
            }
        }

        public static void ListarValorRotas()
        {
            Console.WriteLine("\n----VALOR TOTAL DAS ROTAS DA FROTA----\n");


            foreach (Model.Caminhao caminhao in Model.Caminhao.Caminhoes)
            {
                Console.WriteLine($"Caminhao: {caminhao.Id} - R${Controller.Caminhao.TotalValorRotasFrota(caminhao.Id)}");
            }
        }
    }
}