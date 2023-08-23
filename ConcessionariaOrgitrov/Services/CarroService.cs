using AutoMapper;
using ConcessionariaOrgitrov.Data.Dto.CarroDtos;
using ConcessionariaOrgitrov.Data.Repositories;
using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Services
{
    public class CarroService : ICarroService
    {
        private readonly ICarroRepository _carroRepository;
        private readonly IMapper _mapper;


        public CarroService(ICarroRepository carroRepository, IMapper mapper)
        {
            _carroRepository = carroRepository;
            _mapper = mapper;
        }
        public void CreateCarro(CreateCarroDto carroDto)
        {
            var carro = _mapper.Map<Carro>(carroDto);
            _carroRepository.CreateCarro(carro);
        }

        public void DeleteCarro(int id)
        {
            var carro = _carroRepository.GetCarroById(id);

            if (carro == null)
            {
                throw new Exception("Carro não encontrado");
            }
            _carroRepository.DeleteCarro(carro);
        }

        public IEnumerable<ReadCarroDto> GetCarro()
        {
            var carro = _carroRepository.GetCarros();
            return _mapper.Map<IEnumerable<ReadCarroDto>>(carro);
        }

        public ReadCarroDto GetCarroById(int id)
        {
            var carro = _carroRepository.GetCarroById(id);
            return _mapper.Map<ReadCarroDto>(carro);
        }

        public void UpdateCarro(int id, UpdateCarroDto carroDto)
        {
            var carroExistente = _carroRepository.GetCarroById(id);

            if(carroExistente == null)
            {
                throw new Exception("Carro não encontrado");
            }

            _mapper.Map(carroDto, carroExistente);
            _carroRepository.UpdateCarro(carroExistente);

        }
    }
    

    


}
