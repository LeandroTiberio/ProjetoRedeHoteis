using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Data.Repositorios;
using ProjetoRedeHoteis.lib.Data.Repositorios.Interface;
using ProjetoRedeHoteis.lib.Exception;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoDeQuartoController : ControllerBase
    {
        private readonly ITipoDeQuartoRepositorio _repositorio; 
        
        public TipoDeQuartoController(ITipoDeQuartoRepositorio _repositorio)
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
        public async Task<IActionResult> Adicionar(TipoDeQuartoDTO tipoDeQuartoDTO)
        {
            try 
            {
                var tipoDeQuarto = new TipoDeQuarto(tipoDeQuartoDTO.Nome, tipoDeQuartoDTO.Descricao, tipoDeQuartoDTO.OcupacaoMaxima,
                                                        tipoDeQuartoDTO.NumeroDeCamas);
                await _repositorio.AdicionarAsync(tipoDeQuarto);
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