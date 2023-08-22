using System.ComponentModel.DataAnnotations;

namespace ConcessionariaOrgitrov.Models;

public class Cliente
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Endereco { get; set; }
    [Required]
    public string Telefone { get; set; }
    [Required]
    public string Cpf { get; set; }
    [Required]
    public IList<Carro> CarrosObtidos { get; set; } = new List<Carro>();
}
