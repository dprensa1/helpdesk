using HelpDesk.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModels
{
    public class DepartamentoViewModel
    {
        private string _nombre;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public virtual ICollection<Categoria> Categorias { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }

        public virtual ICollection<Usuario> Tecnicos { get; set; }
    }
}