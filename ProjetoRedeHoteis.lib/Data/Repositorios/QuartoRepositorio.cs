using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class QuartoRepositorio : RepositorioBase<Quarto>, IQuartoRepositorio
    {
        private readonly RedeHoteisContext _context;

        public QuartoRepositorio(RedeHoteisContext context) : base(context, context.Quartos)
        {
            _context = context;
        }
    }
}