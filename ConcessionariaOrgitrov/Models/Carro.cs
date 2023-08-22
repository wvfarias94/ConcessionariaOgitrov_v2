using System.ComponentModel.DataAnnotations;

namespace ConcessionariaOrgitrov.Models;

public class Carro
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Modelo { get; set; }
    [Required]
    public string Cor { get; set; }
    [Required]
    public string Marca { get; set; }
    [Required]
    public int Ano { get; set; }
    [Required]
    public string Placa { get; set; }
    [Required]
    public double KmRodado { get; set; }
    [Required]
    public double Valor { get; set; }
    public bool Vendido { get; set; } = false;
}
