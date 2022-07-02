using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Data.Repositorios;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        private readonly ServicoRepositorio _repositorio; 
        
        public ServicoController(ServicoRepositorio _repositorio)
        {
            _repositorio = _repositorio;
        }
    

        [HttpGet()]
        public async Task<IActionResult> BuscarTodos()
        {
           return Ok(await _repositorio.BuscarTodosAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServicoId(int id)
        {
            return Ok(await _repositorio.BuscarPorIdAsync(id));
        }
        [HttpPost()]
        public async Task<IActionResult> Adicionar(Servico servico)
        {
            return Ok(await _repositorio.AdicionarAsync(servico));
        }

        [HttpPut()]
        public async Task<IActionResult> Atualizar(Servico idservico)
        {
            return Ok(await _repositorio.AtualizarAsync(idservico));
        }
       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            _repositorio.DeletarAsync(id);
            return Ok();
        }

    }
}