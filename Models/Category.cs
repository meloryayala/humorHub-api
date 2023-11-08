using System.ComponentModel.DataAnnotations;
using Postgrest.Attributes;
using Postgrest.Models;

namespace HumorHub.Models;

[Table("joke")]
public class Category : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Reference(typeof(Joke))]
    public virtual ICollection<Joke> Jokes { get; set; }
}