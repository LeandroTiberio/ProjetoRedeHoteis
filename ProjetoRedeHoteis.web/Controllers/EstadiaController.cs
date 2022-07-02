using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.web.Properties.DTOs;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadiaController : ControllerBase
    {
        private readonly EstadiaRepositorio _repositorio; 
        
        public EstadiaController(EstadiaRepositorio _repositorio)
        {
            _repositorio = _repositorio;
        }
    

        [HttpGet()]
        public async Task<IActionResult> BuscarTodos()
        {
           return Ok(await _repositorio.BuscarTodosAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstadiaId(int id)
        {
            return Ok(await _repositorio.BuscarPorIdAsync(id));
        }
        [HttpPost()]
        public async Task<IActionResult> Adicionar(int IdEstadia,  string Hospede)
        {
            return Ok(await _repositorio.AdicionarAsync(IdEstadia, Hospede));
        }

        [HttpPut()]
        public async Task<IActionResult> Atualizar(Estadia idEstadia)
        {
            return Ok(await _repositorio.AtualizarAsync(idEstadia));
        }
       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            _repositorio.DeletarAsync(id);
            return Ok();
        }


    }
}