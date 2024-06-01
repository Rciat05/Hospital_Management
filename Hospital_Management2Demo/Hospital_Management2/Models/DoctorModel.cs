using System.ComponentModel.DataAnnotations;

namespace Hospital_Management2.Models
{
    public class DoctorModel
    {
        [Key]
        public int DoctorID { get; set; }

		[Required(ErrorMessage = "El nombre del doctor no debe estar vacío")]
		public string NombreDoctor { get; set; }

		[Required(ErrorMessage = "El apellido del doctor no debe estar vacío")]
		public string ApellidoDoctor { get; set; }

		[Required(ErrorMessage = "La especialidad del doctor no debe estar vacío")]
		public string Especialidad { get; set; }

		[RegularExpression(@"^\d{4}-\d{4}$", ErrorMessage = "El formato del teléfono debe ser ####-####.")]
		public string Telefono { get; set; }

		[EmailAddress(ErrorMessage = "Ingrese un correo eléctronico válido.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "La fecha de contratación del doctor no debe estar vacío")]
		public DateTime FechaContratacion { get; set; }

		[Required(ErrorMessage = "El estado del doctor no debe estar vacío")]
		public string Estado { get; set; }
        
    }
}
