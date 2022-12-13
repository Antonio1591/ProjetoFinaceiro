using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinaceiro.Modelo.Domain
{
    public class SaidaFinaceira
    {   
        protected SaidaFinaceira()
        {

        }
        public SaidaFinaceira(string nomeSaida, double valorSaida, DateTime dataSaida, string situacaoSaida)
        {
            Nome_Saida = nomeSaida;
            Valor_Saida = valorSaida;
            Data_Saida = dataSaida;
            Situacao_Saida = situacaoSaida;
        }

        public int Id { get; set; }
        public string Nome_Saida { get; set; }
        public double Valor_Saida { get; set; }
        public DateTime Data_Saida { get; set; }
        public string Situacao_Saida { get; set; }
    }
}
