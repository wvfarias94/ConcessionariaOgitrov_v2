using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaOrgitrov.Controllers;

[Route("Vendas")]
[ApiController]
public class VendaController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public VendaController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpGet]
    public IActionResult GetVendas()
    {
        var vendas = _context.Vendas.Include(vendas => vendas.Cliente)
            .Include(vendas => vendas.Carro).ToList();


        var vendasDto = _mapper.Map<List<ReadVendaDto>>(vendas);
        return Ok(vendasDto);
    }

    [HttpGet("{id}")]
    public IActionResult GetVendaById(int id)
    {
        var venda = _context.Vendas.Include(vendas => vendas.Cliente)
            .Include(vendas => vendas.Carro)
            .FirstOrDefault(vendas => vendas.Id == id);

        if (venda == null) 
        {return NotFound();}

        var vendaDto = _mapper.Map<ReadVendaDto>(venda);
        return Ok(vendaDto);
    }

    [HttpPost]
    public IActionResult PostVenda([FromBody] CreateVendaDto createVendaDto)
    {
        var venda = _mapper.Map<Venda>(createVendaDto);

        _context.Vendas.Add(venda);
        _context.SaveChanges();

        var vendaDto = _mapper.Map<ReadVendaDto>(venda);
        return CreatedAtAction(nameof(GetVendaById), new { id = vendaDto.Id }, vendaDto);
    }

    [HttpPut("{id}")]
    public IActionResult PutVenda(int id, [FromBody] UpdateVendaDto updateVendaDto)
    {
        var venda = _context.Vendas.Find(id);

        if (venda == null) {return NotFound();}

        _mapper.Map(updateVendaDto, venda);

        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteVenda(int id)
    {
        var venda = _context.Vendas.Find(id);

        if (venda == null) {return NotFound();}
        _context.Vendas.Remove(venda);
        _context.SaveChanges();
        return NoContent();
    }

}
