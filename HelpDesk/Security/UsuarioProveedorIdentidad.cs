using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Security
{
    public class UsuarioProveedorIdentidad
    {
        public string User { get; set; }
        //public string Nombre { get; set; }
        //public string Cedula { get; set; }

        public UsuarioProveedorIdentidad(Usuario usuario)
        {
            User = usuario.User;
            //Nombre = usuario.Empleado.Nombre;
            //Cedula = usuario.Empleado.Cedula;
        }
    }
}