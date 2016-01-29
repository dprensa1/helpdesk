using System.Collections.Generic;

namespace HelpDesk.Models
{
    public class Rol
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public bool Estado { get; set; }
    }
}