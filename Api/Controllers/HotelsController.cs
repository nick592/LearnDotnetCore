using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelsController : ControllerBase
{
    private readonly DataSource _dataSource;
    private readonly HttpContext _http;

    public HotelsController(DataSource dataSource, HttpContext http)
    {
        _dataSource = dataSource;
        _http = http;
    }

    [HttpGet]
    public IActionResult GetAllHotels()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetHotelById(int id)
    {
        _http.Request.Headers.TryGetValue("my-middleware-header", out var headerDate);

        return Ok(headerDate);
    }

    [HttpPost]
    public IActionResult CreateHotel([FromBody] Hotel hotel)
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateHotel([FromBody] Hotel updatedHotel, int id)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteHotel(int id)
    {
        return NoContent();
    }
}