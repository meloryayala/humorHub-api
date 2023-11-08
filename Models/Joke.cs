using System.ComponentModel.DataAnnotations;
using Postgrest.Attributes;
using Postgrest.Models;

namespace HumorHub.Models;

public class Joke: BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("question")]
    public string Question { get; set; }
    
    [Column("answer")]
    public string Answer { get; set; }
    
    [Column("category_id")]
    public int CategoryId { get; set; }
    
    [Reference(typeof(Category))]
    public virtual Category Category { get; set; }
}