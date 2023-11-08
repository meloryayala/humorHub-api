using System.ComponentModel.DataAnnotations;

namespace HumorHub.Models;

public class Joke
{
    public int Id { get; set; }
    
    [Required]
    public string Question { get; set; }
    
    [Required]
    public string Answer { get; set; }
    
    public int CategoryId { get; set; }
    
    public virtual Category Category { get; set; }
}