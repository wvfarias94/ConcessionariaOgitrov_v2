using System.Collections.Generic;
using AutoMapper;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Data.Repositories;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Services;

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

    public void AddVenda(int clienteId, int carroId,CreateVendaDto vendaDto)
    {
        var cliente = _clienteRepository.GetClienteById(clienteId);
        var carro = _carroRepository.GetCarroById(carroId);
        var venda = _mapper.Map<Venda>(vendaDto);
        _vendaRepository.AddVenda(venda);
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
