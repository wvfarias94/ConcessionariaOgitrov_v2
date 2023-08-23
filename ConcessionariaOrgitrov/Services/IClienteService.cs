using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;


namespace ConcessionariaOrgitrov.Services;

public interface IClienteService
{
    IEnumerable<ReadClienteDto> GetClientes();
    ReadClienteDto GetClienteById(int id);
    void CreateCliente(CreateClienteDto clienteDto);
    void UpdateCliente(int id, UpdateClienteDto clienteDto);
    void DeleteCliente(int id);
}
