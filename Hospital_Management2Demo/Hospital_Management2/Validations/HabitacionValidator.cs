using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
    public class HabitacionValidator : AbstractValidator<HabitacionModel>
    {
        public HabitacionValidator() 
        {
            RuleFor(habitacion => habitacion.NumeroHabitacion)
                .Length(1, 3)
                .NotNull().WithMessage("El numero de Habitacion es obligatorio");

            RuleFor(habitacion => habitacion.NumeroHabitacion)
                .Length(8, 15)
                .NotNull().WithMessage("El Tipo de habitacion es obligatorio");

            RuleFor(habitacion => habitacion.NumeroHabitacion)
                .Length(1, 1)
                .NotNull().WithMessage("El Estado de la habitacion es obligatorio");
        }
    }
}
