using HelpDesk.Models.Enum;
using System;

namespace HelpDesk.Models
{
    public class Solicitud
    {
        public int ID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Usuario Solicitante { get; set; }
        public string Asunto { get; set; }
        public Categoria Categoria{ get; set; }
        public Estado Estado { get; set; }             //Enum
        public Solicitud SolicitudHija { get; set; }
    }
}