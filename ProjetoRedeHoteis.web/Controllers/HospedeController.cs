using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.web.Properties.DTOs;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.lib.Data.Repositorios;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospedeController : ControllerBase
    {
        private readonly HospedeRepositorio _repositorio; 
        
        public HospedeController(HospedeRepositorio _repositorio)
        {
            _repositorio = _repositorio;
        }
    

        [HttpGet()]
        public async Task<IActionResult> BuscarTodos()
        {
           return Ok(await _repositorio.BuscarTodosAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHospedeId(int id)
        {
            return Ok(await _repositorio.BuscarPorIdAsync(id));
        }
        [HttpPost()]
        public async Task<IActionResult> Adicionar(Hospede hospede)
        {
            return Ok(await _repositorio.AdicionarAsync(hospede));
        }

        [HttpPut()]
        public async Task<IActionResult> Atualizar(Hospede idHospede)
        {
            return Ok(await _repositorio.AtualizarAsync(idHospede));
        }
       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            _repositorio.DeletarAsync(id);
            return Ok();
        }

    }
}