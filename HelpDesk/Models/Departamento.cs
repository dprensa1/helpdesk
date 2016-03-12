using System;
using System.Collections.Generic;
using HelpDesk.Models.Interfaces;

namespace HelpDesk.Models
{
    public class Departamento : IAuditable
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Tecnico> Tecnicos { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}