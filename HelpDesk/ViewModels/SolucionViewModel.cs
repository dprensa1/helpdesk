using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModels
{
    public class SolucionViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        public string Nombre { get; set; }        

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(64, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 64 caracteres.")]
        public string Detalle { get; set; }
    }
}