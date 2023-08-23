using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Data.Repositories
{
    public interface ICarroRepository
    {
        Carro GetCarroById(int id);
        IEnumerable<Carro> GetCarros();
        void CreateCarro(Carro carro);
        void UpdateCarro(Carro carro);
        void DeleteCarro(Carro carro);

    }
}
