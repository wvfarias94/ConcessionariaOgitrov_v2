using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOrgitrov.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    public readonly AppDbContext _context;
    public readonly IMapper _mapper;

    public ClienteController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddCliente([FromBody]CreateClienteDto _dto)
    {
        var _cliente = _mapper.Map<CreateClienteDto, Cliente>(_dto);
        _context.Clientes.Add(_cliente);
        _context.SaveChanges();
        return Ok(_cliente);
    }

    [HttpGet]
    public IEnumerable<ReadClienteDto> GetClientes()
    {
        return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ReadClienteDto>>(_context.Clientes);
    }


    [HttpGet("{id}")]
    public IActionResult GetClienteById(int id)
    {
        var _cliente = _context.Clientes.Find(id);
        if (_cliente == null)
        {
            return NotFound();
        }
        return Ok(_cliente);
    }

    [HttpPut]
    public IActionResult AtualizarCliente(int id, [FromBody] UpdateClienteDto updateClienteDto)
    {
        var cliente = _context.Clientes.Find(id);
        if (cliente == null) {return NotFound();}

        _mapper.Map(updateClienteDto, cliente);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete]
    public IActionResult DeleteClienteById(int id)
    {
        var cliente = _context.Clientes.Find(id);
        if (cliente == null) { return NotFound(); }
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
        return NoContent();
    }

}
