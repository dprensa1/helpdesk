using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        public int TecnicoId { get; set; }

        [ForeignKey("TecnicoId")]
        public virtual Tecnico Tecnico { get; set; }

        [NotMapped]
        private string _User { get; set; }
        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        [Index("UserIDX", IsUnique = true)]
        [StringLength(8, MinimumLength = 4, ErrorMessage = " Deber tener entre 4 y 8 caracteres.")]
        public string User
        {
            get { return _User; }
            set { _User = value; }
        }

        [NotMapped]
        private string _clave;
        [Required(ErrorMessage = "Requerida.", AllowEmptyStrings = false)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = " Deber tener entre 8 y 16 caracteres.")]
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public virtual Rol Rol { get; set; }

        public bool Estado { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        [DefaultValue("2016/01/01")]
        public DateTime FechaCreacion { get; set; }
    }
}