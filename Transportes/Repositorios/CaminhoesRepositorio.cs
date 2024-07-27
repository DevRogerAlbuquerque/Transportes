using Transportes.Models.Dominio;
using Transportes.Models.DbModels;
using SqlKata.Execution;

namespace Transportes.Repositorios
{
    public class CaminhoesRepositorio : RepositorioBase<Caminhoes>, IRepositorio
    {
        public CaminhoesRepositorio(QueryFactory query) : base(query) { }

        public Caminhoes Selecionar(int id)
            => base.Selecionar(id);

        public Caminhoes Alterar(Caminhoes caminhao)
            => base.Alterar(caminhao);

        public void Excluir(int id)
            => base.Excluir(id);

        public void Inserir(Caminhoes caminhoes)
            => base.Inserir(caminhoes);
    }
}