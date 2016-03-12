using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            ToTable("Usuarios");

            HasKey(u => new { u.Id, u.UsuarioId });

            Property(u => u.UsuarioId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(u => u.UserName)
                .HasColumnType("nvarchar")
                .HasMaxLength(16)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("IX_UserName", 1) { IsUnique = true }));

            Property(u => u.PasswordHash)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            HasRequired(e => e.Tecnico)
                .WithRequiredPrincipal(u => u.Usuario);

            //
            //HasMany(s => s.Solicitudes)
            //        .WithRequired(s => s.Usuario)
            //        .HasForeignKey(s => s.SolicitudId);

            HasMany(r => r.Rols)
                .WithMany(u => u.Usuarios)
                .Map(ur =>
                {
                    ur.MapLeftKey("UsuarioId");
                    ur.MapRightKey("RolId");
                    ur.ToTable("UsuariosRoles");
                });
        }
    }
}