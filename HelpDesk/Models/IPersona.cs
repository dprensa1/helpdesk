using System.Collections.Generic;

namespace HelpDesk.Models
{
    public interface IPersona
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        ICollection<Departamento> Departamentos { get; set; }
        bool Estado { get; set; }
    }
}