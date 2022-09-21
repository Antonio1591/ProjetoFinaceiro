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
            var tipos = _financeiroDbContext.Tipos.Where(T => T.Tipo == "Entrada").ToList();
            return tipos;
        }
        public IEnumerable<Tipos> obterTipoSaida()
        {
            var tipos = _financeiroDbContext.Tipos.Where(T => T.Tipo == "Saida").ToList();
            return tipos;
        }

        public Tipos obterTipo(int ID, string nome)
        {
            if (ID <= 0 && string.IsNullOrEmpty(nome))
                return null;
            if (!string.IsNullOrEmpty(nome))
            {
                var tipos = _financeiroDbContext.Tipos.Where(T => T.Nome.Contains(nome)).FirstOrDefault();
                return tipos;
            }
            else
            {
                var tipos = _financeiroDbContext.Tipos.Where(T => T.Id == ID).FirstOrDefault();
                return tipos;
            }
        }
        public Tipos ObterPorId(int ID)
        {
            if (ID <= 0)
                return null;

            var tipos = _financeiroDbContext.Tipos.Where(T => T.Id == ID).FirstOrDefault();
            return tipos;

        }
        public async void Inserir(Tipos tipo)
        {
            _financeiroDbContext.Tipos.Add(tipo);

        }
        public async void Update(Tipos tipo)
        {
            _financeiroDbContext.Tipos.Update(tipo);

        }

        public async  void  Commit()
        {

             await _financeiroDbContext.SaveChangesAsync();

        }
    }
}


