using AutoMapper;
using HumorHub.Data;
using HumorHub.Data.Dtos;
using HumorHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumorHub.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private HumorContext _context;
    private IMapper _mapper;

    public CategoryController(HumorContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }

    [HttpPost]
    public IActionResult AddCategory([FromBody] CreateUpdateCategoryDto createUpdateCategoryDto)
    {
        var category = _mapper.Map<Category>(createUpdateCategoryDto);
        _context.Categories.Add(category);
        _context.SaveChanges();
        var addedCategoDto = _mapper.Map<ReadCategoryDto>(category);
        return CreatedAtAction(nameof(ReadCategoryById), new { Id = category.Id }, addedCategoDto);
    }

    [HttpGet]
    public IEnumerable<ReadCategoryDto> ReadCategories([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        var category = _context.Categories.Skip(skip).Take(take).ToList();
        return _mapper.Map<List<ReadCategoryDto>>(category);
    }

    [HttpGet("{id}")]
    public IActionResult ReadCategoryById(int id)
    {
            var category = _context.Categories.FirstOrDefault(category => category.Id == id);
            if (category == null) return NotFound();
            var categoryDto = _mapper.Map<ReadCategoryDto>(category);
            return Ok(categoryDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id, [FromBody] CreateUpdateCategoryDto categoryDto)
    {
        var category = _context.Categories.FirstOrDefault(category => category.Id == id);
        if (category == null) return NotFound();
        _mapper.Map(categoryDto, category);
        _context.SaveChanges();
        var updatedCategoryDto = _mapper.Map<ReadCategoryDto>(category);
        return Ok(updatedCategoryDto);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var category = _context.Categories.FirstOrDefault(category => category.Id == id);
        if (category == null) return NotFound();
        _context.Remove(category);
        _context.SaveChanges();
        return NoContent();
    }
}