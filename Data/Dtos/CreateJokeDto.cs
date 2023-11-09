namespace HumorHub.Data.Dtos;

public class CreateJokeDto
{
    public string Question { get; set; }
    
    public string Answer { get; set; }
    
    public int CategoryId { get; set; }
}