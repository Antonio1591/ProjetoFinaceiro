using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using Microsoft.EntityFrameworkCore;
using ProjetoFinaceiro.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Services
{

    public class MovimentacaoFinanceiraServices:IMovimentacaoFinanceiraServices
    {

        ApiClient _apiClient = new ApiClient(new HttpClient());
        public async Task<MovimentacaoFinanceiraViewModel> CadastrarMovimentacoes(MovimentacaoFinaceiraInputModel input)
        {
            var novaMovimentacao = new MovimentacaoFinanceira(input.Usuario,input.DatamovimentacaoEntrada,input.ValorMovimentacao,input.TipoMovimentacao,input.Situacao);
            if (!novaMovimentacao.EhValido)
            {
                foreach (var erros in novaMovimentacao.Erros)
                {
                    MessageBox.Show(erros);
                };
                return default;
            }
            var resultado = await _apiClient.Create<MovimentacaoFinanceiraViewModel, MovimentacaoFinaceiraInputModel>("MovimentacaoFinanceira/CadastroMovimentacao", input);
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

        public async Task<IEnumerable<MovimentacaoFinanceiraViewModel>> buscarMovimentacoes()
        {
            return  await _apiClient.getAsync<IEnumerable<MovimentacaoFinanceiraViewModel>>("MovimentacaoFinanceira");
        }

        public async Task<MovimentacaoFinanceiraViewModel> AtualizarMovimentacao(MovimentacaoFinaceiraInputModel input)
        {

        }

        public async Task<decimal>RetornarValorUltimoMes(TipoMovimentacaoEnum tipoMovimentacaoEnum)
        {
            var movimentacao = await buscarMovimentacoes();
            DateTime dtinicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            DateTime dtfinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 23, 59, 59).AddDays(-1);
            var valorMovimentacaoUltimoMes = movimentacao.Where(M=>M.TipoOperacao==tipoMovimentacaoEnum.ToString() && M.DatamovimentacaoEntrada >=dtinicial && M.DatamovimentacaoEntrada<=dtfinal)
                                                         .Sum(M=> M.ValorMovimentacao);
            return valorMovimentacaoUltimoMes;
            
            
        }
    }
}

