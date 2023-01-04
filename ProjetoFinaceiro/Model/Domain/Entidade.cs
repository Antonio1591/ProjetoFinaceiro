namespace apiProjetoFinaceiro.Model.Domain
{
    public abstract class Entidade
    {
        public List<string> Erros { get; set; } = new();

        public void AddErro(string erro)
        {
            Erros.Add(erro);
        }
        public bool EhValido => !Erros.Any();
    }

}

