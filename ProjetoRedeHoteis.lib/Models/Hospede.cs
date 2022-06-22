using ProjetoRedeHoteis.lib.Exception;

namespace ProjetoRedeHoteis.lib.Models
{
    public class Hospede
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public double Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public Hospede (string nome, double cpf, string email, string telefone, DateTime dataNascimento)
        {
            SetNome(nome);
            SetCpf(cpf);
            SetEmail(email);
            SetTelefone(telefone);
            SetDataNascimento(dataNascimento);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome (string nome)
        {
            Nome = nome;
        }
        public double GetCpf()
        {
            return Cpf;
        }
        public void SetCpf (double cpf)
        {
            ValidarCpf(cpf);
            Cpf = cpf;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail (string email)
        {
            ValidarEmail(email);
            Email = email;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone (string telefone)
        {
            ValidarTelefone(telefone);
            Telefone = telefone;
        }
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento (DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
        public void ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                throw new ErroDeValidacaoException ("Email invalido falta de caracter @");
            }
            Email = email;
        }
        public void ValidarTelefone(string telefone)
        {
            if (telefone.Length < 15)
            {
                throw new ErroDeValidacaoException ("Telefone invalido");
            }
        }
        public void ValidarCpf(double cpf)
        {
            if (cpf < 12)
            {
                throw new ErroDeValidacaoException ("CPF somente números");
            }
        }
        


    }
}