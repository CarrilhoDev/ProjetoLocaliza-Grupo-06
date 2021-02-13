using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Infra.Repositorios
{
    public class LocacaoRepositorio : EntityRepositorio<Aluguel>, ILocacaoRepositorio
    {
        public LocacaoRepositorio(EntityContext context) : base(context){}

        public List<Aluguel> BuscarResrvasPorCpfCliente(string cpf)
        {
            return this._context.Alugueis.Where(x => x.Cliente.Registro.Documento == cpf).ToList();
        }
    }
}