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
                .HasColumnType("date2")
                .IsRequired();

            Property(s => s.Asunto)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(s => s.Asunto)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(s => s.Descripcion)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(s => s.Estado)
                .HasColumnType("nvarchar")
                .IsRequired();

            HasRequired(c => c.Cliente)
                .WithMany(s => s.Solicitudes)
                .HasForeignKey(c => c.ClienteId);

            HasRequired(s => s.Categoria)
                .WithMany(s => s.Solicitudes)
                .HasForeignKey(s => s.CategoriaId);

            HasRequired(u => u.Usuario)
                .WithMany(s => s.Solicitudes)
                .HasForeignKey(u => u.UsuarioId);

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