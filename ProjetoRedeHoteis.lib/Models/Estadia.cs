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

    }
}