using ProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Modelo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Model.Mapping
{
    public static class TipoMovimentacaoMapping
    {
        public static TipoMovimentacaoViewModel ParaViewModel(this TipoMovimentacao tipoMovimentacao)
        {

            return new TipoMovimentacaoViewModel
            {
                TipoDescriscao = tipoMovimentacao.TipoDescriscao,
                TipoOperacao = tipoMovimentacao.TipoOperacao.ToString(),
                Situacao = tipoMovimentacao.SituacaoEnum.ToString(),
            };
        }
    }
}
