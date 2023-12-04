using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeriesEFilmes.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório!")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Título")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "A data de lançamento é obrigatório!")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage = "O gênero é obrigatório!")]
        [StringLength(30)]
        [Display(Name = "Gênero")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório!")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Avaliação")]
        
        public string? Rating { get; set; }
    }
}
