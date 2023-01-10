using apiProjetoFinaceiro.Model.Domain;
using ProjetoFinaceiro.Model.Enum;
using ProjetoFinaceiro.Modelo.Domain;

namespace apiProjetoFinaceiro.Model.Imput
{
    public class MovimentacaoFinaceiraInputModel
    {
        public MovimentacaoFinaceiraInputModel(int id, Usuario idUsuario, DateTime datamovimentacaoEntrada, decimal valorMovimentacao, TipoMovimentacao tipoMovimentacao, SituacaoEnum situacao)
        {
            Id = id;
            Usuario = idUsuario;
            DatamovimentacaoEntrada = datamovimentacaoEntrada;
            ValorMovimentacao = valorMovimentacao;
            TipoMovimentacao = tipoMovimentacao;
            Situacao = situacao;
        }

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DatamovimentacaoEntrada { get; set; }
        public decimal ValorMovimentacao { get; set; }
        public TipoMovimentacao TipoMovimentacao { get; set; }
        public SituacaoEnum Situacao { get; set; }

    }
}
