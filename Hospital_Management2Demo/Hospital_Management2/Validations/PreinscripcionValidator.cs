using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
	public class PreinscripcionValidator : AbstractValidator<PreinscripcionModel>
	{
		public PreinscripcionValidator()
		{
			RuleFor(prescripcion => prescripcion.CitaID)
				.NotEmpty().WithMessage("El ID de la cita es obligatorio")
				.GreaterThan(0).WithMessage("El ID de la cita debe ser mayor que cero");

			RuleFor(prescripcion => prescripcion.MedicamentoID)
				.NotEmpty().WithMessage("El ID del medicamento es obligatorio")
				.GreaterThan(0).WithMessage("El ID del medicamento debe ser mayor que cero");
		}
	}
}
