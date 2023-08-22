using AutoMapper;
using ConcessionariaOrgitrov.Data.Dto.VendasDtos;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Profiles;

public class VendaProfile : Profile
{
    public VendaProfile()
    {
        CreateMap<CreateVendaDto, Venda>();
        CreateMap<Venda, ReadVendaDto>();
        CreateMap<UpdateVendaDto, Venda>();
    }   
}
