namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class Aluguer
    {
        public int IdContrato { get; set; }
        public Veiculo Veiculo { get; set; }
        public int TotalHorasLocacao { get; set; }
        public int ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
        public DataTime DataRetirada { get; set; }
        public Agencia LocalRetirada { get; set; }
        public CheckList ChecListRetirada { get; set; }
        public DataTime DataDevolucao { get; set; }
        public Agencia LocalDevolucao { get; set; }
        public CheckList ChecListDevolucao { get; set; }
    }
}