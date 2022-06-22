namespace ProjetoRedeHoteis.lib.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public List<Estadia> Estadias { get; set; }
        public List<ServicoXHotel> ServicosXHOteis { get; set; }
        public string Nome { get; set; }

        public Servico (string nome)
        {
            SetNome(nome);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome (string nome)
        {
            Nome = nome;
        }
    }
}