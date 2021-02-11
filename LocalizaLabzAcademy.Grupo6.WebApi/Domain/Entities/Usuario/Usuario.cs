namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class User 
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRegistration Registration { get; set; }
    }
}