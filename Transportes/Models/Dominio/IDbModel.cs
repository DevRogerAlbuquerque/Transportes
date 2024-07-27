using SqlKata;

namespace Transportes.Models.Dominio
{
    public interface IDbModel
    {
        [Key]
        [Ignore]
        public int id { get; set; }
        public bool Excluido { get; set; }
    }
}