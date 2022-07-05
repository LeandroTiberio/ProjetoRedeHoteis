using ProjetoRedeHoteis.lib.Models;
namespace ProjetoRedeHoteis.lib.Data.Repositorios.Interface
{
    public interface IRepositorioBase<T> where T : ModelBase
    {
       Task AdicionarAsync(T item);

       Task<List<T>> BuscarTodosAsync();

       Task<T> BuscarPorIdAsync(int id);

       Task DeletarAsync(int id);
    }
}