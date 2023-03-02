namespace View
{
    public class Cidade
    {
        public static void CadastrarCidade()
        {
            Console.WriteLine("\n----CADASTRAR CIDADE----\n");
            Console.Write("Digite o id da cidade: ");
            string id = Console.ReadLine();

            Console.Write("\nDigite o nome da cidade: ");
            string nome = Console.ReadLine();

            try 
            {
                Controller.Cidade.CadastrarCidade(id, nome);
                Console.WriteLine("\n--CIDADE CADASTRADA COM SUCESSO--\n");
            } catch (Exception e) 
            {
                Console.WriteLine($"Erro ao cadastrar cidade: {e.Message}");
            }
        }

        public static void ListarCidades() 
        {
            Console.WriteLine("\n----LISTAR CIDADES----\n");
            foreach (Model.Cidade cidade in Controller.Cidade.ListarCidades()) 
            {
                Console.WriteLine(cidade);
            }
        }

        public static void AlterarCidade()
        {
            Console.WriteLine("\n----ALTERAR CIDADES----\n");
            Console.Write("Digite o id da cidade: ");
            string id = Console.ReadLine();

            Console.Write("\nDigite o nome da cidade: ");
            string nome = Console.ReadLine();

            try 
            {
                Controller.Cidade.AlterarCidade(id, nome);
                Console.WriteLine("\n----CIDADE ALTERADA COM SUCESSO----\n");
            } catch (Exception e) 
            {
                Console.WriteLine($"Erro ao alterar cidade: {e.Message}");
            }
        }

        public static void ExcluirCidade()
        {
            Console.WriteLine("\n----EXCLUIR CIDADES----\n");
            Console.Write("Digite o id da cidade: ");
            string id = Console.ReadLine();

            try 
            {
                Controller.Cidade.ExcluirCidade(id);
                Console.WriteLine("----\nCIDADE EXCLUIDA COM SUCESSO----\n");
            } catch (Exception e) 
            {
                Console.WriteLine($"Erro ao excluir cidade: {e.Message}");
            }
        }
    }
}