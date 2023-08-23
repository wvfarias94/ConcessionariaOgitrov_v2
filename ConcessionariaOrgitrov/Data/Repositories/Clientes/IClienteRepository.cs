using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Data.Repositories.Clientes;

public interface IClienteRepository
{
    Cliente GetClienteById(int id);
    IEnumerable<Cliente> GetClientes();
    void CreateCliente(Cliente cliente);
    void UpdateCliente(Cliente cliente);
    void DeleteCliente(Cliente cliente);
}
