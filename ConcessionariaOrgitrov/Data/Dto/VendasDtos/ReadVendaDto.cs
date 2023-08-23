using ConcessionariaOrgitrov.Models;
using static ConcessionariaOrgitrov.Models.Enums.Pagamento;
using System.ComponentModel.DataAnnotations;

namespace ConcessionariaOrgitrov.Data.Dto.VendasDtos;

public class ReadVendaDto
{
    
    public int Id { get; set; }
    
    public int ClienteId { get; set; }
    
    public int CarroId { get; set; }
    
    public double Valor { get; set; }
    
    public FormaPagamento FormaPagamento { get; set; }
}
