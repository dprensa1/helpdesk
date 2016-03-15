using System;

namespace HelpDesk.Models.Interfaces
{
    public abstract class IEmpleado
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        bool Sexo { get; set; }
        DateTime FechaNacimiento { get; set; }
        string Cedula { get; set; }
        string Telefono { get; set; }
        //int DepartamentoId { get; set; }
        decimal Salario { get; set; }
        int Codigo { get; set; }
        DateTime FechaEntrada { get; set; }
        bool Estado { get; set; }

        Departamento Departamento { get; set; }
    }
}