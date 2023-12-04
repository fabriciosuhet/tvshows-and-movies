using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeriesEFilmes.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string? Title { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Gênero")]
        public string? Genre { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
