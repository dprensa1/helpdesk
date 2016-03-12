using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class DepartamentoConfig : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoConfig()
        {
            ToTable("Departamento");

            HasKey(e => e.DepartamentoId);

            Property(e => e.DepartamentoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Nombre)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.Ubicacion)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();
        }
    }
}