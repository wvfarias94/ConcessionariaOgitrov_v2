using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Data.Repositories.Carros;
using ConcessionariaOrgitrov.Data.Repositories.Clientes;
using ConcessionariaOrgitrov.Models;
using ConcessionariaOrgitrov.Services.Vendas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaOrgitrov.Controllers;

[Route("Vendas")]
[ApiController]
public class VendaController : ControllerBase
{
    private readonly IVendaService _vendaService;
    private readonly ICarroRepository _carroRepository;
    private readonly IClienteRepository _clienteRepository;

    public VendaController(IVendaService vendaService, ICarroRepository carroRepository, IClienteRepository clienteRepository)
    {
        _vendaService = vendaService;
        _carroRepository = carroRepository;
        _clienteRepository = clienteRepository;
    }

    [HttpPost]
    public IActionResult AddVenda(int clienteId, int carroId, [FromBody] CreateVendaDto vendaDto)
    {
        var cliente = _clienteRepository.GetClienteById(clienteId);
        var carro = _carroRepository.GetCarroById(carroId);
        if (cliente == null || carro == null)
        {
            return NotFound();
        }
        var venda = _vendaService.AddVenda(cliente, carro, vendaDto);
        return CreatedAtAction(nameof(GetVendaById), new { id = venda.Id }, venda);
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

    [HttpPut("{id}")]
    public IActionResult UpdateVenda(int id, [FromBody] UpdateVendaDto vendaDto)
    {
        _vendaService.UpdateVenda(id, vendaDto);
        return Ok(vendaDto);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteVenda(int id)
    {
        _vendaService.DeleteVenda(id);
        return NoContent();
    }

}
