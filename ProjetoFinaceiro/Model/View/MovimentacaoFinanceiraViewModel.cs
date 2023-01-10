using ProjetoFinaceiro.Model.Enum;

namespace apiProjetoFinaceiro.Model.View
{
    public class MovimentacaoFinanceiraViewModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DatamovimentacaoEntrada { get; set; }
        public decimal ValorMovimentacao { get; set; }
        public string TipoOperacao { get; set; }
        public string TipoMovimentacaoDescriscao { get; set; }
        public SituacaoEnum Situacao { get; set; }
    }
}
