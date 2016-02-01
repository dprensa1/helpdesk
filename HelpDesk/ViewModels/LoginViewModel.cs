using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        [StringLength(8, MinimumLength = 4, ErrorMessage = " Deber tener entre 4 y 8 caracteres.")]
        public string User { get; set; }

        [Required(ErrorMessage = "Requerida.", AllowEmptyStrings = false)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = " Deber tener entre 8 y 16 caracteres.")]
        public string Clave { get; set; }
    }
}