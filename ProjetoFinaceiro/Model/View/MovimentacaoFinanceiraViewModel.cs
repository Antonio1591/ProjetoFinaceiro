using ProjetoFinaceiro.Model.Enum;

namespace apiProjetoFinaceiro.Model.View
{
    public class MovimentacaoFinanceiraViewModel
    {
        public int Id { get; set; }
        public DateTime DatamovimentacaoEntrada { get; set; }
        public decimal ValorMovimentacao { get; set; }
        public string TipoOperacao { get; set; }
        public int TipoMovimentacaoId { get; set; }
        public string TipoMovimentacaoDescriscao { get; set; }
        public SituacaoEnum Situacao { get; set; }
    }
}
