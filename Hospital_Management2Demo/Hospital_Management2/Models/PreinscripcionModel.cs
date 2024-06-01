using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
	public class PreinscripcionModel
	{
		[Key]
		public int PresincripcionID { get; set; }

		[Required(ErrorMessage = "El ID de la cita es requerido")]
		public int CitaID { get; set; }
		[Required(ErrorMessage = "El ID del medicamento es requerido")]
		public int MedicamentoID { get; set; }
	}
}
