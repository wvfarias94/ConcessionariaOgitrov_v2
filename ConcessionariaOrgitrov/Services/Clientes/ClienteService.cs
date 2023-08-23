using AutoMapper;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Data.Repositories.Clientes;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Services.Clientes;

public class ClienteService : IClienteService
{

    private readonly IClienteRepository _clienteRepository;
    private readonly IMapper _mapper;

    public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
    {
        _clienteRepository = clienteRepository;
        _mapper = mapper;
    }

    public void CreateCliente(CreateClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        _clienteRepository.CreateCliente(cliente);
    }

    public void DeleteCliente(int id)
    {
        var cliente = _clienteRepository.GetClienteById(id);

        if (cliente == null)
        {
            throw new Exception("Cliente não encontrado");
        }

        _clienteRepository.DeleteCliente(cliente);
    }

    public ReadClienteDto GetClienteById(int id)
    {
        var cliente = _clienteRepository.GetClienteById(id);
        return _mapper.Map<ReadClienteDto>(cliente);
    }

    public IEnumerable<ReadClienteDto> GetClientes()
    {
        var clientes = _clienteRepository.GetClientes();
        return _mapper.Map<IEnumerable<ReadClienteDto>>(clientes);
    }

    public void UpdateCliente(int id, UpdateClienteDto clienteDto)
    {
        var existingCliente = _clienteRepository.GetClienteById(id);

        if (existingCliente == null)
        {
            throw new Exception("Cliente não encontrado");
        }

        _mapper.Map(clienteDto, existingCliente);
        _clienteRepository.UpdateCliente(existingCliente);
    }
}
