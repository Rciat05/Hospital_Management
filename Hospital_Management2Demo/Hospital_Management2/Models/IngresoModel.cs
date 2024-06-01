using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
	public class IngresoModel
	{
		[Key]
		public int IngresoID { get; set; }

		[Required(ErrorMessage = "El ID del paciente es requerido")]
		public int PacienteID { get; set; }

		[Required(ErrorMessage = "El ID de la habitación es requerido")]
		public int HabitacionID { get; set; }

		[Required(ErrorMessage = "La fecha del ingreso no debe estar vacío")]
		public DateTime FechaIngreso { get; set; }

		[DataType(DataType.DateTime)]
		public DateTime? FechaAlta { get; set; }

		[StringLength(255, ErrorMessage = "El diagnóstico inicial no puede exceder los 255 caracteres")]
		public string DiagnosticoInicial { get; set; }

		[Required(ErrorMessage = "El estado del ingreso es requerido")]
		[StringLength(1, ErrorMessage = "El estado del ingreso debe ser de un solo carácter")]
		public string EstadoIngresos { get; set; }
	}
}
