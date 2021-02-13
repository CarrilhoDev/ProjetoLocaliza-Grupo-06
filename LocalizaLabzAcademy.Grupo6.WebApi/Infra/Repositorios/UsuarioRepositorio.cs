using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Infra.Repositorios
{
    public class UsuarioRepositorio : EntityRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(EntityContext context) : base(context){}
    }
}