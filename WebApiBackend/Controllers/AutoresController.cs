using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApiBackend.Services;

namespace WebApiBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorServices _autoservices;
        public AutoresController(IAutorServices autoservices)
        {
            _autoservices = autoservices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAutores()
        {
            return Ok(await _autoservices.GetAutores());
        }
        [HttpPost]
        public async Task<IActionResult> CreateAutor([FromBody] Autor autor)
        {
            return Ok(await _autoservices.Create(autor));
        }


    }
}
