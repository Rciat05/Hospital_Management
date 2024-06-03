using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
	public class PrescripcionValidator : AbstractValidator<PrescripcionModel>
	{
		public PrescripcionValidator()
		{

			RuleFor(prescripcion => prescripcion.FechaCita)
				.NotEmpty().WithMessage("La fecha de la cita es obligatoria");

			RuleFor(prescripcion => prescripcion.MotivoCita)
				.NotEmpty().WithMessage("El motivo de la cita es obligatorio")
				.Length(2, 100).WithMessage("El motivo de la cita debe tener entre 2 y 100 caracteres");

			RuleFor(prescripcion => prescripcion.EstadoCitas)
				.NotEmpty().WithMessage("El estado de la cita es obligatorio")
				.Length(1).WithMessage("El estado de la cita debe ser de un solo carácter");

			RuleFor(prescripcion => prescripcion.NombreMedicamento)
				.Length(3, 50)
				.NotNull().WithMessage("El nombre del medicamento es obligatorio");

			RuleFor(prescripcion => prescripcion.Descripcion)
				 .Length(20, 100)
				 .NotNull().WithMessage("La descripcion del medicamento es obligatorio");

			RuleFor(prescripcion => prescripcion.TiempoAdministrable)
				.Length(10, 50)
				.NotEmpty().WithMessage("El tiempo administrable del medicamento es obligatorio");

			RuleFor(prescripcion => prescripcion.Cantidad)
			   .Length(1, 10)
			   .NotNull().WithMessage("La cantidad del medicamento es obligatorio");
		}
	}
}
