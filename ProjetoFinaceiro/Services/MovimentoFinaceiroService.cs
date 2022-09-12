using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinaceiro.Data;
using ProjetoFinaceiro.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjetoFinaceiro.Services
{
    public class MovimentoFinaceiroService
    {
        private readonly FinanceiroDbContext _financeiroDbContext;

        public MovimentoFinaceiroService(FinanceiroDbContext financeiroDbContext)
        {
            _financeiroDbContext = financeiroDbContext;
        }


        public async void Salvar(MovimentoFinaceiro movimentoFinanceiro)
        {
            _financeiroDbContext.MovimentoFinaceiro.Add(movimentoFinanceiro);
            await _financeiroDbContext.SaveChangesAsync();
        }

        public double ValorUltimoMesEntrada()
        {
            DateTime dtinicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            DateTime dtfinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 23, 59, 59).AddDays(-1);
            var valor = _financeiroDbContext.MovimentoFinaceiro.Where(S => S.Situacao_Finaceiro == "Ativo" && S.DataMovimentacao_Finaceiro >= dtinicial && S.DataMovimentacao_Finaceiro <= dtfinal).Sum(s => s.ValorEntrada_Finaceiro);
            return valor;
        }
        public double ValorUltimoMesSaida()
        {
            DateTime dtinicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            DateTime dtfinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 23, 59, 59).AddDays(-1);
            var valor = _financeiroDbContext.MovimentoFinaceiro.Where(S => S.Situacao_Finaceiro == "Ativo" && S.DataMovimentacao_Finaceiro >= dtinicial && S.DataMovimentacao_Finaceiro <= dtfinal).Sum(s => s.ValorSaida_Finaceiro);
            return valor;
        }

        public double ValorUltimoMesTotal()
        {
            DateTime dtinicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            DateTime dtfinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 23, 59, 59).AddDays(-1);
            var valor = _financeiroDbContext.MovimentoFinaceiro.Where(S => S.Situacao_Finaceiro == "Ativo" && S.DataMovimentacao_Finaceiro >= dtinicial && S.DataMovimentacao_Finaceiro <= dtfinal).Sum(s => s.ValorEntrada_Finaceiro - s.ValorSaida_Finaceiro);
            return valor;
        }

        public DateTime DataInicialUltimoMes()
        {
            DateTime dtinicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            return dtinicial;
        }


        public DateTime DataFinalUltimoMes()
        {
            DateTime dtfinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 23, 59, 59).AddDays(-1);
            return dtfinal;
        }
       

    }
}
