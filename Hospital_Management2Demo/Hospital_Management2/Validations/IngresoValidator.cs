using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
	public class IngresoValidator : AbstractValidator<IngresoModel>
	{
		public IngresoValidator() {
			RuleFor(ingreso => ingreso.PacienteID)
				.NotEmpty().WithMessage("El ID del paciente es obligatorio")
				.GreaterThan(0).WithMessage("El ID del paciente debe ser mayor que cero");

			RuleFor(ingreso => ingreso.HabitacionID)
				.NotEmpty().WithMessage("El ID de la habitación es obligatorio")
				.GreaterThan(0).WithMessage("El ID de la habitación debe ser mayor que cero");

			RuleFor(ingreso => ingreso.FechaIngreso)
				.NotEmpty().WithMessage("La fecha de los ingresos es obligatoria");

			RuleFor(ingreso => ingreso.FechaAlta)
				.NotEmpty().WithMessage("La fecha de alta es obligatoria");

			RuleFor(ingreso => ingreso.DiagnosticoInicial)
				.Length(1, 255).WithMessage("El diagnóstico inicial debe tener entre 1 y 255 caracteres");

			RuleFor(ingreso => ingreso.EstadoIngresos)
				.NotEmpty().WithMessage("El estado del ingreso es obligatorio")
				.Length(1).WithMessage("El estado del ingreso debe ser de un solo carácter");
		}
	}
}
