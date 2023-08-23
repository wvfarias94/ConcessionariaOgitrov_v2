using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Models;
using ConcessionariaOrgitrov.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaOrgitrov.Controllers;

[Route("Vendas")]
[ApiController]
public class VendaController : ControllerBase
{
    private readonly IVendaService _vendaService;

    public VendaController(IVendaService vendaService)
    {
        _vendaService = vendaService;
    }

    [HttpGet]
    public IActionResult GetAllVendas()
    {
        var vendas = _vendaService.GetAllVendas();
        return Ok(vendas);
    }

    [HttpGet("{id}")]
    public IActionResult GetVendaById(int id)
    {
        var venda = _vendaService.GetVendaById(id);
        if (venda == null)
        {
            return NotFound();
        }
        return Ok(venda);
    }

    [HttpPost]
    public IActionResult AddVenda([FromBody] CreateVendaDto vendaDto)
    {
        _vendaService.AddVenda(vendaDto);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateVenda(int id, [FromBody] UpdateVendaDto vendaDto)
    {
        _vendaService.UpdateVenda(id, vendaDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteVenda(int id)
    {
        _vendaService.DeleteVenda(id);
        return NoContent();
    }

}
