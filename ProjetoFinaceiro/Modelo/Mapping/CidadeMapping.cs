using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.View;

namespace apiProjetoFinaceiro.Model.Mapping
{
    public static class CidadeMapping
    {
        public static CidadeViewModel ParaViewModel(this Cidade cidade)
        {
            return new CidadeViewModel()
            {
                Id = cidade.Id,
                Nome = cidade.Nome,
                Cep = cidade.Cep,
                Situacao = cidade.Situacao,
            };
        }

    }
}
