using HelpDesk.Models;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModels
{
    public class ClienteViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        public string Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Requerida.", AllowEmptyStrings = false)]
        public int DepartamentoId { get; set; }
        
        public virtual Departamento Area { get; set; }

        public bool Estado { get; set; }
    }
}