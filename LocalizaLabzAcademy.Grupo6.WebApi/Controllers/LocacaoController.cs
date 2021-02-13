using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Controllers
{
    [ApiController]
    [Route("api/Locacao")]
    public class LocacaoController : ControllerBase
    {
        public LocacaoController()
        {
        }

        [HttpGet]
        public IEnumerable<Aluguel> BuscarReservasPorCliente(string cpf)
        {
        }

        [HttpPost]
        public IEnumerable<Aluguel> CriarReserva()
        {
        }

    }
}
