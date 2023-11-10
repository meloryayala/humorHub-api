using System.ComponentModel.DataAnnotations;

namespace HumorHub.Data.Dtos;

public class CreateUpdateCategoryDto
{
    [Required(ErrorMessage = "The category name is required")]
    public string Name { get; set; }
}