using System;
using HelpDesk.Models.Interfaces;
using System.Collections.Generic;

namespace HelpDesk.Models
{
    public class Solucion : IAuditable
    {
        public int SolucionId { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public virtual ICollection<Solicitud> Solicitudes { get; set; }         //
        public DateTime FechaCreacion { get; set; }
        
        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}