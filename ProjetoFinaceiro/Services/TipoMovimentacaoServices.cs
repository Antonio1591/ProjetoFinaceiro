using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Model.Imput;
using ProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Services
{
    public class TipoMovimentacaoServices : ITipoMovimentacaoServices
    {
        private ApiClient _apiClient;

        public TipoMovimentacaoServices(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IEnumerable<TipoMovimentacaoViewModel>> BuscarTipos()
        {
            return await _apiClient.getAsync<IEnumerable<TipoMovimentacaoViewModel>>("TiposMovimentacao");
        }
        public async Task<TipoMovimentacaoViewModel> CadastrarTipos(TipoMovimentacaoInputModel input)
        {
            TipoMovimentacao tipoMovimentacao = new TipoMovimentacao(input.TipoOperacao,input.TipoDescriscao,input.SituacaoEnum);
            if(!tipoMovimentacao.EhValido)
            {
                foreach (var erros in tipoMovimentacao.Erros)
                {
                    MessageBox.Show(erros);
                };
                return default;
            }
            var resultado = await _apiClient.Create<TipoMovimentacaoViewModel, TipoMovimentacaoInputModel>("TiposMovimentacao/CadastroTipo", input);
            if (resultado.Erro)
            {
                foreach (var menssagemErro in resultado.MensagemErro)
                {
                    MessageBox.Show(menssagemErro);
                }
                return null;
            };
            MessageBox.Show("Tipo cadastrada! ", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return resultado.Dados;
        }
        public async Task<TipoMovimentacaoViewModel> AtualizarTipos(TipoMovimentacaoInputModel input)
        {
            TipoMovimentacao tipoMovimentacao = new TipoMovimentacao(input.TipoOperacao, input.TipoDescriscao, input.SituacaoEnum);
            if (!tipoMovimentacao.EhValido)
            {
                foreach (var erros in tipoMovimentacao.Erros)
                {
                    MessageBox.Show(erros);
                };
                return default;
            }
            var resultado = await _apiClient.Update<TipoMovimentacaoViewModel, TipoMovimentacaoInputModel>("TiposMovimentacao/AtualizarTipo",input);
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
    }
}
