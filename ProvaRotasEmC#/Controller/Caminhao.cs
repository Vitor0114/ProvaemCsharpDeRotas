namespace Controller
{
    public class Caminhao
    {
        public static void CadastrarCaminhao(string id, string placa, string motorista)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {
                throw new Exception("Id invalido");
            }

            ValidaPlaca(placa);
            Model.Caminhao caminhao = new Model.Caminhao(idConvert, placa, motorista);
        }

        public static List<Model.Caminhao> ListarCaminhoes()
        {
            return Model.Caminhao.Caminhoes;
        }

        public static void AlterarCaminhao(string id, string placa, string motorista)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {
                throw new Exception("Id invalido");
            }

            ValidaPlaca(placa);
            Model.Caminhao.AlterarCaminhao(idConvert, placa, motorista);
        }

        public static void ExcluirCaminhao(string id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {
                throw new Exception("Id invalido");
            }

            Model.Caminhao.ExcluirCaminhao(idConvert);
        }

        public static Model.Caminhao BuscarCaminhao(string id)
        {
            int idConvert = 0;
            try
            {
                idConvert = int.Parse(id);
            }
            catch (Exception)
            {

                throw new Exception("Id invalido");
            }

            return Model.Caminhao.BuscarCaminhao(idConvert);
        }

        private static void ValidaPlaca(string placa)
        {
            string[] placaSplit = placa.Split('-');
            if (placaSplit.Length != 2)
            {
                throw new Exception("Placa invalida");
            }
            if (placaSplit[0].Length != 3)
            {
                throw new Exception("Placa invalida");
            }
            if (placaSplit[1].Length != 4)
            {
                throw new Exception("Placa invalida");
            }

            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";

            foreach (char letra in placaSplit[0])
            {
                if (!letras.Contains(letra.ToString()))
                {
                    throw new Exception("Placa invalida");
                }
            }

            foreach (char numero in placaSplit[1])
            {
                if (!numeros.Contains(numero.ToString()))
                {
                    throw new Exception("Placa invalida");
                }
            }
        }

        public static int TotalRotas(int idCaminhao)
        {
            int totalRotas = (from rota in Model.Rota.Rotas where rota.Caminhao.Id == idCaminhao select rota).Count();
            return totalRotas;
        }
        
        public static double TotalValorRotasFrota(int idCaminhao)
        {

            double rotas = (from rota in Model.Rota.Rotas
                            where rota.Caminhao.Id == idCaminhao
                            select rota.Valor).Sum();

            return rotas;
        }
    }
}