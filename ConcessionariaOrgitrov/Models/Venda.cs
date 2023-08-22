using System.ComponentModel.DataAnnotations;
using static ConcessionariaOrgitrov.Models.Enums.Pagamento;

namespace ConcessionariaOrgitrov.Models;

public class Venda
{
    [Key]
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
    public DateTime DataVenda { get; set; } = DateTime.Now;
    public Carro CarrosVendididos { get; set; }
    public double TaxaFixa { get; private set; } = 0.02;
}
