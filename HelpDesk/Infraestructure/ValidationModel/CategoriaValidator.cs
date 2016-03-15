using FluentValidation;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ValidationModel
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            //RuleFor(a => a.Nombre)
            //    .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
            //    .NotNull().WithMessage("Requerido.")
            //    .NotEmpty().WithMessage("Requerido.")
            //    .Length(4, 64).WithMessage("Debe tener entre 4 y 64 letras.");
        }
    }
}