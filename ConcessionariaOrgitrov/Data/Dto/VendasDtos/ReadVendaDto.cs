using ConcessionariaOrgitrov.Models;
using static ConcessionariaOrgitrov.Models.Enums.Pagamento;
using System.ComponentModel.DataAnnotations;

namespace ConcessionariaOrgitrov.Data.Dto.VendasDtos;

public class ReadVendaDto
{
    [Required]
    public int Id { get; set; }
    [Required]
    public Cliente Cliente { get; set; }
    [Required]
    public Carro Carro { get; set; }
    [Required]
    public double Valor { get; set; }
    [Required]
    public FormaPagamento FormaPagamento { get; set; }
}
