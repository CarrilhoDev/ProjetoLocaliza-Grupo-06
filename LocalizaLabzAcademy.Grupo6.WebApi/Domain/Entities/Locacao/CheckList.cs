
namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class CheckList : Entity
    {
        public bool CarroLimpo { get; set; } 
        
        public bool TanqueCheio { get; set; }
        
        public bool Amassado { get; set; }
        
        public bool Arranhoes { get; set; }
        public Aluguel Locacao {get; set;}
        public int LocacaoId {get; set;}
    }
}