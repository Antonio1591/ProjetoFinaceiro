using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Microsoft.EntityFrameworkCore;
using ProjetoFinaceiro.Data;
using ProjetoFinaceiro.Modelo;

namespace ProjetoFinaceiro.Services
{
    public class EntradaFinaceiraService
    {
        private readonly FinanceiroDbContext _financeiroDbContext;

        public EntradaFinaceiraService(FinanceiroDbContext financeiroDbContext)
        {
            _financeiroDbContext = financeiroDbContext;
        }
        public async void Salvar(EntradaFinaceira Entrada)
        {
            _financeiroDbContext.EntradaFinaceira.Add(Entrada);
            await _financeiroDbContext.SaveChangesAsync();
        }

    }
}
