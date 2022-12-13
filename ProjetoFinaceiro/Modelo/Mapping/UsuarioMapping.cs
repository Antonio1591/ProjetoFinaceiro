using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.View;
using System.ComponentModel.DataAnnotations;

namespace apiProjetoFinaceiro.Model.Mapping
{
    public static class UsuarioMapping
    {
        public static UsuarioViewModel ParaViewModel(this Usuario usuario)
        {
            return new UsuarioViewModel()
            {
                Id = usuario.Id,
                Cidade = usuario.Cidade.Nome,
                CidadeId = usuario.Cidade.Id,
                CPF = usuario.CPF,
                Bairro = usuario.Bairro.Nome,
                BairroId= usuario.Bairro.Id,
                DataNascimento = usuario.DataNascimento,
                Nome = usuario.Nome,
                Situacao=usuario.Situacao,
                
            };
        }
    }
}
