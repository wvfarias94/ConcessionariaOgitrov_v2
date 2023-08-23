
using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.CarroDtos;
using ConcessionariaOrgitrov.Data.Repositories;
using ConcessionariaOrgitrov.Models;
using ConcessionariaOrgitrov.Services.Carros;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ConcessionariaOrgitrov.Controllers;

[Route("Carros")]
[ApiController]
public class CarrosController : ControllerBase
{
    private readonly ICarroService _carroService;

    public CarrosController(ICarroService carroService)
    {
        _carroService = carroService;

    }


    [HttpPost]
    public IActionResult AddCarro([FromBody] CreateCarroDto carroDto)
    {
        _carroService.CreateCarro(carroDto);
        return Ok(carroDto);
    }


    [HttpGet]
    public IEnumerable<ReadCarroDto> GetCarros()
    {
        return _carroService.GetCarro();
    }

    [HttpGet("{id}")]
    public IActionResult GetCarroById(int id)
    {
        var carro = _carroService.GetCarroById(id);
        if (carro == null)
        {
            return NotFound();
        }
        return Ok(carro);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarCarro(int id, [FromBody] UpdateCarroDto carroDto)
    {
        _carroService.UpdateCarro(id, carroDto);
        return Ok(carroDto);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCarroById(int id)
    {
        _carroService.DeleteCarro(id);
        return NoContent();
    }
}
    
