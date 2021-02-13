using System.Collections.Generic;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces
{
    public interface ILocacaoRepositorio : IEntityRepositorio<Aluguel>
    {
        List<Aluguel> BuscarResrvasPorCpfCliente(string cpf);
    }
}