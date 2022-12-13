using apiProjetoFinaceiro.Model.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiProjetoFinaceiro.Model.Imput
{
    [NotMapped]
    public class CidadeImputModel
    {
        public CidadeImputModel(int id, string nome, string cep, string situacao)
        {
            Id = id;
            Nome = nome;
            Cep = cep;
            Situacao = situacao;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "CEP da cidade obrigatorio!!")]
        public string Cep { get; set; }
        public string Situacao { get; set; }
    }
}
