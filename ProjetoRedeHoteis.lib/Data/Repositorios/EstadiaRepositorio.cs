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
    }
}