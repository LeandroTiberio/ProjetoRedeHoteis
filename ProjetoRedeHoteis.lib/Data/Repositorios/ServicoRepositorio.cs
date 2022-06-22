using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class ServicoRepositorio : RepositorioBase<Servico>, IServicoRepositorio
    {
        private readonly RedeHoteisContext _context;

        public ServicoRepositorio(RedeHoteisContext context) : base(context, context.Servicos)
        {
            _context = context;
        }
    }
}