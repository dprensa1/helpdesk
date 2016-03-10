﻿using HelpDesk.Models.Enum;
using HelpDesk.Models.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        public DateTime FechaCreacion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 32 caracteres.")]
        public string Asunto { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 200 caracteres.")]
        public string Descripcion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerida.")]
        public int SolucionId { get; set; }

        public virtual Solucion Solucion { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha del modo: Mes/Dia/Año")]
        [Column(TypeName = "Date")]
        [DefaultValue("2016/01/01")]
        public DateTime FechaModificacion { get; set; }

        public Estado Estado { get; set; }             //Enum
    }
}