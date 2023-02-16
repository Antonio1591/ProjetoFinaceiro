using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Domain.UsuarioIdentityRepositorio;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Model;
using ProjetoFinaceiro.Modelo;
using ProjetoFinaceiro.Modelo.Domain;
using ProjetoFinaceiro.Services;

namespace apiProjetoFinaceiro.services
{
    public interface IUsuarioServices
    {
     
        Task<bool> CadastrarUsuarioIdentity(UsuarioCadastroRequest input);
        Task<bool> LogarUsuarioIdentity(Login login);
    }
}
