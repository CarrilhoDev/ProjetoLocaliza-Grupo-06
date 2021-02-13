using System;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle;


namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class Aluguel : Entity
    {
        public Veiculo Veiculo { get; set; }
        public Double TotalHorasLocacao { get; set; }
        public Double ValorTotal { get; set; }
        public Usuario Operador { get; set; }
        public Usuario Cliente { get; set; }
        public DateTime DataRetirada { get; set; }
        public Agencia LocalRetirada { get; set; }
        public CheckList CheckListRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Agencia LocalDevolucao { get; set; }
        public CheckList CheckListDevolucao { get; set; }
    }
}