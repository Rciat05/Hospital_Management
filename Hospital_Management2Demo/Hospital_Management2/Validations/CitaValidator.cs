using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
	public class CitaValidator : AbstractValidator<CitaModel>
	{
		public CitaValidator() {

			RuleFor(cita => cita.PacienteID)
				.NotEmpty().WithMessage("El ID del paciente es obligatorio")
				.GreaterThan(0).WithMessage("El ID del paciente debe ser mayor que cero");

			RuleFor(cita => cita.DoctorID)
				.NotEmpty().WithMessage("El ID del doctor es obligatorio")
				.GreaterThan(0).WithMessage("El ID del doctor debe ser mayor que cero");

			RuleFor(cita => cita.FechaCita)
				.NotEmpty().WithMessage("La fecha de contratación del doctor es obligatoria");

			RuleFor(cita => cita.MotivoCita)
				.NotEmpty().WithMessage("El motivo de la cita es obligatorio")
				.Length(2, 100).WithMessage("El motivo de la cita debe tener entre 2 y 100 caracteres");

			RuleFor(cita => cita.EstadoCitas)
				.NotEmpty().WithMessage("El estado de la cita es obligatorio")
				.Length(1).WithMessage("El estado de la cita debe ser de un solo carácter");
		}
	}
}
