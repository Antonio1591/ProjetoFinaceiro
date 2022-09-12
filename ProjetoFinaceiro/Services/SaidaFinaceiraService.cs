using ProjetoFinaceiro.Data;
using ProjetoFinaceiro.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Services
{
    public class SaidaFinaceiraService
    {
        private readonly FinanceiroDbContext _financeiroDbContext;

        public SaidaFinaceiraService(FinanceiroDbContext financeiroDbContext)
        {
            _financeiroDbContext = financeiroDbContext;
        }

        public async void Salvar(SaidaFinaceira saida)
        {
            _financeiroDbContext.SaidaFinaceira.Add(saida);
            await _financeiroDbContext.SaveChangesAsync();
        }

    }
}
