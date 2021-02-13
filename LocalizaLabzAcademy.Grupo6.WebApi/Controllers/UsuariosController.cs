using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
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

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _rep.GetAll();
            return Ok(usuarios);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _rep.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            var user = await _rep.GetById(usuario.Id);
            if(user == null)
            {
                return Ok( await _rep.Create(usuario));
            }
            return Ok("Usuario já existe!");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _rep.Delete(id);
        }

        public async Task<IActionResult> Login(string email, string senha)
        {
            return Ok(await _servicos.Login(email, senha));
        }



    }
}