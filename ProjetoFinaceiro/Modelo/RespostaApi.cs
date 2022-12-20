using apiProjetoFinaceiro.Model.Domain;

namespace ProjetoFinaceiro.Modelo
{
    public class RespostaApi<T>
    {
        public T Dados { get; set; }
        public bool Erro { get; set; }
        public IEnumerable<string> MensagemErro { get; set; }
    }
}