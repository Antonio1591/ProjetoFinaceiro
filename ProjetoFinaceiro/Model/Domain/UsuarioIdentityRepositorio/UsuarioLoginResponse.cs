using System.Text.Json.Serialization;

namespace apiProjetoFinaceiro.Model.Domain.UsuarioIdentityRepositorio
{
    public class UsuarioLoginResponse 
    {

        public bool Sucesso { get; set; }
        public string Token { get; set; }
        public DateTime? DataExpiracao { get; set; }
        public List<string> Erros { get; set;}
    }
}
