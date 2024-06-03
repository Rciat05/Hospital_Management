using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
	public class PrescripcionModel
	{
		[Key]
		public int PrescripcionID { get; set; }

        [Required(ErrorMessage = "La fecha de la cita no debe estar vacío")]
        public DateTime FechaCita { get; set; }

        [Required(ErrorMessage = "El motivo de la cita es requerido")]
        [StringLength(200, ErrorMessage = "El motivo de la cita no puede exceder los 200 caracteres")]
        public string MotivoCita { get; set; }

        [Required(ErrorMessage = "El estado de la cita es requerido")]
        [StringLength(1, ErrorMessage = "El estado de la cita debe ser de un solo carácter")]
        public string EstadoCitas { get; set; }

        [Required(ErrorMessage = "El nombre del medicamento no debe estar vacío")]
        public string NombreMedicamento { set; get; }

        [Required(ErrorMessage = "La descripcion del medicamento no debe estar vacío")]
        public string Descripcion { set; get; }

        [Required(ErrorMessage = "El tiempo administrable del medicamento no debe estar vacío")]
        public string TiempoAdministrable { set; get; }

        [Required(ErrorMessage = "La cantidad del medicamento no debe estar vacío")]
        public string Cantidad { set; get; }

    }
}