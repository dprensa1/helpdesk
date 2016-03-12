using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using HelpDesk.Models.Enum;

namespace HelpDesk.Models
{
    public class Usuario : IdentityUser
    {
        public int UsuarioId { get; set; }
        public int EmpleadoId { get; set; }
        //public int SolicitudId { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public bool Estado { get; set; }
       
        public virtual Tecnico Tecnico { get; set; }
        public virtual ICollection<Rol> Rols { get; set; }
        public virtual ICollection<Solicitud> Solicitudes { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}