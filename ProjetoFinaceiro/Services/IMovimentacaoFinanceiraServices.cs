using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Services
{
    public interface IMovimentacaoFinanceiraServices
    {
        Task <IEnumerable<MovimentacaoFinanceiraViewModel>> buscarMovimentacoes( );
        Task<MovimentacaoFinanceiraViewModel> CadastrarMovimentacoes(MovimentacaoFinanceiraInputModel input);
        Task<MovimentacaoFinanceiraViewModel> AtualizarMovimentacao(MovimentacaoFinanceiraInputModel input);
        Task<decimal> RetornarValorUltimoMes(TipoMovimentacaoEnum tipoMovimentacaoEnum);

    }
}
