using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
    public class HabitacionValidator : AbstractValidator<HabitacionModel>
    {
        public HabitacionValidator() 
        {
            RuleFor(habitacion => habitacion.NumeroHabitacion)
                .Length(1, 10)
                .NotNull().WithMessage("El numero de habitación es obligatorio");

            RuleFor(habitacion => habitacion.TipoHabitacion)
                .Length(2, 30)
                .NotNull().WithMessage("El Tipo de habitación es obligatorio");

            RuleFor(habitacion => habitacion.EstadoHabitaciones)
                .Length(1, 1)
                .NotNull().WithMessage("El Estado de la habitación es obligatorio");
        }
    }
}
