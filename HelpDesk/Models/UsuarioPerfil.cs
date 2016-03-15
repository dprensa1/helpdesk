using HelpDesk.Models.Interfaces;
using System;

namespace HelpDesk.Models
{
    public class UsuarioPerfil : IEmpleado, IAuditable
    {
        public int UsuarioPerfilId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public decimal Salario { get; set; }
        public int Codigo { get; set; }
        public DateTime FechaEntrada { get; set; }
        public bool Estado { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Departamento Departamento { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}