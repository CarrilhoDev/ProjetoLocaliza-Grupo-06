using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Enums;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle
{
    public class Vehicle 
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public Double PricePerHour { get; set; }
        public int FuelTankCapacity { get; set; }
        public int TrunkCapacity { get; set; }
        public VehicleBrand Brand {get; set;}
        public VehicleModel Model {get;set;}
        public VehicleFuel Fuel {get; set;}
    }
}