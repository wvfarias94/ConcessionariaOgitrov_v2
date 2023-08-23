using ConcessionariaOrgitrov.Models;
using static ConcessionariaOrgitrov.Models.Enums.Pagamento;
using System.ComponentModel.DataAnnotations;

namespace ConcessionariaOrgitrov.Data.Dto.VendasDtos;

public class UpdateVendaDto
{
    
    public Cliente Cliente { get; set; }
    
    public Carro Carro { get; set; }
   
    public double Valor { get; set; }
    
    public FormaPagamento FormaPagamento { get; set; }
}
