using System.ComponentModel.DataAnnotations;

namespace HumorHub.Models;

public class Joke
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "The joke question is required")]
    public string Question { get; set; }
    
    [Required(ErrorMessage = "The joke question is required")]
    public string Answer { get; set; }
    
    public int CategoryId { get; set; }
    
    public virtual Category Category { get; set; }
}