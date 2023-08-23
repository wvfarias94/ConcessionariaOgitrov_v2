using System.Collections.Generic;
using AutoMapper;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Data.Repositories;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Services;

public class VendaService : IVendaService
{
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

    public void AddVenda(CreateVendaDto vendadto)
    {
        var venda = _mapper.Map<Venda>(vendadto);
        _vendaRepository.AddVenda(venda);
    }

    public void UpdateVenda(int id, UpdateVendaDto vendadto)
    {
        var existingCliente = _vendaRepository.GetVendaById(id);

        if (existingCliente == null)
        {
            throw new Exception("Cliente não encontrado");
        }

        _mapper.Map(vendadto, existingCliente);
        _vendaRepository.UpdateVenda(existingCliente);
    }

    public void DeleteVenda(int id)
    {
        var cliente = _vendaRepository.GetVendaById(id);

        if (cliente == null)
        {
            throw new Exception("Cliente não encontrado");
        }

        _vendaRepository.DeleteVenda(cliente);
    }
}
