using AutoMapper;
using Transportes.Models.Dominio;
using Transportes.Models.DTO;
using Transportes.Repositorios;

namespace Transportes.Servicos
{
    public class CaminhoesServico : Servico
    {
        private readonly IMapper mapper;
        private readonly CaminhoesRepositorio repositorio;

        public CaminhoesServico(IMapper mapper, IRepositorio repositorio) : base(mapper, repositorio)
        {
            this.mapper = mapper;
            this.repositorio = repositorio as CaminhoesRepositorio;
        }

        public Caminhoes Get(int id)
            => Map(repositorio.Selecionar(id));

        public void Post(Caminhoes caminhao)
            => repositorio.Inserir(Map(caminhao));

        public Caminhoes Alterar(Caminhoes caminhao)
            => Map(repositorio.Alterar(Map(caminhao)));

        public void Excluir(int id)
            => repositorio.Excluir(id);


        #region Mapeamento
        public Caminhoes Map(Models.DbModels.Caminhoes dbModel)
            => mapper.Map<Caminhoes>(dbModel);
        public Models.DbModels.Caminhoes Map(Caminhoes dto)
            => mapper.Map<Models.DbModels.Caminhoes>(dto);
        #endregion
    }
}