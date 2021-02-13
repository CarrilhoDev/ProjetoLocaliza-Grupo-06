using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle
{
    public class MarcaVeiculo : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}