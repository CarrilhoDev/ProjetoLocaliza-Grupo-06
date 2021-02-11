namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class UserAddress
    {
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}