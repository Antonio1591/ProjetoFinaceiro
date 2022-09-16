using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace ProjetoFinaceiro.Modelo
{
    public class MovimentoFinaceiro
    {
       protected MovimentoFinaceiro() { }
        public MovimentoFinaceiro(string nomeOpercaoFinaceiro,string tipoOperacaoFinaceiro, double valorEntradaFinaceiro, double valorSaidaFinaceiro, DateTime dataMovimentacaoFinaceiro, string situacaoFinaceiro)
        {
            NomeOperacao_Finaceiro =nomeOpercaoFinaceiro;
            TipoOperacao_Finaceiro = tipoOperacaoFinaceiro;
            ValorEntrada_Finaceiro = valorEntradaFinaceiro;
            ValorSaida_Finaceiro = valorSaidaFinaceiro;
            DataMovimentacao_Finaceiro = dataMovimentacaoFinaceiro;
            Situacao_Finaceiro = situacaoFinaceiro;
        }

        public int Id { get; set; }
        public string NomeOperacao_Finaceiro {get; set; }
        public string TipoOperacao_Finaceiro { get; set; }
        public double ValorEntrada_Finaceiro { get; set; }
        public double ValorSaida_Finaceiro { get; set; }
        public DateTime DataMovimentacao_Finaceiro { get; set; }
        public string Situacao_Finaceiro { get; set; }

    }
}
