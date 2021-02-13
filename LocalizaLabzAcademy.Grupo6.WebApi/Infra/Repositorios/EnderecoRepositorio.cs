using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Infra.Repositorios
{
    public class EnderecoRepositorio : EntityRepositorio<EnderecoUsuario>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(EntityContext context) : base(context)
        {
        }
    }
}