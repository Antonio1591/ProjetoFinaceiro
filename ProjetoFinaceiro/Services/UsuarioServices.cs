using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.Mapping;
using apiProjetoFinaceiro.Model.View;
using Microsoft.VisualBasic.Logging;
using ProjetoFinaceiro.Model;
using ProjetoFinaceiro.Modelo;
using ProjetoFinaceiro.Modelo.Domain;
using ProjetoFinaceiro.Services;

namespace apiProjetoFinaceiro.services
{
    public class UsuarioServices : IUsuarioServices
    { 

        ApiClient _apiClient = new ApiClient(new HttpClient());
        public async Task<UsuarioViewModel> CadastrarUsuario(UsuarioImputModel input)
        {
            var novoUsuario = new Usuario(input.Nome, input.Senha, input.Email, input.Telefone, input.Cidade, input.Bairro, input.CPF, input.DataNascimento, input.Situacao);
            if (!novoUsuario.EhValido)
            {
                foreach (var erros in novoUsuario.Erros)
                {
                    MessageBox.Show(erros);
                };
                return default;
            }
            var resultado = await _apiClient.Create<UsuarioViewModel, UsuarioImputModel>("Usuario/CadastrarUsuario", input);
            if (resultado.Erro)
            {
                foreach (var menssagemErro in resultado.MensagemErro)
                {
                    MessageBox.Show(menssagemErro);
                }
                return null;
            };
            return resultado.Dados;   
        }

        public async Task Delete(int id)
        {
            
        }

        public async Task <IEnumerable<UsuarioViewModel>> ListaUsuarios()
        {
            return await _apiClient.getAsync<IEnumerable<UsuarioViewModel>>("Usuario");
        }

        public async Task <UsuarioViewModel>Logim(Login login)
        {
           
           var resultado= await _apiClient.Login<UsuarioViewModel,Login>("AutentificacaoUsuario/Login", login);
            if (resultado.Erro)
            {
                foreach (var menssagemErro in resultado.MensagemErro)
                {
                    MessageBox.Show(menssagemErro);
                }
                return null;
            };
            MessageBox.Show($"Usuario {resultado.Dados.Nome} Logado! Onde o usuario e da cidade " + resultado.Dados.Cidade);
            return  resultado.Dados;

        }


        public async Task<IEnumerable<CidadeViewModel>> BuscarCidades()
        {

             return await _apiClient.getAsync<IEnumerable<CidadeViewModel>>("Usuario/buscarCidade");
        
        }

        public async Task<IEnumerable<BairroViewModel>> BuscarBairros()
        {

            return await _apiClient.getAsync<IEnumerable<BairroViewModel>>("Usuario/buscarBairro");

        }
        public async Task<UsuarioViewModel> AlterarSenha(UsuarioImputModel input)
        {
            var novoUsuario = new Usuario(input.Nome, input.Senha, input.Email, input.Telefone, input.Cidade, input.Bairro, input.CPF, input.DataNascimento, input.Situacao);
            if (!novoUsuario.EhValido)
            {
                foreach (var erros in novoUsuario.Erros)
                {
                    MessageBox.Show(erros);
                };
                return default;
            }
            var resultado = await _apiClient.Update<UsuarioViewModel, UsuarioImputModel>("AutentificacaoUsuario/AlterarSenha", input);
            if (resultado.Erro)
            {
                foreach (var menssagemErro in resultado.MensagemErro)
                {
                    MessageBox.Show(menssagemErro);
                }
                return null;
            };
            MessageBox.Show("Senha Alterada");
            return resultado.Dados;
        }
    }
}


