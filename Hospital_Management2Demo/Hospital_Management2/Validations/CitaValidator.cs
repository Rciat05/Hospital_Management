using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
    public class CitaValidator : AbstractValidator<CitaModel>
    {
        public CitaValidator()
        {
            RuleFor(cita => cita.NombrePaciente)
                .NotEmpty().WithMessage("El nombre del paciente es obligatorio");

            RuleFor(cita => cita.ApellidoPaciente)
                .NotEmpty().WithMessage("El apellido del paciente es obligatorio");

            RuleFor(cita => cita.NombreDoctor)
                .NotEmpty().WithMessage("El nombre del doctor es obligatorio");

            RuleFor(cita => cita.ApellidoDoctor)
                .NotEmpty().WithMessage("El apellido del doctor es obligatorio");

            RuleFor(cita => cita.FechaCita)
                .NotEmpty().WithMessage("La fecha de la cita es obligatoria");

            RuleFor(cita => cita.MotivoCita)
                .NotEmpty().WithMessage("El motivo de la cita es obligatorio")
                .Length(2, 100).WithMessage("El motivo de la cita debe tener entre 2 y 100 caracteres");

            RuleFor(cita => cita.EstadoCitas)
                .NotEmpty().WithMessage("El estado de la cita es obligatorio")
                .Length(1).WithMessage("El estado de la cita debe ser de un solo carácter");
        }
    }
}
