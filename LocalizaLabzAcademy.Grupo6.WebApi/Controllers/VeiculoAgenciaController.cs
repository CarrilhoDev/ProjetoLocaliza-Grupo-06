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
    public class VeiculoAgenciaController : ControllerBase
    {
        private readonly IVeiculoAgenciaRepositorio _rep;

        public VeiculoAgenciaController(IVeiculoAgenciaRepositorio rep)
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
        public async Task<IActionResult> Create(VeiculoAgencia agencia)
        {
            var retorno = await _rep.Create(agencia);
            return Ok(retorno);
        }

        [HttpPut]
        public async Task<IActionResult> Update(VeiculoAgencia agencia)
        {
            return Ok(await _rep.Update(agencia));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            return Ok(await _rep.Delete(id));
        }
    }
}