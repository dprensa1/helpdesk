using HelpDesk.Models.Repositorios;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    [Table("Categorias")]
    public class Categoria : IEntidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId { get; set; }

        [NotMapped]
        private string _nombre;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido.")]
        [RegularExpression(@"[a-zA-Z ]+\w", ErrorMessage = "Solo letras.")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Deber tener entre 4 y 16 caracteres.")]
        [DataType(DataType.Text)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Required(ErrorMessage = "Requerido.", AllowEmptyStrings = false)]
        public int DepartamentoId { get; set; }

        [ForeignKey("DepartamentoId")]
        public virtual Departamento Departamento { get; set; }
    }
}