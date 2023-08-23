using ConcessionariaOrgitrov.Models;
using static ConcessionariaOrgitrov.Models.Enums.Pagamento;
using System.ComponentModel.DataAnnotations;

namespace ConcessionariaOrgitrov.Data.Dto.VendasDtos;

public class CreateVendaDto
{
   
    [Required]
    public double Valor { get; set; }
    [Required]
    public FormaPagamento FormaPagamento { get; set; }
}
