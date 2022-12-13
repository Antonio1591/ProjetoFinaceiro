using System.ComponentModel.DataAnnotations;

namespace apiProjetoFinaceiro.Model.Domain
{
    public class Cidade
    {
        protected Cidade()
        {

        }

        public Cidade(int id,string nome, string cep, string situacao)
        {
            Id = id;
            Nome = nome;
            Cep = cep;
            Situacao = situacao;
        }

        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Situacao { get; set; }

    }
}