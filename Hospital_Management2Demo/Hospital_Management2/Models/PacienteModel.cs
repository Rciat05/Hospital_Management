using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
    public class PacienteModel
    {
        [Key]
        public int PacienteID { get; set; }

        [Required(ErrorMessage = "El nombre del paciente no debe estar vacío")]
        public string NombrePaciente { get; set; }

        [Required(ErrorMessage = "El apellido del paciente no debe estar vacío")]
        public string ApellidoPaciente { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento paciente no debe estar vacío")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Es necesario el tipo de sexo del paciente")]
        public string Sexo {  get; set; }

        [RegularExpression(@"^\d{4}-\d{4}$", ErrorMessage = "El formato del teléfono debe ser ####-####.")]
        public string Telefono {  get; set; }

        [EmailAddress(ErrorMessage = "Ingrese un correo eléctronico válido.")]
        public string Email { get; set; }

		[Required(ErrorMessage = "La fecha de registro no debe estar vacío")]
		public DateTime FechaRegistro { get; set; }

    }
}

