using System.Collections.Generic;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces
{
    public interface ILocacaoServicos
    {
        List<Aluguel> BuscarResrvasPorCpfCliente(string cpf);
        Task<Aluguel> CriarReserva(Aluguel reserva);
    }
}