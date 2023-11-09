using HumorHub.Models;

namespace HumorHub.Data.Dtos;

public class ReadJokeDto
{
    
    public int Id { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public string Question { get; set; }
    
    public string Answer { get; set; }
    
    public int CategoryId { get; set; }
    
    public virtual Category Category { get; set; }
}