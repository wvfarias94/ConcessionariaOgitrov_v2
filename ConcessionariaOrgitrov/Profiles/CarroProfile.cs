using AutoMapper;
using ConcessionariaOrgitrov.Data.Dto.CarroDtos;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Profiles;

public class CarroProfile : Profile
{
    public CarroProfile()
    {
        CreateMap<CreateCarroDto, Carro>();
        CreateMap<Carro, ReadCarroDto>();
        CreateMap<UpdateCarroDto, Carro>();
    }
}
