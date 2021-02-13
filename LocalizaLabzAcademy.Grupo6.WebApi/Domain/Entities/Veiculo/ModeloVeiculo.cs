using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle
{
    public class ModeloVeiculo : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
    }
}