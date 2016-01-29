using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    [Table("Tecnicos")]
    public class Tecnico : IPersona
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

/*

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

        [NotMapped]
        private string _User { get; set; }

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        [Index("UserIDX", IsUnique = true)]
        [StringLength(8, MinimumLength = 4, ErrorMessage = " Deber tener entre 4 y 8 caracteres.")]
        public string User
        {
            get
            {
                return _User;
            }
            set
            {
                _User = value;
            }
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

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        public int DepartamentoId { get; set; }

        [ForeignKey("DepartamentoId")]
        public virtual Departamento Departamento { get; set; }

        public bool Estado { get; set; }
    }
}

    */
