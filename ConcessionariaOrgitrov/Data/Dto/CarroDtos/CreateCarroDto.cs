using System.ComponentModel.DataAnnotations;

namespace ConcessionariaOrgitrov.Data.Dto.CarroDtos;

public class CreateCarroDto
{
    public string Modelo { get; set; }
    
    public string Cor { get; set; }
    
    public string Marca { get; set; }
    
    public int Ano { get; set; }
    
    public string Placa { get; set; }
    
    public double KmRodado { get; set; }
 
    public double Valor { get; set; }
}
