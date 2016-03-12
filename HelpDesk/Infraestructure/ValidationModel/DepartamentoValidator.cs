using FluentValidation;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ValidationModel
{
    public class DepartamentoValidator : AbstractValidator<Departamento>
    {
        public DepartamentoValidator()
        {
            RuleFor(a => a.Nombre)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(2, 32).WithMessage("Debe tener entre 2 y 32 letras.");

            RuleFor(a => a.Ubicacion)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(4, 32).WithMessage("Debe tener entre 4 y 32 letras.");
        }
    }
}