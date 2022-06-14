namespace ProjetoRedeHoteis.lib.Models
{
    public class Hotel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Cep { get; set; }
        public string Descricao { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Hotel (string nome, string endereco, double cep, string descricao, double telefone,
                    string email, DateTime checkIn, DateTime checkOut)
        {
            SetNome(nome);
            SetEndereco(endereco);
            SetCep(cep);
            SetDescricao(descricao);
            SetTelefone(telefone);
            SetEmail(email);
            SetCheckIn(checkIn);
            SetCheckOut(checkOut);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome (string nome)
        {
            Nome = nome;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco (string endereco)
        {
            Endereco = endereco;
        }
        public double GetCep()
        {
            return Cep;
        }
        public void SetCep (double cep)
        {
            Cep = cep;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao (string descricao)
        {
            Descricao = descricao;
        }
        public double GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone (double telefone)
        {
            Telefone = telefone;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail (string email)
        {
            Email = email;
        }
        public DateTime GetCheckIn()
        {
            return CheckIn;
        }
        public void SetCheckIn (DateTime checkIn)
        {
            CheckIn = checkIn;
        }
        public DateTime GetCheckOut()
        {
            return CheckOut;
        }
        public void SetCheckOut (DateTime checkOut)
        {
            CheckOut = checkOut;
        }

    }
}