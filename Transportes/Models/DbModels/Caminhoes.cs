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

        [MaxLength(15, ErrorMessage = "Placa Cavalo possui tamanho m�ximo de 15 caracteres")]
        [Required(ErrorMessage = "Informe a Placa Cavalo do caminh�o.")]
        public string PlacaCavalo { get; set; }

        [MaxLength(15, ErrorMessage = "Placa Carreta possui tamanho m�ximo de 15 caracteres")]
        public string PlacaCarreta { get; set; }

        [MaxLength(15, ErrorMessage = "Placa da segunda Carreta possui tamanho m�ximo de 15 caracteres")]
        public string PlacaSegundaCarreta { get; set; }
        public int Ano { get; set; }

        [MaxLength(15, ErrorMessage = "Cidade possui tamanho m�ximo de 50 caracteres")]
        [Required(ErrorMessage = "Informe a cidade do caminh�o.")]
        public string Cidade { get; set; }

        [MaxLength(15, ErrorMessage = "UF possui tamanho m�ximo de 2 caracteres")]
        [Required(ErrorMessage = "Informe a UF")]
        public string Estado { get; set; }

        [MaxLength(15, ErrorMessage = "Modelo possui tamanho m�ximo de 30 caracteres")]
        [Required(ErrorMessage = "Informe o modelo do caminh�o.")]
        public string Modelo { get; set; }
        public decimal QuiloSuportado { get; set; }

        [Range(0, int.MaxValue)]
        [Required(ErrorMessage = "O KM � obrigat�rio.")]
        public int Km { get; set; }
        public bool Excluido { get; set; }
    }
}