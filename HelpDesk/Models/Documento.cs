using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    public class Documento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentoId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        public int SolicitudId { get; set; }
        public virtual Solicitud Solicitud { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Deber tener entre 2 y 255 caracteres.")]
        public string Ubicacion { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(8, MinimumLength = 2, ErrorMessage = "Deber tener entre 2 y 8 caracteres.")]
        public string Extension { get; set; }

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