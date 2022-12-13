namespace apiProjetoFinaceiro.Model.View
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int CidadeId { get; set; }
        public string Cidade { get; set; }

        public int BairroId { get; set; }
        public string Bairro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Situacao { get; set; }

    }
}
