using System;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle;


namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class Aluguel : Entity
    {
        public int VeiculoId {get;set;}
        public Veiculo Veiculo { get; set; }
        public Double TotalHorasLocacao { get; set; }
        public Double ValorTotal { get; set; }
        public int OperadorId {get;set;}
        public Usuario Operador { get; set; }
        public int ClienteId {get;set;}
        public Usuario Cliente { get; set; }
        public DateTime DataRetirada { get; set; }
        public int LocalRetiradaId {get; set;}
        public Agencia LocalRetirada { get; set; }
        public int CheckListRetiradaId {get; set;}
        public CheckList CheckListRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int LocalDevolucaoId {get; set;}
        public Agencia LocalDevolucao { get; set; }
        public int CheckListDevolucaoId {get; set;}
        public CheckList CheckListDevolucao { get; set; }
    }
}