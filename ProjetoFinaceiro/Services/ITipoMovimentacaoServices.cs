using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Model.Imput;
using ProjetoFinaceiro.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Services
{
    public interface ITipoMovimentacaoServices
    {
        Task<IEnumerable<TipoMovimentacaoViewModel>> BuscarTipos();
        Task<TipoMovimentacaoViewModel> CadastrarTipos(TipoMovimentacaoInputModel input);
        Task<TipoMovimentacaoViewModel> AtualizarTipos(TipoMovimentacaoInputModel input);
    }
}
