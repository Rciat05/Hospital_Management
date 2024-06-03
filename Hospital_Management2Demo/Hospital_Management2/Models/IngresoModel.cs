using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
	public class IngresoModel
	{
		[Key]
		public int IngresoID { get; set; }

        [Required(ErrorMessage = "El nombre del paciente no debe estar vacío")]
        public string NombrePaciente { get; set; }

        [Required(ErrorMessage = "El apellido del paciente no debe estar vacío")]
        public string ApellidoPaciente { get; set; }

        [Required(ErrorMessage = "El numero de Habitacion no debe estar vacío")]
        public string NumeroHabitacion { get; set; }

        [Required(ErrorMessage = "El Tipo de habitacion no debe estar vacío")]
        public string TipoHabitacion { get; set; }

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


