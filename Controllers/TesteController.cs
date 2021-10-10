using Microsoft.AspNetCore.Mvc;

namespace testeApi.Controllers
{
    public class TesteController : Controller {
        [HttpGet("teste")]
        public IActionResult Teste() {
            return Ok("Nossa API está funcionando");
        }
    }
}