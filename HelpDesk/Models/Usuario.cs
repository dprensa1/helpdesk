using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [Key]
        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        [StringLength(8, MinimumLength = 4, ErrorMessage = " Deber tener entre 4 y 8 caracteres.")]
        public string User { get; set; }

        [Required(ErrorMessage = "Requerida.", AllowEmptyStrings = false)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = " Deber tener entre 8 y 16 caracteres.")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }

        public bool Estado { get; set; }

        [NotMapped]
        private DateTime _fechaCreacion;
        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        [DefaultValue("2016/01/01")]
        public DateTime FechaCreacion
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }
    }
}