namespace ProjetoRedeHoteis.lib.Models
{
    public class Quarto
    {
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