using ProjetoRedeHoteis.lib.Exception;

namespace ProjetoRedeHoteis.lib.Models
{
    public class Estadia
    {
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Responsavel { get; set; }

        public Estadia (DateTime dataEntrada, DateTime dataSaida, string responsavel)
        {
            SetDataEntrada(dataEntrada);
            SetDataSaida(dataSaida);
            SetResponsavel(responsavel);
        }
        public DateTime GetDataEntrada()
        {
            return DataEntrada;
        }
        public void SetDataEntrada (DateTime dataEntrada)
        {
            DataEntrada = dataEntrada;
        }
        public DateTime GetDataSaida()
        {
            return DataSaida;
        }
        public void SetDataSaida (DateTime dataSaida)
        {
            ValidarDataDeSaida(dataSaida);
            DataSaida = dataSaida;
        }
        public string GetResponsavel()
        {
            return Responsavel;
        }
        public void SetResponsavel (string responsavel)
        {
            Responsavel = responsavel;
        }
        public void ValidarDataDeSaida(DateTime dataSaida)
        {
            if (dataSaida != DateTime.Now)
            {
                throw new ErroDeValidacaoException ("Data de saida menor que entrada");
            }
            DataSaida = dataSaida;
        }
        public void ValidarOcupacaoMaximaDeHospede(double hospede, double ocupacaoMaxima)
        {
            if (hospede > ocupacaoMaxima)
            {
                throw new ErroDeValidacaoException ("Numero de Hospedes excedeu o maximo");
            }
            ocupacaoMaxima = hospede;
        }

    }
}