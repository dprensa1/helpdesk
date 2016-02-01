using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModels
{
    public class DocumentoViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")] 
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Deber tener entre 2 y 255 caracteres.")]
        public string Ubicacion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(8, MinimumLength = 2, ErrorMessage = "Deber tener entre 2 y 8 caracteres.")]
        public string Extension { get; set; }
    }
}