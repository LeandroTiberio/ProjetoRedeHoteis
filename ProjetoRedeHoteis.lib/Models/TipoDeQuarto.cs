using ProjetoRedeHoteis.lib.Exception;

namespace ProjetoRedeHoteis.lib.Models
{
    public class TipoDeQuarto
    {
        public int Id { get; set; }
        public List<TipoDeQuarto> TipoDeQuartos { get; set; }
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
            ValidarOcupacaoMaxima(ocupacaoMaximo);
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
        public void ValidarOcupacaoMaxima(double ocupacaoMaximo)
        {
            if (OcupacaoMaxima >4)
            {
                throw new ErroDeValidacaoException ("Ocupação máxima maior que 3 ultrapassada");
            }
            OcupacaoMaxima = ocupacaoMaximo;

        }
    }
}