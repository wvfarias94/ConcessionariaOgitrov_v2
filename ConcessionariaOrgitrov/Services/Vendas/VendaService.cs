using System.Collections.Generic;
using System.Xml.Linq;
using AutoMapper;
using ConcessionariaOrgitrov.Data;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Data.Repositories.Carros;
using ConcessionariaOrgitrov.Data.Repositories.Clientes;
using ConcessionariaOrgitrov.Data.Repositories.Vendas;
using ConcessionariaOrgitrov.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOrgitrov.Services.Vendas;

public class VendaService : IVendaService
{

    private readonly ICarroRepository _carroRepository;
    private readonly IClienteRepository _clienteRepository;
    private readonly IVendaRepository _vendaRepository;
    private readonly IMapper _mapper;

    public VendaService(IVendaRepository vendaRepository, IMapper mapper)
    {
        _vendaRepository = vendaRepository;
        _mapper = mapper;

    }

    public IEnumerable<ReadVendaDto> GetAllVendas()
    {
        var vendas = _vendaRepository.GetAllVendas();
        return _mapper.Map<IEnumerable<ReadVendaDto>>(vendas);
    }

    public ReadVendaDto GetVendaById(int id)
    {
        var venda = _vendaRepository.GetVendaById(id);
        return _mapper.Map<ReadVendaDto>(venda);
    }

    public Venda AddVenda(Cliente cliente, Carro carro, CreateVendaDto createVendaDto)
    {
        if (cliente == null || carro == null)
        {
            throw new ArgumentException("Cliente ou carro inválido.");
        }

        var venda = _mapper.Map<Venda>(createVendaDto);

        venda.Cliente = cliente;
        venda.Carro = carro;

        _vendaRepository.AddVenda(venda);


        return venda;
    }

    public void UpdateVenda(int id, UpdateVendaDto vendaDto)
    {
        var existingVenda = _vendaRepository.GetVendaById(id);
        if (existingVenda == null)
        {
            throw new Exception("Venda não encontrada");
        }

        _mapper.Map(vendaDto, existingVenda);
        _vendaRepository.UpdateVenda(existingVenda);
    }

    public void DeleteVenda(int id)
    {
        var venda = _vendaRepository.GetVendaById(id);
        if (venda == null)
        {
            throw new Exception("Venda não encontrada");
        }

        _vendaRepository.DeleteVenda(venda);
    }


}
