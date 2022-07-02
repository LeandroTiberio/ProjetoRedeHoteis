using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Data.Repositorios;
using ProjetoRedeHoteis.lib.Exception;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuartoController : ControllerBase
    {
        private readonly QuartoRepositorio _repositorio; 
        
        public QuartoController(QuartoRepositorio _repositorio)
        {
            _repositorio = _repositorio;
        }
    

        [HttpGet()]
        public async Task<IActionResult> BuscarTodos()
        {
           return Ok(await _repositorio.BuscarTodosAsync());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuartoId(int id)
        {
            return Ok(await _repositorio.BuscarPorIdAsync(id));
        }
        
        [HttpPost()]
        public async Task<IActionResult> Adicionar(QuartoDTO quartoDTO)
        {
            try
            {
                var quarto = new Quarto(quartoDTO.Numero, quartoDTO.Andar);
                await _repositorio.AdicionarAsync(quarto);
                return Ok();
            }
            catch (ErroDeValidacaoException ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            _repositorio.DeletarAsync(id);
            return Ok();
        }

    }
}