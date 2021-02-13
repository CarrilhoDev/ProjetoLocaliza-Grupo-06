using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class Agencia : IEntity
    {
    public int Id { get; set; }
    public string Nome { get; set; }
        
    }
}