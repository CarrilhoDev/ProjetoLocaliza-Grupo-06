using System;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Enums;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class RegistroUsuario : Entity
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento {get; set;}
        public UserType Tipo { get; set; }
        public int EnderecoId {get; set;}
        public EnderecoUsuario Endereco { get; set; }
    }
}