using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        public static List<ServicoDTO> Servicos { get; set; } = new List<ServicoDTO>();
        public ILogger<ServicoController> Log { get; set; }
        public ServicoController(ILogger<ServicoController> log)
        {
            Log = log;
        }
        [HttpPost("SetServico")]

        public IActionResult SetServivo(ServicoDTO servicoDTO)
        {
            try
            {
                Log.LogInformation("SetServico");
                Log.LogWarning("SetServico");
                var servico = new Servico(servicoDTO.Nome);
                Servicos.Add(servicoDTO);
                return Ok(Servicos);
            }
            catch (System.Exception ex)
            {
                Log.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("GetServico")]
        public IActionResult GetServico()
        {
            return Ok(Servicos);
        }

        [HttpDelete]
        public IActionResult DeleteServico(Servico servico)
        {
            var index = Servicos.Count<ServicoDTO>();
            Servicos.RemoveAt(index -1);
            return Ok(servico);
        }
    }
}