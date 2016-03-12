using System.Data.Entity.ModelConfiguration;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            ToTable("Categoria");

            HasKey(e => e.CategoriaId);

            Property(e => e.Nombre)
                .HasColumnType("nvarchar")
                .HasMaxLength(16)
                .IsRequired();
        }
    }
}