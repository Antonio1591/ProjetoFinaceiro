using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.View;

namespace apiProjetoFinaceiro.Model.Mapping
{
    public static class BairroMapping
    {

        public static BairroViewModel ParaViewModel(this Bairro bairro)
        {
            return new BairroViewModel()
            {
                Id = bairro.Id,
                Nome = bairro.Nome,
                Situacao = bairro.Situacao

            };
        }

    }
}

