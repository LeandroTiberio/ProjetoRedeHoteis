using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class HospedeRepositorio : RepositorioBase<Hospede>, IHospedeRepositorio
    {
        private readonly RedeHoteisContext _context;

        public HospedeRepositorio(RedeHoteisContext context) : base(context, context.Hospedes)
        {
            _context = context;
        }
        public async Task AtualizarAsync(int IdHospede, string IdResponsavel )
        {
            var item = await _context.Hospedes.AsNoTracking().FirstAsync(x => x.Id == IdHospede);
            await _context.SaveChangesAsync();
            
        }
    }
}