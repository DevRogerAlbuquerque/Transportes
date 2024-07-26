namespace Transportes.Models.Dominio
{
    public interface IDbModel
    {
        public int id { get; set; }
        public bool Excluido { get; set; }
    }
}