using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Domain.UsuarioIdentityRepositorio;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using Microsoft.EntityFrameworkCore;
using ProjetoFinaceiro.Model.Enum;
using ProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Services
{

    public class MovimentacaoFinanceiraServices:IMovimentacaoFinanceiraServices
    {

        private ApiClient _apiClient;
        private ITipoMovimentacaoServices _tipoMovimentacaoServices;

        public MovimentacaoFinanceiraServices(ApiClient apiClient, ITipoMovimentacaoServices tipoMovimentacaoServices)
        {
            _apiClient = apiClient;
            _tipoMovimentacaoServices = tipoMovimentacaoServices;
        }

        public async Task<MovimentacaoFinanceiraViewModel> CadastrarMovimentacoes(MovimentacaoFinanceiraInputModel input)
        {
            var obterTipoMovimentacao = await _tipoMovimentacaoServices.BuscarTipos();
            var tipo = obterTipoMovimentacao.FirstOrDefault(t => t.Id == input.TipoMovimentacaoId);
            var tipoMovimentacao = new TipoMovimentacao((TipoMovimentacaoEnum)Enum.Parse(typeof(TipoMovimentacaoEnum), tipo.TipoOperacao), tipo.TipoDescriscao, (SituacaoEnum)Enum.Parse(typeof(SituacaoEnum), tipo.Situacao));
            var novaMovimentacao = new MovimentacaoFinanceira(input.DatamovimentacaoEntrada,input.ValorMovimentacao,tipoMovimentacao, input.Situacao);
            if (!novaMovimentacao.EhValido)
            {
                foreach (var erros in novaMovimentacao.Erros)
                {
                    MessageBox.Show(erros);
                };
                return default;
            }
            var resultado = await _apiClient.Create<MovimentacaoFinanceiraViewModel, MovimentacaoFinanceiraInputModel>("MovimentacaoFinanceira/Cadastro", input);
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

        public async Task<MovimentacaoFinanceiraViewModel> AtualizarMovimentacao(MovimentacaoFinanceiraInputModel input)
        {
            var obterTipoMovimentacao=await _apiClient.getAsync<IEnumerable<MovimentacaoFinanceiraViewModel>>("MovimentacaoFinanceira");
            var tipo=  obterTipoMovimentacao.FirstOrDefault(t => t.Id == input.TipoMovimentacaoId);
            var tipoMovimentacao = new TipoMovimentacao((TipoMovimentacaoEnum)Enum.Parse(typeof(TipoMovimentacaoEnum), tipo.TipoOperacao),tipo.TipoMovimentacaoDescriscao,tipo.Situacao);
            var atualizarMovimentacao = new MovimentacaoFinanceira( input.DatamovimentacaoEntrada,input.ValorMovimentacao, tipoMovimentacao, input.Situacao);
            if (!atualizarMovimentacao.EhValido)
            {
                foreach (var erros in atualizarMovimentacao.Erros)
                {
                    MessageBox.Show(erros);
                };
                return default;
            }
            var resultado = await _apiClient.Update<MovimentacaoFinanceiraViewModel, MovimentacaoFinanceiraInputModel>("MovimentacaoFinanceira/AlterarMovimentacao", input);
            if (resultado.Erro)
            {
                foreach (var menssagemErro in resultado.MensagemErro)
                {
                    MessageBox.Show(menssagemErro);
                }
                return null;
            };
            MessageBox.Show("Movimentacao Alterada");
            return resultado.Dados;
        }

        public async Task<decimal> RetornarValorUltimoMes(TipoMovimentacaoEnum tipoMovimentacaoEnum)
        {
            var movimentacao = await buscarMovimentacoes();

            if (movimentacao == null)
            {
                return 0;
            }

            DateTime data = DateTime.Now.AddMonths(-1).Date;

            DateTime dtinicial = new DateTime(data.Year, data.Month, 1);
            DateTime dtfinal = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month), 23, 59, 59);
            var valorMovimentacaoUltimoMes = movimentacao.Where(M => M.TipoOperacao == tipoMovimentacaoEnum.ToString() && M.DatamovimentacaoEntrada >= dtinicial && M.DatamovimentacaoEntrada <= dtfinal && M.Situacao == SituacaoEnum.ATIVO)
                                                         .Sum(M => M.ValorMovimentacao);
            return valorMovimentacaoUltimoMes;


        }
    }
}

