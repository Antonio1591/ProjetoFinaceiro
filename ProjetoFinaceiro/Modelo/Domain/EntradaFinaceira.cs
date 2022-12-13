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
    public class EntradaFinaceira
    {
        protected EntradaFinaceira() { }
        public EntradaFinaceira(string nomeEntrada, double valorEntrada, DateTime dataEntrada, string situacaoEntrada)
        {
            Nome_Entrada = nomeEntrada;
            Valor_Entrada = valorEntrada;
            Data_Entrada = dataEntrada;
            Situacao_Entrada = situacaoEntrada;
        }

        public int Id { get; set; }
        public string Nome_Entrada { get; set; }
        public double Valor_Entrada { get; set; }
        public DateTime Data_Entrada { get; set; }
        public string Situacao_Entrada { get; set; }

    }
}
