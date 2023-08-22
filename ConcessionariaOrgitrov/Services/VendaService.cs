using System.Collections.Generic;
using ConcessionariaOrgitrov.Data.Repositories;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public IEnumerable<Venda> GetAllVendas()
        {
            return _vendaRepository.GetAllVendas();
        }

        public Venda GetVendaById(int id)
        {
            return _vendaRepository.GetVendaById(id);
        }

        public void AddVenda(Venda venda)
        {
            _vendaRepository.AddVenda(venda);
        }

        public void UpdateVenda(int id, Venda venda)
        {
            var existingVenda = _vendaRepository.GetVendaById(id);
            if (existingVenda != null)
            {
                existingVenda.Cliente = venda.Cliente;
                existingVenda.Carro = venda.Carro;
                existingVenda.Valor = venda.Valor;
                existingVenda.FormaPagamento = venda.FormaPagamento;

                _vendaRepository.UpdateVenda(existingVenda);
            }
        }

        public void DeleteVenda(int id)
        {
            var venda = _vendaRepository.GetVendaById(id);
            if (venda != null)
            {
                _vendaRepository.DeleteVenda(venda);
            }
        }
    }
}
