using System.ComponentModel.DataAnnotations;

namespace HumorHub.Data.Dtos;

public class ReadCategoryDto
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "The category name is required")]
    public string Name { get; set; }
}