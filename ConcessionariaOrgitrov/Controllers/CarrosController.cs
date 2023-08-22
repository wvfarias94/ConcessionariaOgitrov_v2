
using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.CarroDtos;
using ConcessionariaOrgitrov.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOrgitrov.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarrosController : ControllerBase
{
    public readonly AppDbContext _context;
    public readonly IMapper _mapper;

    public CarrosController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddCarros([FromBody]CreateCarroDto _dto)
    {
        var _carro = _mapper.Map<CreateCarroDto, Carro>(_dto);
        _context.Carros.Add(_carro);
        _context.SaveChanges();
        return Ok(_carro);
    }

    [HttpGet]
    public IEnumerable<ReadCarroDto> GetCarros()
    {
        return _mapper.Map<IEnumerable<Carro>, IEnumerable<ReadCarroDto>>(_context.Carros);
    }

    [HttpGet("{id}")]

    public IActionResult GetCarroById(int id)
    {
        var _carro = _context.Carros.Find(id);
        if (_carro == null)
        {
            return NotFound();
        }
        return Ok(_carro);
    }

    [HttpPut]
    public IActionResult AtualizarCarro(int id, [FromBody] UpdateCarroDto updateCarroDto)
    {
        var carro = _context.Carros.Find(id);

        if (carro == null) {return NotFound();}

        _mapper.Map(updateCarroDto, carro);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete]
    public IActionResult DeleteCarroById(int id)
    {
        var carro = _context.Carros.Find(id);
        if (carro == null) {return NotFound();}

        _context.Carros.Remove(carro);
        _context.SaveChanges();
        return NoContent();
    }
}
