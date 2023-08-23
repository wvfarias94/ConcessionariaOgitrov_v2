using System.Collections.Generic;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionariaOrgitrov.Services
{
    public interface IVendaService
    {
        IEnumerable<ReadVendaDto> GetAllVendas();
        ReadVendaDto GetVendaById(int id);
        Venda AddVenda(Cliente cliente, Carro carro, CreateVendaDto createVendaDto);
        void UpdateVenda(int id, UpdateVendaDto vendaDto);
        void DeleteVenda(int id);
        
    }
}
