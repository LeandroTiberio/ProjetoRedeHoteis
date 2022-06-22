using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class HospedeRepositorio : RepositorioBase<Hospede>, IHospedeRepositorio
    {
        private readonly RedeHoteisContext _context;

        public HospedeRepositorio(RedeHoteisContext context) : base(context, context.Hospedes)
        {
            _context = context;
        }
    }
}