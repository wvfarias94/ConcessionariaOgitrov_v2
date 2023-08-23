using ConcessionariaOrgitrov.Models;
using static ConcessionariaOrgitrov.Models.Enums.Pagamento;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ConcessionariaOrgitrov.Data.Dto.VendasDtos;

public class CreateVendaDto
{
    
    public int ClienteId { get; set; }

    public int CarroId { get; set; }
    public double Valor { get; set; }
    
    public FormaPagamento FormaPagamento { get; set; }
}
