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
            var valor = _financeiroDbContext.MovimentoFinaceiro.Where(S => S.Situacao_Finaceiro == "ATIVO" && S.DataMovimentacao_Finaceiro >= dtinicial && S.DataMovimentacao_Finaceiro <= dtfinal).Sum(s => s.ValorEntrada_Finaceiro);
            return valor;
        }
        public double ValorUltimoMesSaida()
        {
            DateTime dtinicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            DateTime dtfinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 23, 59, 59).AddDays(-1);
            var valor = _financeiroDbContext.MovimentoFinaceiro.Where(S => S.Situacao_Finaceiro == "ATIVO" && S.DataMovimentacao_Finaceiro >= dtinicial && S.DataMovimentacao_Finaceiro <= dtfinal).Sum(s => s.ValorSaida_Finaceiro);
            return valor;
        }

        public double ValorUltimoMesTotal()
        {
            DateTime dtinicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            DateTime dtfinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 23, 59, 59).AddDays(-1);
            var valor = _financeiroDbContext.MovimentoFinaceiro.Where(S => S.Situacao_Finaceiro == "ATIVO" && S.DataMovimentacao_Finaceiro >= dtinicial && S.DataMovimentacao_Finaceiro <= dtfinal).Sum(s => s.ValorEntrada_Finaceiro - s.ValorSaida_Finaceiro);
            return valor;
        }

        public MovimentoFinaceiro ObtermovimentoFinaceiro(int ID, string nome)
        {
            if (ID <= 0 && string.IsNullOrEmpty(nome))
                return null;
            if (!string.IsNullOrEmpty(nome))
            {
                var tipos = _financeiroDbContext.MovimentoFinaceiro.Where(T => T.NomeOperacao_Finaceiro.Contains(nome)).FirstOrDefault();
                return tipos;
            }
            else
            {
                var tipos = _financeiroDbContext.MovimentoFinaceiro.Where(T => T.Id == ID).FirstOrDefault();
                return tipos;
            }
        }
        public IEnumerable<MovimentoFinaceiro> RelatorioPersonalizado(DateTime dataInicial, DateTime dataFinal, string tipoOperacao, string situacao)
        {

            var querry = _financeiroDbContext.MovimentoFinaceiro.AsNoTracking();

            if(situacao != "TODOS")
            {
                querry = querry.Where(T => T.Situacao_Finaceiro == situacao);
            }
            if(tipoOperacao != "TODOS")
            {
                querry = querry.Where(T => T.TipoOperacao_Finaceiro == tipoOperacao);
            }

           querry = querry.Where(S => S.DataMovimentacao_Finaceiro >= dataInicial && S.DataMovimentacao_Finaceiro <= dataFinal);

            return querry.ToList();
        }
        public async void InserirMovimentacao(MovimentoFinaceiro movimentacao)
        {
            _financeiroDbContext.MovimentoFinaceiro.Add(movimentacao);

        }
        public async void UpdateMovimentacao(MovimentoFinaceiro movimentacao)
        {
            _financeiroDbContext.MovimentoFinaceiro.Update(movimentacao);

        }

        public async void CommitMovimentacao()
        {

            await _financeiroDbContext.SaveChangesAsync();

        }

    }
}
