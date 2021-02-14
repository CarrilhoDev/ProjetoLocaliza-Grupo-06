using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;
using LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Infra.Repositorios
{
    public class EnderecoUsuarioRepositorio : EntityRepositorio<EnderecoUsuario>, IEnderecoUsuarioRepositorio
    {
        public EnderecoUsuarioRepositorio(EntityContext context) : base(context)
        {
        }
    }
}