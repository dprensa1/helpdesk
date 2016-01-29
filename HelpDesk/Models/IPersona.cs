namespace HelpDesk.Models
{
     interface IPersona
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        int UsuarioId { get; set; }
        int DepartamentoId { get; set; }
        bool Estado { get; set; }
    }
}