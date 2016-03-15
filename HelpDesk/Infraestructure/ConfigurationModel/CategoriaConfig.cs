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

            Property(c => c.CreadoEn)
                .HasColumnType("date");

            Property(c => c.CreadoPor)
                .HasColumnType("nvarchar")
                .HasMaxLength(16);

            Property(c => c.ModificadoEn)
                .HasColumnType("date");

            Property(c => c.ModificadoPor)
                .HasColumnType("nvarchar")
                .HasMaxLength(16);
        }
    }
}