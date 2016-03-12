using FluentValidation;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ValidationModel
{
    public class DocumentoValidator : AbstractValidator<Documento>
    {
        public DocumentoValidator()
        {
            RuleFor(a => a.Nombre)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(4, 128).WithMessage("Debe tener entre 4 y 128 caracteres.");

            RuleFor(a => a.Extension)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(1, 8).WithMessage("Debe tener entre 1 y 8 caracteres.");

            RuleFor(a => a.Ruta)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(1, 255).WithMessage("Debe tener entre 1 y 255 caracteres.");
        }
    }
}