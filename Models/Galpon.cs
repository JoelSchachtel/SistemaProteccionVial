namespace GestorMotosRetenidas.Models;
using System.ComponentModel.DataAnnotations;

    public class Galpon
{
    [Key]
    public int GalponId { get; set; }

    public string NombreReferencia { get; set; }
    public string Direccion { get; set; }
    public int CapacidadMaxima { get; set; }
    public string UbicacionInterna { get; set; }
    public string Observaciones { get; set; }

}

