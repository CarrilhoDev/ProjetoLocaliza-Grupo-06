using System.Threading.Tasks;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces
{
    public interface IUsuarioServicos
    {
        Task<string> Login(string usuario, string senha);
    }
}