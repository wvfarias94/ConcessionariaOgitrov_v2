using System.Collections.Generic;
using System.Linq;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Data.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly AppDbContext _context;

        public VendaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Venda> GetAllVendas()
        {
            return _context.Vendas.ToList();
        }

        public Venda GetVendaById(int id)
        {
            return _context.Vendas.FirstOrDefault(v => v.Id == id);
        }

        public void AddVenda(Venda venda)
        {
            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }

        public void UpdateVenda(Venda venda)
        {
            _context.Vendas.Update(venda);
            _context.SaveChanges();
        }

        public void DeleteVenda(Venda venda)
        {
            _context.Vendas.Remove(venda);
            _context.SaveChanges();
        }
    }
}
