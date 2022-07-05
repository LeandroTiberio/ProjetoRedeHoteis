namespace ProjetoRedeHoteis.lib.Models
{
    public class EstadiaXHospede : ModelBase
    {
        public int Id { get; set; }
        public int IdEstadia { get; set; }
        public int IdHospede { get; set; }
        public virtual Hospede Hospede {get; set; }
        public virtual Estadia Estadia {get; set; }
        
    }
}