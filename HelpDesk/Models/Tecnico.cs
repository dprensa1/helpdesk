using HelpDesk.Models.Interfaces;
using System;

namespace HelpDesk.Models
{
    public class Tecnico : IEmpleado, IAuditable
    {
        public int TecnicoId { get; set; }
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
        public virtual Usuario Usuario { get; set; }

        public DateTime CreadoEn
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string CreadoPor
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime ModificadoEn
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string ModificadoPor
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}