using KoreanLicensePlateRecognition.Interfaces;
using KoreanLicensePlateRecognition.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LicensePlateController : ControllerBase
{
    private readonly ILicensePlateService _service;

    public LicensePlateController(ILicensePlateService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetAllPlatesAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _service.GetPlateByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] LicensePlateDto licensePlateDto)
    {
        await _service.AddPlateAsync(licensePlateDto);
        return CreatedAtAction(nameof(GetById), new { id = licensePlateDto.Id }, licensePlateDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] LicensePlateDto licensePlateDto)
    {
        if (id != licensePlateDto.Id) return BadRequest();
        await _service.UpdatePlateAsync(licensePlateDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeletePlateAsync(id);
        return NoContent();
    }
}
