using HelpDesk.Models.Enum;
using System;
using System.Collections.Generic;

namespace HelpDesk.Models
{
    public class SolitudDetalle
    {
        public int ID { get; set; }
        public int SolicitudID { get; set; }
        public Solicitud Solicitud { get; set; }
        public string Descripcion { get; set; }
        public Departamento Departamento { get; set; }      //Enum
        public Usuario AsignadoA { get; set; }
        public Usuario ResueltoPor { get; set; }
        public int SolucionID { get; set; }
        public Solucion Solucion { get; set; }        
        public DateTime FechaModificacion { get; set; }
    }
}