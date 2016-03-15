using HelpDesk.Models;
using System.Data.Entity.ModelConfiguration;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class SolicitudConfig : EntityTypeConfiguration<Solicitud>
    {
        public SolicitudConfig()
        {
            ToTable("Solicitudes");

            HasKey(s => s.SolicitudId);

            Property(s => s.Fecha)
                .HasColumnType("date")
                .IsRequired();

            Property(s => s.Asunto)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(s => s.Descripcion)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(s => s.EstadoString)
                .HasColumnName("Estado")
                .HasColumnType("nvarchar")
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