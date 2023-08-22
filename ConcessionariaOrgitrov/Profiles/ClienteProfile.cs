using AutoMapper;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<CreateClienteDto, Cliente>();
        CreateMap<Cliente, ReadClienteDto>();
        CreateMap<UpdateClienteDto, Cliente>();
    }
   
}