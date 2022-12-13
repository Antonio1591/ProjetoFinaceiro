using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.Mapping;
using apiProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Modelo.Domain;
using ProjetoFinaceiro.Services;

namespace apiProjetoFinaceiro.services
{
    public class UsuarioServices : IUsuarioServices
    {

        ApiClient _apiClient = new ApiClient(new HttpClient());
        public async Task<UsuarioViewModel> CadastrarUsuario(UsuarioImputModel input)
        {
            await _apiClient.Create<UsuarioViewModel,UsuarioImputModel>("Usuario/Resultado", input);
            var pessoa = new Usuario(input.Nome, input.Senha, input.Email, input.Telefone, input.Cidade, input.Bairro, input.CPF, input.DataNascimento, input.Situacao) ;
            List<Usuario> Pessoa = new List<Usuario>();
            Pessoa.Add(pessoa);
            MessageBox.Show(pessoa.Cidade.Nome);
            return pessoa.ParaViewModel();
        }

        public async Task Delete(int id)
        {
            
        }

        public async Task <IEnumerable<UsuarioViewModel>> ListaUsuarios()
        {
            return await _apiClient.getAsync<IEnumerable<UsuarioViewModel>>("Usuario");
        }

        public async Task<UsuarioViewModel>Logim(Login login)
        {
           
           var resultado= await _apiClient.Create<UsuarioViewModel,Login>("Usuario/Login", login);
            if (resultado == null)
            {
                MessageBox.Show("Usuario não encontrado na base de daods");
                return null;
            };
            MessageBox.Show($"Usuario {resultado.Nome} Logado! Onde o usuario e da cidade "+resultado.Cidade);
            return resultado;
        }


        public async Task<IEnumerable<CidadeViewModel>> BuscarCidades()
        {

             return await _apiClient.getAsync<IEnumerable<CidadeViewModel>>("Usuario/buscarCidade");
        
        }

        public async Task<IEnumerable<BairroViewModel>> BuscarBairros()
        {

            return await _apiClient.getAsync<IEnumerable<BairroViewModel>>("Usuario/buscarBairro");

        }

    }
}


