using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Enums;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle
{
    public class Veiculo 
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public Double ValorHora { get; set; }
        public int CapacidadeTanqueCombustivel { get; set; }
        public int CapacidadePortaMalas { get; set; }
        public MarcaVeiculo Marca {get; set;}
        public ModeloVeiculo Modelo {get;set;}
        public int Ano { get; set; }
        public CategoriaVeiculo Categoria { get; set; }
        public VehicleFuel Combustivel {get; set;}
    }
}