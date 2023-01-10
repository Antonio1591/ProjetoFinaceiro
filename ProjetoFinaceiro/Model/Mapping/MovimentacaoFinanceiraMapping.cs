﻿using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.View;

namespace apiProjetoFinaceiro.Model.Mapping
{
    public static class MovimentacaoFinanceiraMapping
    {
        public static MovimentacaoFinanceiraViewModel ParaViewModel(this MovimentacaoFinanceira movimentacaoFinaceira)
        {
            return new MovimentacaoFinanceiraViewModel
            {
                Id = movimentacaoFinaceira.Id,
                IdUsuario = movimentacaoFinaceira.Usuario.Id,
                NomeUsuario = movimentacaoFinaceira.Usuario.Nome,
                DatamovimentacaoEntrada = movimentacaoFinaceira.DatamovimentacaoEntrada,
                ValorMovimentacao = movimentacaoFinaceira.ValorMovimentacao,
                TipoOperacao = movimentacaoFinaceira.TipoMovimentacao.TipoOperacao.ToString(),
                TipoMovimentacaoDescriscao = movimentacaoFinaceira.TipoMovimentacao.TipoDescriscao,
                Situacao = movimentacaoFinaceira.Situacao,

            };
        }
    }
}
