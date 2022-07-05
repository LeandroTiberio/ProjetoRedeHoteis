using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class TipoDeQuartoRepositorio : RepositorioBase<TipoDeQuarto>, ITipoDeQuartoRepositorio
    {
        private readonly RedeHoteisContext _context;

        public TipoDeQuartoRepositorio(RedeHoteisContext context) : base(context, context.TiposDeQuartos)
        {
            _context = context;
        }
        public async Task AtualizarAsync(int IdTipoDeQuarto, string descricao )
        {
            var item = await _context.TiposDeQuartos.AsNoTracking().FirstAsync(x => x.Id == IdTipoDeQuarto);
            await _context.SaveChangesAsync();
            
        }
    }
}