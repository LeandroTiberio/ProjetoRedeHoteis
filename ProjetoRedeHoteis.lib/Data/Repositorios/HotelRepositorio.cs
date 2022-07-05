using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class HotelRepositorio : RepositorioBase<Hotel>, IHotelRepositorio
    {
        private readonly RedeHoteisContext _context;

        public HotelRepositorio(RedeHoteisContext context) : base(context, context.Hoteis)
        {
            _context = context;
        }
        public async Task AtualizarAsync(int IdHotel, string endereco )
        {
            var item = await _context.Hoteis.AsNoTracking().FirstAsync(x => x.Id == IdHotel);
            await _context.SaveChangesAsync();
            
        }
        
    }
}