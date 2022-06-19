using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.web.Properties.DTOs;
using ProjetoRedeHoteis.lib.Models;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospedeController : ControllerBase
    {
        public static List<HospedeDTO> Hospedes { get; set; } = new List<HospedeDTO>();
        public ILogger<HospedeController> Log { get; set; }
        public HospedeController(ILogger<HospedeController> log)
        {
            Log = log;
        }
        [HttpPost("SetHospede")]

        public IActionResult SetHospede(HospedeDTO hospedeDTO)
        {
            try
            {
                Log.LogInformation("SetHospede");
                Log.LogWarning("SetHospede");
                var hospede = new Hospede(hospedeDTO.Nome, hospedeDTO.Cpf, hospedeDTO.Email, hospedeDTO.Telefone,
                                            hospedeDTO.DataNascimento);
                Hospedes.Add(hospedeDTO);
                return Ok(Hospedes);
            }
            catch (System.Exception ex)
            {
                Log.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("GetHospede")]
        public IActionResult GetHospede()
        {
            return Ok(Hospedes);
        }

        [HttpDelete]
        public IActionResult DeleteHospede(Hospede hospede)
        {
            var index = Hospedes.Count<HospedeDTO>();
            Hospedes.RemoveAt(index -1);
            return Ok(hospede);
        }
    }
}