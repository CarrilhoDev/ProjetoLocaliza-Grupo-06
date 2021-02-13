using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Enums;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class RegistroUsuario : IEntity
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public UserType Tipo { get; set; }
        public EnderecoUsuario Endereco { get; set; }
    }
}