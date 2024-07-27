using Transportes.Models.Dominio;

namespace Transportes.Models.DTO
{
    public class Caminhoes : IDTO
    {
        public int id { get; set; }
        public string PlacaCavalo { get; set; }
        public string PlacaCarreta { get; set; }
        public string PlacaSegundaCarreta { get; set; }
        public int Ano { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Modelo { get; set; }
        public decimal QuiloSuportado { get; set; }
        public int Km { get; set; }
        public bool Excluido { get; set; }
    }
}