using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.web.Properties.DTOs;
using ProjetoRedeHoteis.lib.Models;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadiaController : ControllerBase
    {
        public static List<EstadiaDTO> Estadias { get; set; } = new List<EstadiaDTO>();
        public ILogger<EstadiaController> Log { get; set; }
        public EstadiaController(ILogger<EstadiaController> log)
        {
            Log = log;
        }
        [HttpPost("SetEstadia")]
        public IActionResult SetEstadia(EstadiaDTO estadiaDTO)
        {
            try
            {
                Log.LogInformation("SetEstadia");
                Log.LogWarning("SetEstadia");
                var estadia = new Estadia(estadiaDTO.DataEntrada, estadiaDTO.DataSaida, estadiaDTO.Responsavel)
                Estadias.Add(estadiaDTO);
                return Ok(Estadias);
            }
            catch (SystemException ex)
            {
                Log.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

            [HttpGet("GetEstadia")]

            public IActionResult GetEstadia()
            {
                return Ok(Estadias);
            }

            [HttpDelete]

            public IActionResult DeleteEstadia(Estadia estadia)
            {
                var index = Estadias.Count<EstadiaDTO>();
                Estadias.RemoveAt(index -1);
                return Ok(estadia);
            }

        }

    }
}