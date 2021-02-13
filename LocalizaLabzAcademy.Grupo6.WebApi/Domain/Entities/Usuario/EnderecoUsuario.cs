namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User
{
    public class EnderecoUsuario : Entity
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}