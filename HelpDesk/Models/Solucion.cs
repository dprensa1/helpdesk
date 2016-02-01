using HelpDesk.Models.Repositorios;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    [Table("Soluciones")]
    public class Solucion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SolucionId { get; set; }

        [NotMapped]
        private string _nombre;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [NotMapped]
        private string _detalle;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(64, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 64 caracteres.")]
        public string Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }

        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        [DefaultValue("2016/01/01")]
        public DateTime FechaCreacion { get; set; }
    }
}