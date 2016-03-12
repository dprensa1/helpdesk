using System;
using System.Collections.Generic;
using HelpDesk.Models.Interfaces;

namespace HelpDesk.Models
{
    public class Categoria : IAuditable
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Solicitud> Solicitudes { get; set; }

        public DateTime CreadoEn { get; set; }
        public string CreadoPor { get; set; }
        public DateTime ModificadoEn { get; set; }
        public string ModificadoPor { get; set; }
    }
}