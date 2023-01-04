using apiProjetoFinaceiro.Model.Domain;

namespace ProjetoFinaceiro.Model
{
    public class RespostaApi<TViwerModel>
    {
        public TViwerModel Dados { get; set; }
        public bool Erro { get; set; }
        public IEnumerable<string> MensagemErro { get; set; }
    }
}