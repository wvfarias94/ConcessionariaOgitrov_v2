using System.Collections.Generic;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Data.Repositories.Vendas
{
    public interface IVendaRepository
    {
        IEnumerable<Venda> GetAllVendas();
        Venda GetVendaById(int id);
        void AddVenda(Venda venda);
        void UpdateVenda(Venda venda);
        void DeleteVenda(Venda venda);
    }
}
