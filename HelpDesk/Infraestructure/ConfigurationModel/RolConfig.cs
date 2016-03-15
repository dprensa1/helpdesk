using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class RolConfig : EntityTypeConfiguration<Rol>
    {public RolConfig()
        {
            ToTable("Roles");

            //HasKey(a => a.Id);

            //Property(a => a.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(16)
                .IsRequired();

            Property(r => r.Descripcion)
                .HasColumnType("nvarchar")
                .HasMaxLength(128);

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

            //HasMany(r => r.Usuarios)
            //    .WithMany(u => u.Rols)
            //    .Map(ur =>
            //    {
            //        ur.MapLeftKey("RolId");
            //        ur.MapRightKey("UsuarioId");
            //        ur.ToTable("RolesUsuarios");
            //    });
        }
    }
}