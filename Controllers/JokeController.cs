using AutoMapper;
using HumorHub.Data;
using HumorHub.Data.Dtos;
using HumorHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumorHub.Controllers;

[ApiController]
[Route("[controller]")]
public class JokeController : ControllerBase
{
    private HumorContext _context;
    private IMapper _mapper;

    public JokeController(HumorContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    [HttpPost]
    public IActionResult AddJoke([FromBody] CreateJokeDto jokeDto)
    {
        var joke = _mapper.Map<Joke>(jokeDto);
        _context.Jokes.Add(joke);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ReadJokeById), 
            new { Id = joke.Id }, 
            joke);
    }

    [HttpGet]
    public IEnumerable<ReadJokeDto> ReadJokes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        var jokesList = _context.Jokes
            .Skip(skip)
            .Take(take)
            .ToList();
        return _mapper.Map<List<ReadJokeDto>>(jokesList);
    }

    [HttpGet("{id}")]
    public IActionResult ReadJokeById(int id)
    {
        var joke = _context.Jokes.FirstOrDefault(joke => joke.Id == id);
        if (joke == null) return NotFound();
        var jokeDto = _mapper.Map<ReadJokeDto>(joke);
        return Ok(jokeDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateJoke(int id, [FromBody] UpdateJokeDto jokeDto)
    {
        var joke = _context.Jokes.FirstOrDefault(joke => joke.Id == id);
        if (joke == null) return NotFound();
        _mapper.Map(jokeDto, joke);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteJoke(int id)
    {
        var joke = _context.Jokes.FirstOrDefault(joke => joke.Id == id);
        if (joke == null) return NotFound();
        _context.Remove(joke);
        _context.SaveChanges();
        return NoContent();
    }
}