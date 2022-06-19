namespace ProjetoRedeHoteis.web.Properties.DTOs
{
    public class HotelDTO
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Cep { get; set; }
        public string Descricao { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}