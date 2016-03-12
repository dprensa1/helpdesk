using System;

namespace HelpDesk.Models.Interfaces
{
    public interface IAuditable
    {
        DateTime CreadoEn { get; set; }
        string CreadoPor { get; set; }
        DateTime ModificadoEn { get; set; }
        string ModificadoPor { get; set; }
    }
}