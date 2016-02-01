namespace HelpDesk.Models
{
    public interface IPersona
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        int AreaId { get; set; }
        bool Estado { get; set; }
    }
}