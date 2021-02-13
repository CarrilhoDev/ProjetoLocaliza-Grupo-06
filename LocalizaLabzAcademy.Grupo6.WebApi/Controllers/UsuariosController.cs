using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepositorio _rep;
        private readonly IUsuarioServicos _servicos;

        public UsuariosController(IUsuarioRepositorio rep, IUsuarioServicos servicos)
        {
            _rep = rep;
            _servicos = servicos;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _rep.GetAll();
            return Ok(usuarios);
        }
    }
}