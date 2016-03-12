using System;
using System.Collections.Generic;
using HelpDesk.Models.Interfaces;

namespace HelpDesk.Models
{
    public class Documento : IAuditable
    {
        public int DocumentoId { get; set; }
        public int SolicitudId { get; set; }
        public string Nombre { get; set; }
        public string Extension { get; set; }
        public string Ruta { get; set; }
        public virtual ICollection<Solicitud> Solicitudes { get; set; }
        public DateTime FechaCreacion { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}