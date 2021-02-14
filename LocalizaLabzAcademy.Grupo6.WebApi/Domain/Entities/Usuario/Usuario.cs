namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class Usuario : Entity
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public int RegistroId {get; set;}
        public RegistroUsuario Registro { get; set; }
    }
}