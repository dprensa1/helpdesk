using HelpDesk.Models;
using System.Data.Entity.ModelConfiguration;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class SolicitudConfig : EntityTypeConfiguration<Solicitud>
    {
        public SolicitudConfig()
        {
            ToTable("Solicitudes");

            HasKey(d => d.SolicitudId /*new { d.SolicitudId, d.EmpleadoId, d.UsuarioId }*/);

            Property(c => c.Fecha)
                .HasColumnType("date2")
                .IsRequired();

            Property(c => c.Asunto)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.Asunto)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.Descripcion)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.Estado)
                .HasColumnType("nvarchar")
                .IsRequired();

            HasRequired(e => e.Cliente)
                .WithMany(s => s.Solicitudes)
                .HasForeignKey(s => s.ClienteId);

            HasRequired(e => e.Categoria)
                .WithMany(s => s.Solicitudes)
                .HasForeignKey(s => s.CategoriaId);

            HasRequired(e => e.Usuario)
                .WithMany(s => s.Solicitudes);

            HasRequired(s => s.Solucion)
                    .WithMany(s => s.Solicitudes)
                    .HasForeignKey(s => s.SolucionId);

            HasMany(d => d.Documentos)
                .WithMany(s => s.Solicitudes)
                .Map(sd =>
                {
                    sd.MapLeftKey("SolicitudesId");
                    sd.MapRightKey("DocumentosId");
                    sd.ToTable("SolicitudesDocumentos");
                });
        }
    }
}