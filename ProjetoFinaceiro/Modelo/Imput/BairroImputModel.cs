using System.ComponentModel.DataAnnotations.Schema;

namespace apiProjetoFinaceiro.Model.Imput
{
    [NotMapped]
    public class BairroImputModel
    {
        public BairroImputModel(int id, string nome, string situacao)
        {
            Id = id;
            Nome = nome;
            Situacao = situacao;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Situacao { get; set; }
    }
}
