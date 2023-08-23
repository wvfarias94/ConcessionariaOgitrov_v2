using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Models;
using ConcessionariaOrgitrov.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOrgitrov.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost]
    public IActionResult AddCliente([FromBody]CreateClienteDto clienteDto)
    {
        _clienteService.CreateCliente(clienteDto);
        return Ok();
    }

    [HttpGet]
    public IEnumerable<ReadClienteDto> GetClientes()
    {
        return _clienteService.GetClientes();
    }

    [HttpGet("{id}")]
    public IActionResult GetClienteById(int id)
    {
        var cliente = _clienteService.GetClienteById(id); 
        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarCliente(int id, [FromBody] UpdateClienteDto clienteDto)
    {
        _clienteService.UpdateCliente(id, clienteDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteClienteById(int id)
    {
        _clienteService.DeleteCliente(id);
        return NoContent();
    }

}
