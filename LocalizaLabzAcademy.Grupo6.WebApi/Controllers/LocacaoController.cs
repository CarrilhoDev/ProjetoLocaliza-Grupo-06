using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Controllers
{
    [ApiController]
    [Route("api/Locacao")]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacaoServicos locacaoService;
        public LocacaoController(ILocacaoServicos locacaoService)
        {
            this.locacaoService = locacaoService;
        }

        [HttpGet, Route("reservasCliente/{cpf}")]
        public IEnumerable<Aluguel> BuscarReservasPorCliente(string cpf)
        {
            return locacaoService.BuscarResrvasPorCpfCliente(cpf);
        }

        [HttpPost]
        public async Task<Aluguel> CriarReserva(Aluguel aluguel)
        {
            return await locacaoService.CriarReserva(aluguel);
        }

    }
}
