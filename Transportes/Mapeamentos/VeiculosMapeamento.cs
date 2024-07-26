using AutoMapper;
using Transportes.Models.Dominio;
using Transportes.Models.DTO;

namespace Transportes.Mapeamentos
{
    public class VeiculosMapeamento
    {
        public VeiculosMapeamento(IMapperConfigurationExpression config) 
        {
            config.CreateMap<Veiculos, Transportes.Models.DbModels.Veiculos>();
        }
    }
}