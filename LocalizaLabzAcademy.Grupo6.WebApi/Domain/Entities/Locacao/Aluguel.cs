using System;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class Aluguel : IEntity
    {
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public int TotalHorasLocacao { get; set; }
        public int ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataRetirada { get; set; }
        public Agencia LocalRetirada { get; set; }
        public CheckList ChecListRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Agencia LocalDevolucao { get; set; }
        public CheckList ChecListDevolucao { get; set; }
    }
}