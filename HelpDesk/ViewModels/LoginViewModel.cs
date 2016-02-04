using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.ViewModels
{
    [NotMapped]
    public class LoginViewModel
    {
            [Required(ErrorMessage = "Nombre requerido", AllowEmptyStrings = false)]
            [StringLength(8, MinimumLength = 4, ErrorMessage = " El usuario deber tener entre 4 y 8 caracteres")]
            public string User { get; set; }

            [Required(ErrorMessage = "Contraseña obligatoria", AllowEmptyStrings = false)]
            [StringLength(16, MinimumLength = 8, ErrorMessage = " La contraseña deber tener entre 8 y 16 caracteres")]
            public string Clave { get; set; }
       
    }
}