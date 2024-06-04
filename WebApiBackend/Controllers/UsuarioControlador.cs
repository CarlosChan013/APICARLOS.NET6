using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApiBackend.Services.Iservices;
using WebApiBackend.Services.services;

namespace WebApiBackend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioControlador : ControllerBase
    {
        private readonly IUsuarioServices _usuarioService;
        
        public UsuarioControlador(IUsuarioServices usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
            {
            var response = await _usuarioService.ObtenerUsuarios();
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUsuers(int id)
        {
            return Ok (await _usuarioService.ById(id));
        }
            

        
        [HttpPost]
        public async Task<IActionResult> PostUSer([FromBody]UsuarioReponse request)
        {
            return Ok(await _usuarioService.Crear(request));
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutUser(int id, [FromBody] UsuarioReponse request)
        {
            var response = await _usuarioService.Editar(id, request);
            if (!response.Succeded)
            {
                return NotFound(response);
            }
            return Ok(response);
        }



        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response = await _usuarioService.Eliminar(id);
            if (!response.Succeded)
            {
                return NotFound(response);
            }
            return Ok(response);
        }




    }
}
