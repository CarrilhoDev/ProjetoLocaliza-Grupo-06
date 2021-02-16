
using System.Collections.Generic;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class VeiculoAgencia : Entity
    {
        public int AgenciaId {get;set;}
        public Agencia Agencia { get; set; }
        public int VeiculoId {get; set;}
        public Veiculo Veiculo {get;set;}

    }
}