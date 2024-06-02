using FluentValidation;
using Hospital_Management2.Models;

namespace Hospital_Management2.Validations
{
    public class MedicamentoValidator : AbstractValidator<MedicamentoModel>
    {
        public MedicamentoValidator() 
        {
            RuleFor(medicamento => medicamento.Nombre)
                .Length(3, 50)
                .NotNull().WithMessage("El nombre del medicamento es obligatorio");

            RuleFor(medicamento => medicamento.Descripcion)
                 .Length(20, 100)
                 .NotNull().WithMessage("La descripcion del medicamento es obligatorio");

            RuleFor(medicamento => medicamento.TiempoAdministrable)
                .Length(10, 50)
                .NotEmpty().WithMessage("El tiempo administrable del medicamento es obligatorio");

            RuleFor(medicamento => medicamento.Cantidad)
               .Length(1, 10)
               .NotNull().WithMessage("La cantidad del medicamento es obligatorio");

        }

    }
}
