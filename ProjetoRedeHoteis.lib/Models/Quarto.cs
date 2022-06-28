namespace ProjetoRedeHoteis.lib.Models
{
    public class Quarto : ModelBase
    {
        public int Id { get; set; }
        public int IdHotel { get; set; }
        public int IdTiposDeQuarto { get; set; }
        public virtual Hotel Hotel {get; set; }
        public List<TipoDeQuarto> TiposDeQuartos { get; set; }
        public virtual TipoDeQuarto TipoDeQuarto { get; set;}
        public double Numero { get; set; }
        public double Andar { get; set; }

        public Quarto (double numero, double andar)
        {
            SetNumero(numero);
            SetAndar(andar);
        }
        public double GetNumero()
        {
            return Numero;
        }
        public void SetNumero (double numero)
        {
            Numero = numero;
        }
        public double GetAndar()
        {
            return Andar;
        }
        public void SetAndar (double andar)
        {
            Andar = andar;
        }
    }
}