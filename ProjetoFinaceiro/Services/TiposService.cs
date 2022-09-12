using Microsoft.EntityFrameworkCore;
using ProjetoFinaceiro.Data;
using ProjetoFinaceiro.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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

        public IEnumerable<Tipos> obterTipoEntrada()
        {
            var tipos= _financeiroDbContext.Tipos.Where(T =>T.Tipo == "Entrada").ToList();
            return tipos;
        }
        public IEnumerable<Tipos> obterTipoSaida()
        {
            var tipos = _financeiroDbContext.Tipos.Where(T => T.Tipo == "Saida").ToList();
            return tipos;
        }
    }
}
