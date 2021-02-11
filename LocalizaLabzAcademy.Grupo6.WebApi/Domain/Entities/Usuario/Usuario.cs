namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class Usuario 
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public RegistroUsuario Registro { get; set; }
    }
}