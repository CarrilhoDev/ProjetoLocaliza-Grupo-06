using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Locacao;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.User;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Entities.Vehicle;
using Microsoft.EntityFrameworkCore;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Infra.Database
{
    public class EntityContext : DbContext
    {
        public EntityContext (DbContextOptions<EntityContext> options)
            : base(options)
        {
        }

        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<CheckList> CheckLists { get; set; }
        public DbSet<EnderecoUsuario> EnderecosUsuarios { get; set; }
        public DbSet<RegistroUsuario> RegistrosUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<MarcaVeiculo> MarcasVeiculos { get; set; }
        public DbSet<ModeloVeiculo> ModelosVeiculos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}