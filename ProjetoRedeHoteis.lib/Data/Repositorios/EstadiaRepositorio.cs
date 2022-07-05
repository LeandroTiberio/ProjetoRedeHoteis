using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class EstadiaRepositorio : RepositorioBase<Estadia>, IEstadiaRepositorio
    {
        private readonly RedeHoteisContext _context;

        public EstadiaRepositorio(RedeHoteisContext context) : base(context, context.Estadias)
        {
            _context = context;
        }
        public async Task AtualizarAsync(int IdEstadia, string hospede )
        {
            var item = await _context.Estadias.AsNoTracking().FirstAsync(x => x.Id == IdEstadia);
            await _context.SaveChangesAsync();
            
        }
    }
}