namespace HelpDesk.Models.Interfaces
{
    public interface IEmpleado
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        int DepartamentoId { get; set; }
        Departamento Departamento { get; set; }
        bool Estado { get; set; }
    }
}