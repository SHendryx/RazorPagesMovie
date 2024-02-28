using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;
public class Movie
{
    // Id
    public int Id { get; set; }
    
    // Title
    public string? Title { get; set; }

    // Release Date
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set;}
    
    // Genre
    public string? Genre { get; set; }

    // Price
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
