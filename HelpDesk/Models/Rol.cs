using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using HelpDesk.Models.Repositorios;

namespace HelpDesk.Models
{
    [Table("Roles")]
    public class Rol : IEntidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }

        [NotMapped]
        private string _nombre;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        [DataType(DataType.Text)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [NotMapped]
        private string _descripcion;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(64, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 64 caracteres.")]
        [DataType(DataType.Text)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}