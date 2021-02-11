using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Enums;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class UserRegistration
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public UserType Type { get; set; }
        public UserAddress Adrress { get; set; }
    }
}