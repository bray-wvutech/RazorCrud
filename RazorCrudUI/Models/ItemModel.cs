using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace RazorCrudUI.Models;

public class ItemModel
{
    [Key]
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Display(Name = "Item Name")]
    [Required]
    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    [Range(0, 1000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
