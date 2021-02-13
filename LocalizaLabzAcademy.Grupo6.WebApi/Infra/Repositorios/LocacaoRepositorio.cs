using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Infra.Repositorios
{
    public class LocacaoRepositorio : EntityRepositorio<Aluguel>, ILocacaoRepositorio
    {
        public LocacaoRepositorio(EntityContext context) : base(context){}
    }
}