using System;
using System.Collections.Generic;
using HelpDesk.Models.Interfaces;

namespace HelpDesk.Models
{
    public class Empleado : IAuditable
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public int DepartamentoId { get; set; }
        public decimal Salario { get; set; }
        public int Codigo { get; set; }
        public DateTime FechaEntrada { get; set; }
        public bool Estado { get; set; }

        public virtual Departamento Departamento { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}