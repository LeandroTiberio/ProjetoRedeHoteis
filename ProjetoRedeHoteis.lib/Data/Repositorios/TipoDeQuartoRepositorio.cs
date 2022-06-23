using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class TipoDeQuartoRepositorio : RepositorioBase<TipoDeQuarto>, ITipoDeQuartoRepositorio
    {
        private readonly RedeHoteisContext _context;

        public TipoDeQuartoRepositorio(RedeHoteisContext context) : base(context, context.TiposDeQuartos)
        {
            _context = context;
        }
    }
}