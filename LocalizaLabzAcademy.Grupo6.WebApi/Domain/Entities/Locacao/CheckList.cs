using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao
{
    public class CheckList : IEntity
    {
        public int Id { get; set; }

        public bool CarroLimpo { get; set; } 
        
        public bool TanqueCheio { get; set; }
        
        public bool Amassado { get; set; }
        
        public bool Arranhoes { get; set; }
    }
}