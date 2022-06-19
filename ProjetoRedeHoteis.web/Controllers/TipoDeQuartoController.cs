using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoDeQuartoController : ControllerBase
    {
        public static List<TipoDeQuartoDTO> TiposDeQuarto { get; set; } = new List<TipoDeQuartoDTO>();
        public ILogger<TipoDeQuartoController> Log { get; set; }
        public TipoDeQuartoController(ILogger<TipoDeQuartoController> log)
        {
            Log = log;
        }
        [HttpPost("SetTipoDeQuarto")]

        public IActionResult SetTipoDeQuarto(TipoDeQuartoDTO tipoDeQuartoDTO)
        {
            try
            {
                Log.LogInformation("SetTipoDeQuarto");
                Log.LogWarning("SetTipoDeQuarto");
                var tipoDeQuarto = new TipoDeQuarto(tipoDeQuartoDTO.Nome, tipoDeQuartoDTO.Descricao,
                                        tipoDeQuartoDTO.OcupacaoMaxima, tipoDeQuartoDTO.NumeroDeCamas);
                TiposDeQuarto.Add(tipoDeQuartoDTO);
                return Ok(TiposDeQuarto);
            }
            catch (System.Exception ex)
            {
                Log.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("GetTipoDeQuarto")]
        public IActionResult GetTipoDeQuarto()
        {
            return Ok(TiposDeQuarto);
        }

        [HttpDelete]
        public IActionResult DeleteTipoDeQuarto(TipoDeQuarto tipoDeQuarto)
        {
            var index = TiposDeQuarto.Count<TipoDeQuartoDTO>();
            TiposDeQuarto.RemoveAt(index -1);
            return Ok(TiposDeQuarto);
        }
    }
}