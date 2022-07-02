using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Data.Repositorios;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoDeQuartoController : ControllerBase
    {
        private readonly TipoDeQuartoRepositorio _repositorio; 
        
        public TipoDeQuartoController(TipoDeQuartoRepositorio _repositorio)
        {
            _repositorio = _repositorio;
        }
    

        [HttpGet()]
        public async Task<IActionResult> BuscarTodos()
        {
           return Ok(await _repositorio.BuscarTodosAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoDeQuartoId(int id)
        {
            return Ok(await _repositorio.BuscarPorIdAsync(id));
        }
        [HttpPost()]
        public async Task<IActionResult> Adicionar(TipoDeQuarto tipoDeQuarto)
        {
            return Ok(await _repositorio.AdicionarAsync(tipoDeQuarto));
        }

        [HttpPut()]
        public async Task<IActionResult> Atualizar(TipoDeQuarto idtipoDeQuarto)
        {
            return Ok(await _repositorio.AtualizarAsync(idtipoDeQuarto));
        }
       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            _repositorio.DeletarAsync(id);
            return Ok();
        } 

    }
}