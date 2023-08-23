using ConcessionariaOrgitrov.Data.Dto.CarroDtos;
using ConcessionariaOrgitrov.Data.Dto.ClienteDtos;

namespace ConcessionariaOrgitrov.Services.Carros
{
    public interface ICarroService
    {

        IEnumerable<ReadCarroDto> GetCarro();
        ReadCarroDto GetCarroById(int id);
        void CreateCarro(CreateCarroDto carroDto);
        void UpdateCarro(int id, UpdateCarroDto carroDto);
        void DeleteCarro(int id);
    }
}
