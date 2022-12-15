namespace ProjetoFinaceiro.Modelo
{
    public class RespostaApi<T>
    {
        public T Dados { get; set; }
        public bool Erro { get; set; }
        public string MensagemErro { get; set; }
    }
}


