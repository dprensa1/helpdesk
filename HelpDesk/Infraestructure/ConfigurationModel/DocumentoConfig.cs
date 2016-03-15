using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class DocumentoConfig : EntityTypeConfiguration<Documento>
    {
        public DocumentoConfig()
        {
            ToTable("Documentos");

            HasKey(d => d.DocumentoId);

            Property(d => d.DocumentoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Nombre)
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsRequired();

            Property(c => c.Extension)
                .HasColumnType("nvarchar")
                .HasMaxLength(28)
                .IsRequired();

            Property(c => c.Ruta)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
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