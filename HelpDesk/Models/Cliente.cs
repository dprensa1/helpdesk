using HelpDesk.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace HelpDesk.Models
{
    public class Cliente : IEmpleado
    {
        public int ClienteId { get; set; }
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
        public virtual ICollection<Solicitud> Solicitudes { get; set; }
    }
}