using System.ComponentModel;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroUsuarioController : ControllerBase
    {
        private readonly IRegistroUsuarioRepositorio _rep;

        public RegistroUsuarioController(IRegistroUsuarioRepositorio rep)
        {
            _rep = rep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            
            return Ok(await _rep.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _rep.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegistroUsuario registroUsuario)
        {
            var retorno = await _rep.Create(registroUsuario);
            return Ok(retorno);
        }

        [HttpPut]
        public async Task<IActionResult> Update(RegistroUsuario registroUsuario)
        {
            return Ok(await _rep.Update(registroUsuario));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            return Ok(await _rep.Delete(id));
        }
    }
}