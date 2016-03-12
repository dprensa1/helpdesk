using System.Collections.Generic;

namespace HelpDesk.Models
{
    public class Cliente : Empleado
    {
        public ICollection<Solicitud> Solicitudes { get; set; }
    }
}