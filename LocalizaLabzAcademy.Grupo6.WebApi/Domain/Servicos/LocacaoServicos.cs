using System.Collections.Generic;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Servicos
{
    public class LocacaoServicos : ILocacaoServicos
    {
        private readonly ILocacaoRepositorio locacaoRepositorio;
        public LocacaoServicos(ILocacaoRepositorio locacaoRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
        }
        public List<Aluguel> BuscarResrvasPorCpfCliente(string cpf){
            return locacaoRepositorio.BuscarResrvasPorCpfCliente(cpf);
        }

        public async Task<Aluguel> CriarReserva(Aluguel reserva)
        {
            return await locacaoRepositorio.CreateAndReturn(reserva);
        }
    }
}