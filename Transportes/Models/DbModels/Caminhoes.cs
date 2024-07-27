using SqlKata;
using System.ComponentModel.DataAnnotations;
using Transportes.Models.Dominio;

namespace Transportes.Models.DbModels
{
    public class Caminhoes : IDbModel
    {
        [SqlKata.Key]
        [SqlKata.Ignore]
        public int id { get; set; }

        [MaxLength(15, ErrorMessage = "Placa Cavalo possui tamanho máximo de 15 caracteres")]
        [Required(ErrorMessage = "Informe a Placa Cavalo do caminhão.")]
        public string PlacaCavalo { get; set; }

        [MaxLength(15, ErrorMessage = "Placa Carreta possui tamanho máximo de 15 caracteres")]
        public string PlacaCarreta { get; set; }

        [MaxLength(15, ErrorMessage = "Placa da segunda Carreta possui tamanho máximo de 15 caracteres")]
        public string PlacaSegundaCarreta { get; set; }
        public int Ano { get; set; }

        [MaxLength(15, ErrorMessage = "Cidade possui tamanho máximo de 50 caracteres")]
        [Required(ErrorMessage = "Informe a cidade do caminhão.")]
        public string Cidade { get; set; }

        [MaxLength(15, ErrorMessage = "UF possui tamanho máximo de 2 caracteres")]
        [Required(ErrorMessage = "Informe a UF")]
        public string Estado { get; set; }

        [MaxLength(15, ErrorMessage = "Modelo possui tamanho máximo de 30 caracteres")]
        [Required(ErrorMessage = "Informe o modelo do caminhão.")]
        public string Modelo { get; set; }
        public decimal QuiloSuportado { get; set; }

        [Range(0, int.MaxValue)]
        [Required(ErrorMessage = "O KM é obrigatório.")]
        public int Km { get; set; }
        public bool Excluido { get; set; }
    }
}