using Microsoft.EntityFrameworkCore;
using ProjetoFinaceiro.Data;
using ProjetoFinaceiro.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Services
{
    public class TiposService
    {
        private readonly FinanceiroDbContext _financeiroDbContext;

        public TiposService(FinanceiroDbContext financeiroDbContext)
        {
            _financeiroDbContext = financeiroDbContext;
        }

        public async Task<IEnumerable<Tipos>> ObterTipos()
        {
            return await _financeiroDbContext.Tipos.ToListAsync();
        }

        public async void Salvar(Tipos tipo)
        {
            _financeiroDbContext.Tipos.Add(tipo);

            await _financeiroDbContext.SaveChangesAsync();
        }
    }
}
