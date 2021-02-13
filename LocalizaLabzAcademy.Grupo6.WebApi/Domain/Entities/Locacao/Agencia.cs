
using System.Collections.Generic;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class Agencia : Entity
    {
        public string Nome { get; set; }
        public string Codigo {get;set;}
        public List<VeiculoAgencia> Veiculos {get; set;}

    }
}