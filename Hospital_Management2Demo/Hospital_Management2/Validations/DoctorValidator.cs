using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
	public class DoctorValidator : AbstractValidator<DoctorModel>
	{
		public DoctorValidator()
		{
			RuleFor(doctor => doctor.NombreDoctor)
				.Length(3, 50)
				.NotNull().WithMessage("El nombre del doctor es obligatorio");

			RuleFor(doctor => doctor.ApellidoDoctor)
				.Length(3, 50)
				.NotNull().WithMessage("El apellido del doctor es obligatorio");

			RuleFor(doctor => doctor.Especialidad)
				.NotEmpty().WithMessage("La especialidad del doctor es obligatoria");

			RuleFor(doctor => doctor.Telefono)
				.Length(8, 15)
				.NotNull().WithMessage("El número de teléfono del doctor es obligatorio");

			RuleFor(doctor => doctor.Email)
				.Length(6, 50)
				.NotNull().WithMessage("El email del doctor es obligatorio");

			RuleFor(doctor => doctor.FechaContratacion)
				.NotEmpty().WithMessage("La fecha de contratación del doctor es obligatoria");

			RuleFor(doctor => doctor.Estado)
				.Length(1, 1)
				.NotNull().WithMessage("El estado del doctor es obligatorio");
		}
	}
}
