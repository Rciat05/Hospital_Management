using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
	public class IngresoValidator : AbstractValidator<IngresoModel>
	{
		public IngresoValidator() {
			RuleFor(ingreso => ingreso.NombrePaciente)
                .Length(3, 50)
                .NotNull().WithMessage("El nombre del paciente es obligatorio");

            RuleFor(ingreso => ingreso.ApellidoPaciente)
                .Length(3, 50)
                 .NotNull().WithMessage("El apellido del paciente es obligatorio");

            RuleFor(ingreso => ingreso.NumeroHabitacion)
                .Length(1, 10)
                .NotNull().WithMessage("El numero de habitación es obligatorio");

            RuleFor(ingreso => ingreso.TipoHabitacion)
                .Length(2, 30)
                .NotNull().WithMessage("El Tipo de habitación es obligatorio");

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
