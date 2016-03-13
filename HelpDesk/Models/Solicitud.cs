using System;
using System.Collections.Generic;
using HelpDesk.Models.Enum;
using HelpDesk.Models.Interfaces;

namespace HelpDesk.Models
{
    public class Solicitud : IAuditable
    {
        public int SolicitudId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }
        public EstadoEnum Estado { get; set; }

        public int? ClienteId { get; set; }
        public int CategoriaId { get; set; }
        public int UsuarioId { get; set; }
        public int SolucionId { get; set; }                                     //

        public virtual Cliente Cliente { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Solucion Solucion { get; set; }                          //
        public virtual ICollection<Documento> Documentos { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}