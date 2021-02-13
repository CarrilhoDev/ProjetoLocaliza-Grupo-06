using System.Threading.Tasks;
using LocalizaLabzAcademy.Grupo6.WebApi.Domain.Interfaces;

namespace LocalizaLabzAcademy.Grupo6.WebApi.Domain.Servicos
{
    public class UsuarioServicos : IUsuarioServicos
    {
        public Task<string> Login(string usuario, string senha)
        {
            throw new System.NotImplementedException();  // fazer login
        }
    }
}