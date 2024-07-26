using Microsoft.AspNetCore.Mvc;
using Transportes.Models.Dominio;

namespace Transportes.Models.DTO
{
    public class Veiculos : IDTO
    {
        public int id { get; set; }
        public bool Excluido { get; set; }
    }
}