using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;
using ProjetoRedeHoteis.lib.Models;

namespace ProjetoRedeHoteis.lib.Data.Repositorios
{
    public class RepositorioBase<T> :IRepositorioBase<T> where T : ModelBase
    {
        private readonly RedeHoteisContext _context;
        private readonly DbSet<T> _dbset;
        public RepositorioBase(RedeHoteisContext dbContext, DbSet<T> dbset)
        {
            _context = dbContext;
            _dbset = dbset;
        }
    }
}