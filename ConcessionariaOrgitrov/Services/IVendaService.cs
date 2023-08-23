using System.Collections.Generic;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Services
{
    public interface IVendaService
    {
        IEnumerable<ReadVendaDto> GetAllVendas();
        ReadVendaDto GetVendaById(int id);
        void AddVenda(int clienteId, int carroId, CreateVendaDto vendaDto);
        void UpdateVenda(int id, UpdateVendaDto vendaDto);
        void DeleteVenda(int id);
    }
}
