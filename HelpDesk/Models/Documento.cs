using HelpDesk.Models.Repositorios;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    public class Documento: IEntidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentoId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        public int SolicitudId { get; set; }

        [ForeignKey("SolicitudId")]
        public virtual Solicitud Solicitud { get; set; }

        [NotMapped]
        private string _ubicacion;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Deber tener entre 2 y 255 caracteres.")]
        [DataType(DataType.Text)]
        public string Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
        }

        [NotMapped]
        private string _extension;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(8, MinimumLength = 2, ErrorMessage = "Deber tener entre 2 y 8 caracteres.")]
        [DataType(DataType.Text)]
        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        [DefaultValue("2016/01/01")]
        public DateTime FechaCreacion { get; set; }
    }
}