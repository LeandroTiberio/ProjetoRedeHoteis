using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuartoController : ControllerBase
    {
        public static List<QuartoDTO> Quartos { get; set; } = new List<QuartoDTO>();
        public ILogger<QuartoController> Log { get; set; }
        public QuartoController(ILogger<QuartoController> log)
        {
            Log = log;
        }
        [HttpPost("SetQuarto")]

        public IActionResult SetQuarto(QuartoDTO quartoDTO)
        {
            try
            {
                Log.LogInformation("SetQuarto");
                Log.LogWarning("SetQuarto");
                var quarto = new Quarto(quartoDTO.Numero, quartoDTO.Andar);
                Quartos.Add(quartoDTO);
                return Ok(Quartos);
            }
            catch (System.Exception ex)
            {
                Log.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("GetQuarto")]
        public IActionResult GetQuarto()
        {
            return Ok(Quartos);
        }

        [HttpDelete]
        public IActionResult DeleteQuarto(Quarto quarto)
        {
            var index = Quartos.Count<QuartoDTO>();
            Quartos.RemoveAt(index -1);
            return Ok(quarto);
        }
    }
}