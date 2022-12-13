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
    public class Tipos
    {
        protected Tipos() { }

        public Tipos(string nome, string tipo, string descricao, string situacao)
        {
            Nome = nome;
            Tipo = tipo;
            Descricao = descricao;
            Situacao = situacao;
        }
        public Tipos(int ID, string nome, string tipo, string descricao, string situacao)
        {
            Id = ID;
            Nome = nome;
            Tipo = tipo;
            Descricao = descricao;
            Situacao = situacao;
        }

        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "O nome e obrigatorio")]
        [StringLength(maximumLength: 100, MinimumLength = 4)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O Tipo e obrigatorio")]
        [StringLength(maximumLength: 10, MinimumLength = 4)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "A descrição e obrigatoria")]
        [StringLength(maximumLength: 100, MinimumLength = 10)]
        public string Descricao { get; set; }

        public string Situacao { get; set; }

    }

}
