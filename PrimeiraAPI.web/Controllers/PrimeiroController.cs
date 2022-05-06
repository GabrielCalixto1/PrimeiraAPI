using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.web.Controllers
{
    [ApiController]
    [Route("MinhaController")]
    public class PrimeiroController : ControllerBase
    {
        [HttpGet]
        public string PrimeiraAPI()
        {
            return "teste";
        }
        [HttpGet("segundaApi")]
        public string SegundaAPI()
        {
            return "TesteDois";
        }
        [HttpGet("OutraAPI")]
        public IActionResult OutraAPI(int entrada)
        {
            if(entrada == 1)
            {
                return BadRequest("1- Não é uma entrada válida");
            }
            return Ok(entrada);
        }
    }
}