using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Domain.UsuarioIdentityRepositorio;
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

        private ApiClient _apiClient;

        public UsuarioServices(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        //public async Task<UsuarioViewModel> CadastrarUsuario(UsuarioImputModel input)
        //{
        //    var novoUsuario = new Usuario(input.Nome, input.Senha, input.Email, input.Telefone, input.Cidade, input.Bairro, input.CPF, input.DataNascimento, input.Situacao);
        //    if (!novoUsuario.EhValido)
        //    {
        //        foreach (var erros in novoUsuario.Erros)
        //        {
        //            MessageBox.Show(erros);
        //        };
        //        return default;
        //    }
        //    var resultado = await _apiClient.Create<UsuarioViewModel, UsuarioImputModel>("Usuario/CadastrarUsuario", input);
        //    if (resultado.Erro)
        //    {
        //        foreach (var menssagemErro in resultado.MensagemErro)
        //        {
        //            MessageBox.Show(menssagemErro);
        //        }
        //        return null;
        //    };
        //    MessageBox.Show("Usuario Cadastrado com sucesso","Cadastro Usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //    return resultado.Dados;   
        //}

        //public async Task Delete(int id)
        //{
            
        //}

        //public async Task <IEnumerable<UsuarioViewModel>> ListaUsuarios()
        //{
        //    return await _apiClient.getAsync<IEnumerable<UsuarioViewModel>>("Usuario");
        //}

        //public async Task <UsuarioViewModel>Logim(Login login)
        //{


           
        //   var resultado= await _apiClient.Login<UsuarioViewModel,Login>("AutentificacaoUsuario/Login", login);
        //    if (resultado.Erro)
        //    {
        //        foreach (var menssagemErro in resultado.MensagemErro)
        //        {
        //            MessageBox.Show(menssagemErro);
        //        }
        //        return null;
        //    };
        //    //MessageBox.Show($"Usuario {resultado.Dados.Nome} Logado! Onde o usuario e da cidade " + resultado.Dados.Cidade);
        //    return  resultado.Dados;

        //}


        //public async Task<IEnumerable<CidadeViewModel>> BuscarCidades()
        //{

        //     return await _apiClient.getAsync<IEnumerable<CidadeViewModel>>("Usuario/buscarCidade");
        
        //}

        //public async Task<IEnumerable<BairroViewModel>> BuscarBairros()
        //{

        //    return await _apiClient.getAsync<IEnumerable<BairroViewModel>>("Usuario/buscarBairro");

        //}
        //public async Task<UsuarioViewModel> AlterarSenha(UsuarioImputModel input)
        //{
        //    var novoUsuario = new Usuario(input.Nome, input.Senha, input.Email, input.Telefone, input.Cidade, input.Bairro, input.CPF, input.DataNascimento, input.Situacao);
        //    if (!novoUsuario.EhValido)
        //    {
        //        foreach (var erros in novoUsuario.Erros)
        //        {
        //            MessageBox.Show(erros);
        //        };
        //        return default;
        //    }
        //    var resultado = await _apiClient.Update<UsuarioViewModel, UsuarioImputModel>("AutentificacaoUsuario/AlterarSenha", input);
        //    if (resultado.Erro)
        //    {
        //        foreach (var menssagemErro in resultado.MensagemErro)
        //        {
        //            MessageBox.Show(menssagemErro);
        //        }
        //        return null;
        //    };
        //    MessageBox.Show("Senha Alterada");
        //    return resultado.Dados;
        //}

        public async Task<bool> CadastrarUsuarioIdentity(UsuarioCadastroRequest input)
        {
            input.Role = "VIP";

            var resultado = await _apiClient.Create<UsuarioCadastroResponse, UsuarioCadastroRequest>("UsuarioIdentity/Cadastro", input);
            if(resultado.Erro)
            return resultado.Erro;

            return true;
        }

        public async Task<bool> LogarUsuarioIdentity(Login login)
        {
            UsuarioLoginRequest usuario = new UsuarioLoginRequest { Email = login.Email, Senha = login.senha };

            var resultado = await _apiClient.LoginIdentity(usuario);
            if (resultado.Sucesso)
            {
                return true;
            }
            else if (resultado != null)
            {
                foreach (var menssagemErro in resultado.Erros)
                {
                    MessageBox.Show(menssagemErro);
                }
                return false;
            }

            return false;
        }
    }
}


