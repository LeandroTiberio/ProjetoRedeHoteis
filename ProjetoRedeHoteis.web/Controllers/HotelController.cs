using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;
using ProjetoRedeHoteis.web.Properties.DTOs.RespostaHttp;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        public static List<HotelDTO> Hoteis { get; set; } = new List<HotelDTO>();
        public ILogger<HotelController> Log { get; set; }
        public HotelController(ILogger<HotelController> log)
        {
            Log = log;
        }
        [HttpPost("SetHotel")]

        public IActionResult SetHotel(HotelDTO hotelDTO)
        {
            try
            {
                Log.LogInformation("SetHotel");
                Log.LogWarning("SetHotel");
                var hotel = new Hotel(hotelDTO.Nome, hotelDTO.Endereco, hotelDTO.Cep, hotelDTO.Descricao,
                                        hotelDTO.Telefone, hotelDTO.Email,hotelDTO.CheckIn, hotelDTO.CheckOut);
                Hoteis.Add(hotelDTO);
                return Ok(Hoteis);
            }
            catch (System.Exception ex)
            {
                Log.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("GetHotel")]
        public IActionResult GetHotel()
        {
            return Ok(Hoteis);
        }
        
        [HttpGet("CEP")]
        public async Task<string> BuscarEnderecoPorCEP(string cep)
        {
            var client = new HttpClient();
            var retorno = await client.GetAsync("https://viacep.com.br/ws/"+cep+"/json/");
            var endereco = await retorno.Content.ReadAsStringAsync();
            var resposta = JsonSerializer.Deserialize<ViaCepRespostaHttp>(cep);
            return endereco;
        }   
            
        [HttpDelete]
        public IActionResult DeleteHotel(Hotel hotel)
        {
            var index = Hoteis.Count<HotelDTO>();
            Hoteis.RemoveAt(index -1);
            return Ok(hotel);
        }
    }
}