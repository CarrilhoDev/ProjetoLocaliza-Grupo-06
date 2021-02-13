
using System.Collections.Generic;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class VeiculoAgencia : Entity
    {
        public Agencia Agencia { get; set; }
        public Veiculo Veiculo {get;set;}

    }
}