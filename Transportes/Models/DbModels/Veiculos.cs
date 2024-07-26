using Transportes.Models.Dominio;

namespace Transportes.Models.DbModels
{
    public class Veiculos : IDbModel
    {
        public int id { get; set; }
        public bool Excluido { get; set; }
    }
}