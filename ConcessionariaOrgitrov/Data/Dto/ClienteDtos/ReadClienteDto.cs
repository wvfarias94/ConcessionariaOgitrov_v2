using ConcessionariaOrgitrov.Models;

namespace ConcessionariaOrgitrov.Data.Dto.ClienteDtos;

public class ReadClienteDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    
    public string Email { get; set; }
    
    public string Endereco { get; set; }
    
    public string Telefone { get; set; }
    
    public string Cpf { get; set; }

    public IList<Carro> CarrosObtidos { get; set; } 
}
