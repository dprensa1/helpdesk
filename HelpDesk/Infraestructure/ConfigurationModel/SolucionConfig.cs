using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class SolucionConfig : EntityTypeConfiguration<Solucion>
    {
        public SolucionConfig()
        {
            ToTable("Soluciones");

            HasKey(d => d.SolucionId);

            Property(d => d.SolucionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Nombre)
                .HasColumnType("nvarchar")
                .HasMaxLength(64)
                .IsRequired();

            Property(c => c.Detalle)
                .HasColumnType("nvarchar")
                .HasMaxLength(254)
                .IsRequired();
        }
    }
}