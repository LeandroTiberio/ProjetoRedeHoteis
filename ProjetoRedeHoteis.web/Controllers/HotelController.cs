using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ProjetoRedeHoteis.lib.Data.Repositorios;
using ProjetoRedeHoteis.lib.Models;
using ProjetoRedeHoteis.web.Properties.DTOs;
using ProjetoRedeHoteis.web.Properties.DTOs.RespostaHttp;
using ProjetoRedeHoteis.lib.Exception;

namespace ProjetoRedeHoteis.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly HotelRepositorio _repositorio; 
        
        public HotelController(HotelRepositorio _repositorio)
        {
            _repositorio = _repositorio;
        }
        
        [HttpGet("Cep")]
        public async Task<IActionResult> BuscarEnderecoPorCep(double cep)
        {  
            var endereco = await BuscarEnderecoViaCep(cep);
            return Ok(endereco);
        }
        private async Task<ViaCepRespostaHttp> BuscarEnderecoViaCep(double cep)
        {
            var client = new HttpClient();
            var retorno = await client.GetAsync("https://viacep.com.br/ws/"+cep+"/json/");
            var endereco = await retorno.Content.ReadAsStringAsync();
            var resposta = JsonSerializer.Deserialize<ViaCepRespostaHttp>(endereco);
            return resposta;
        }
    

        [HttpGet()]
        public async Task<IActionResult> BuscarTodos()
        {
           return Ok(await _repositorio.BuscarTodosAsync());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotelId(int id)
        {
            return Ok(await _repositorio.BuscarPorIdAsync(id));
        }
        
        [HttpPost()]
        public async Task<IActionResult> Adicionar(HotelDTO hotelDto)
        {
            try
            {
                var endereco = await BuscarEnderecoViaCep(hotelDto.Cep);
                var hotel = new Hotel(hotelDto.Nome, hotelDto.Endereco, hotelDto.Cep,
                hotelDto.Descricao, hotelDto.Telefone, hotelDto.Email, hotelDto.CheckIn,
                hotelDto.CheckOut);
                await _repositorio.AdicionarAsync(hotel);
                return Ok();
            }
            catch (ErroDeValidacaoException ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut()]
        public async Task<IActionResult> Atualizar(int IdHotel, string endereco)
        {
            return Ok(await _repositorio.AtualizarAsync(IdHotel, endereco));
        }
       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            _repositorio.DeletarAsync(id);
            return Ok();
        }
    }
}