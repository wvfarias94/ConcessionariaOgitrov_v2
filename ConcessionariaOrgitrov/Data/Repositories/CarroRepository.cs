using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Data.Repositories
{
    public class CarroRepository : ICarroRepository
    {

        private readonly AppDbContext _context;
        public CarroRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateCarro(Carro carro)
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();
        }

        public void DeleteCarro(Carro carro)
        {
            _context.Carros.Remove(carro); 
            _context.SaveChanges();
        }

        public Carro GetCarroById(int id)
        {
            return _context.Carros.Find(id);
        }

        public IEnumerable<Carro> GetCarros()
        {
            return _context.Carros.ToList();
        }

        public void UpdateCarro(Carro carro)
        {
            _context.Update(carro);
            _context.SaveChanges();
        }
    }
}
