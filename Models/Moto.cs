using System.ComponentModel.DataAnnotations;

namespace GestorMotosRetenidas.Models
{
    public class Moto
    {
        [Key]
        public int NroRetencion { get; set; }

        [Required]
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public DateTime FechaRetencion { get; set; }

        public string NumeroChasis { get; set; }
        public string NumeroMotor { get; set; }

        public string NumeroActa { get; set; }
        public DateTime? FechaTraslado { get; set; } //Si es que se movió a otro galpón

        public int GalponActualId { get; set; }
        public Galpon GalponActual { get; set; }

        public int? GalponAnteriorId { get; set; } //Si es que se movió a otro galpón
        public Galpon? GalponAnterior { get; set; }

        public int DniTitular { get; set; }
        public Titular Titular { get; set; }
        public int DniInfractor { get; set; }
        public Infractor Infractor { get; set; }

        public EstadoMoto EstadoMoto { get; set; } = EstadoMoto.Retenida;

        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
    }
}
