using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using HelpDesk.Models.Interfaces;
using System;

namespace HelpDesk.Models
{
    public class Rol : IdentityRole, IAuditable
    {
        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}