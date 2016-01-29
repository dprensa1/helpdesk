using HelpDesk.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    [Table("Solicitudes")]
    public class Solicitud
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SolicitudId { get; set; }

        [NotMapped]
        private DateTime _fechaCreacion;
        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        public DateTime FechaCreacion
        {
            get { return _fechaCreacion; }
            set { _fechaCreacion = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [NotMapped]
        private string _asunto;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 32 caracteres.")]
        [DataType(DataType.Text)]
        public string Asunto
        {
            get { return _asunto; }
            set { _asunto = value; }
        }

        [NotMapped]
        private string _descripcion;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 200 caracteres.")]
        [DataType(DataType.Text)]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        public int TecnicoId { get; set; }

        [ForeignKey("TecnicoId")]
        public virtual Tecnico Tecnico { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        public int SolucionId { get; set; }

        [ForeignKey("SolucionId")]
        public virtual Solucion Solucion { get; set; }

        [NotMapped]
        private DateTime _fechaModificacion;
        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        public DateTime FechaModificacion
        {
            get { return _fechaModificacion; }
            set { _fechaModificacion = value; }
        }

        public Estado Estado { get; set; }             //Enum
    }
}