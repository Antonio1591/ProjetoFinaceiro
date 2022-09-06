using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinaceiro.Data;
using ProjetoFinaceiro.Modelo;

namespace ProjetoFinaceiro.Services
{
    public class MovimentoFinanceiroService
    {
        private readonly FinanceiroDbContext _financeiroDbContext;

        public MovimentoFinanceiroService(FinanceiroDbContext financeiroDbContext)
        {
            _financeiroDbContext = financeiroDbContext;
        }

        public async Task<IEnumerable<TipoEntrada>> ObterTipos()
        {
            return await _financeiroDbContext.TiposEntrada.ToListAsync();
        }

        public async void Salvar(TipoEntrada tipo)
        {
            _financeiroDbContext.TiposEntrada.Add(tipo);

          
            await _financeiroDbContext.SaveChangesAsync();
        }

    }
}
