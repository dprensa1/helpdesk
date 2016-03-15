using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using HelpDesk.Models.Enum;
using HelpDesk.Models.Interfaces;

namespace HelpDesk.Models
{
    public class Usuario : IdentityUser, IAuditable
    {
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public bool Estado { get; set; }

        public virtual UsuarioPerfil UsuarioPerfil { get; set; }
        public virtual ICollection<Rol> Rols { get; set; }
        public virtual ICollection<Solicitud> Solicitudes { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }

        private void test()
        {
            //this.st
        }
    }
}