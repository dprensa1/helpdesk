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

            //HasKey(u => u.Id);

            //Property(u => u.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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