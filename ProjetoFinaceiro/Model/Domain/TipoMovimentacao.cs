using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using apiProjetoFinaceiro.Model.Domain;
using ProjetoFinaceiro.Model.Enum;

namespace ProjetoFinaceiro.Modelo.Domain
{

    public class TipoMovimentacao : Entidade
    {
        public TipoMovimentacao(TipoMovimentacaoEnum tipoOperacao, string tipoDescriscao, SituacaoEnum situacaoEnum)
        {
            if (string.IsNullOrEmpty(tipoOperacao.ToString()))
                AddErro("Informe o tipo da movimentação (E para entrada e S para saida");
            if (string.IsNullOrEmpty(tipoDescriscao))
                AddErro("Informe o nome da movimentação");
            if (!EhValido)
                return;
             TipoOperacao = tipoOperacao;
            TipoDescriscao = tipoDescriscao;
            SituacaoEnum = situacaoEnum;
        }

        public int id { get; set; }
        public TipoMovimentacaoEnum TipoOperacao { get; private set; }
        public string TipoDescriscao { get; private set; }
        public SituacaoEnum SituacaoEnum { get; private set; }
    }
}




