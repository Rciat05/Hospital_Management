using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
    public class PacienteValidator : AbstractValidator<PacienteModel>
    {
        public PacienteValidator()
        {
            RuleFor(paciente => paciente.NombrePaciente)
                .Length(3, 50)
                .NotNull().WithMessage("El nombre del paciente es obligatorio");

            RuleFor(paciente => paciente.ApellidoPaciente)
                 .Length(3, 50)
                 .NotNull().WithMessage("El apellido del paciente es obligatorio");

            RuleFor(paciente => paciente.FechaNacimiento)
              .NotEmpty().WithMessage("La fecha de nacimiento del paciente es obligatoria");

            RuleFor(paciente => paciente.Telefono)
               .Length(8, 15)
               .NotNull().WithMessage("El numero de telefono del paciente es obligatorio");

            RuleFor(paciente => paciente.Email)
               .Length(5, 50)
               .NotNull().WithMessage("El Email  es obligatorio");

            RuleFor(paciente => paciente.FechaRegistro)
             .NotEmpty().WithMessage("La fecha de registro del paciente es obligatoria");
        }
    }
}
