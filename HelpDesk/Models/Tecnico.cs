namespace HelpDesk.Models
{
    public class Tecnico : Empleado
    {
        public virtual Usuario Usuario { get; set; }
    }
}