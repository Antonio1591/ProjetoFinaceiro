using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Modelo;
using ProjetoFinaceiro.Modelo.Domain;
using ProjetoFinaceiro.Services;

namespace apiProjetoFinaceiro.services
{
    public interface IUsuarioServices
    {
        Task<IEnumerable<UsuarioViewModel>> ListaUsuarios();

        Task <UsuarioViewModel>CadastrarUsuario(UsuarioImputModel input);

        Task<UsuarioViewModel> Logim(Login login);
        Task <IEnumerable<CidadeViewModel>> BuscarCidades();
        Task <IEnumerable<BairroViewModel>> BuscarBairros();
    }
}
