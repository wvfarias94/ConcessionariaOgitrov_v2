using ConcessionariaOrgitrov.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaOrgitrov.Data.Repositories;

public class ClienteRepository : IClienteRepository
{

    private readonly AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public void CreateCliente(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
    }

    public void DeleteCliente(Cliente cliente)
    {
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
    }

    public IEnumerable<Cliente> GetClientes()
    {
        return _context.Clientes.ToList();
    }

    public Cliente GetClienteById(int id)
    {
        return _context.Clientes.Find(id);
    }

    public void UpdateCliente(Cliente cliente)
    {
        _context.Entry(cliente).State = EntityState.Modified;
        _context.SaveChanges();
    }
}
