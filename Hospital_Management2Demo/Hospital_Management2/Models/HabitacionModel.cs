using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
    public class HabitacionModel
    {
        [Key]
        public int HabitacionID { get; set; }

        [Required(ErrorMessage = "El numero de Habitacion no debe estar vacío")]
        public string NumeroHabitacion { get; set; }

        [Required(ErrorMessage = "El Tipo de habitacion no debe estar vacío")]
        public string TipoHabitacion { get; set; }

        [Required(ErrorMessage = "El Estado de la habitacion no debe estar vacío")]
        public string EstadoHabitaciones { get; set; }
    }
}
