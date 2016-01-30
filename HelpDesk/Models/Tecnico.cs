using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    [Table("Tecnicos")]
    public class Tecnico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TecnicoId { get; set; }

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
        private string _apellido;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        [DataType(DataType.Text)]
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        public int DepartamentoId { get; set; }

        [ForeignKey("DepartamentoId")]
        public virtual Departamento Departamento { get; set; }

        public bool Estado { get; set; }
    }
}