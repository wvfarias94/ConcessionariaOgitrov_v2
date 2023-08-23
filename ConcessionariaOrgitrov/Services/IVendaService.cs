using System.Collections.Generic;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Services
{
    public interface IVendaService
    {
        IEnumerable<Venda> GetAllVendas();
        Venda GetVendaById(int id);
        void AddVenda(Venda venda);
        void UpdateVenda(int id, Venda venda);
        void DeleteVenda(int id);
    }
}
