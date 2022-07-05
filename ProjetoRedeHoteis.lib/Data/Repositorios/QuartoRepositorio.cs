using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class QuartoRepositorio : RepositorioBase<Quarto>, IQuartoRepositorio
    {
        private readonly RedeHoteisContext _context;

        public QuartoRepositorio(RedeHoteisContext context) : base(context, context.Quartos)
        {
            _context = context;
        }
        public async Task AtualizarAsync(int IdQuarto, string TipoDeQuarto )
        {
            var item = await _context.Quartos.AsNoTracking().FirstAsync(x => x.Id == IdQuarto);
            await _context.SaveChangesAsync();
            
        }
    }
}