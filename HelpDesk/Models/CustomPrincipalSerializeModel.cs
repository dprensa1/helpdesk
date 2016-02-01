namespace HelpDesk.Models
{
    public class CustomPrincipalSerializeModel
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string[] Roles { get; set; }
    }
}