namespace ProjetoRedeHoteis.lib.Models
{
    public class ServicoXHotel : ModelBase
    {
        public int Id {get; set; }
        public int IdHotel { get; set; }
        public int IdEstadia { get; set; }
        
    }
}