namespace ProjetoRedeHoteis.lib.Models
{
    public class TipoDeQuarto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double OcupacaoMaxima { get; set; }
        public double NumeroDeCamas { get; set; }

        public TipoDeQuarto (string nome, string descricao, double ocupacaoMaximo, double numeroDeCamas)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetOcupacaoMaximo(ocupacaoMaximo);
            SetNumeroDeCamas(numeroDeCamas);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome (string nome)
        {
            Nome = nome;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao (string descricao)
        {
            Descricao = descricao;
        }
        public double GetOcupacaoMaxima()
        {
            return OcupacaoMaxima;
        }
        public void SetOcupacaoMaximo (double ocupacaoMaximo)
        {
            OcupacaoMaxima = ocupacaoMaximo;
        }
        public double GetNumeroDeCamas()
        {
            return NumeroDeCamas;
        }
        public void SetNumeroDeCamas (double numeroDeCamas)
        {
            NumeroDeCamas = numeroDeCamas;
        }
    }
}