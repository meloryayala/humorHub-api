using System.ComponentModel.DataAnnotations;

namespace HumorHub.Models;

public class Category
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "The category name is required")]
    public string Name { get; set; }
}