using AutoMapper;
using Transportes.Models.Dominio;
using Transportes.Models.DTO;

namespace Transportes.Servicos
{
    public class VeiculosServico : IServico
    {
        private readonly IMapper mapper;
        public VeiculosServico(IMapper mapper) 
        {
            this.mapper = mapper;
        }

        public Veiculos Get(int id)
        {
            return new Veiculos();
        }

        public void Post(Veiculos veiculo)
        {

        }

        public Veiculos Alterar(Veiculos veiculo)
        {
            return new Veiculos();
        }

        public void Excluir(int id)
        {
            var veiculo = this.Get(id);
        }

        #region Mapeamento
        public Veiculos Map(Models.DbModels.Veiculos dbModel)
            => mapper.Map<Veiculos>(dbModel);
        #endregion
    }
}