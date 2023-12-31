﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ConcessionariaOrgitrov.Models.Enums.Pagamento;

namespace ConcessionariaOrgitrov.Models;

public class Venda
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public Cliente Cliente { get; set; }
    [ForeignKey("Cliente")]
    [Required]
    public int ClienteId { get; set; }
    [Required]
    public Carro Carro { get; set; }
    [ForeignKey("Carro")]
    [Required]
    public int CarroId { get; set; }
    [Required]
    public double Valor { get; set; }

    [Required]
    public FormaPagamento FormaPagamento { get; set; }

    public DateTime DataVenda { get; set; } = DateTime.Now;
    
}
