using System.ComponentModel.DataAnnotations;

namespace ExamenUltimo.Models
{
    public class Reserva
    {
        [Key]
        public int Id_Reserva { get; set; }
        public string Id_Usuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public double Precio { get; set; } = 25; // Por defecto una plaza va a costar 25
    }
}
