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
    }
}