using AutoMapper;
using Transportes.Models.Dominio;
using Transportes.Models.DTO;

namespace Transportes.Mapeamentos
{
    public class CaminhoesMapeamento : Profile
    {
        public CaminhoesMapeamento(IMapperConfigurationExpression config) 
        {
            config.CreateMap<Caminhoes, Transportes.Models.DbModels.Caminhoes>();
        }
    }
}