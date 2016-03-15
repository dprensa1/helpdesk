using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HelpDesk.Models;
using System.Data.Entity.Infrastructure.Annotations;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class UsuarioPerfilConfig : EntityTypeConfiguration<UsuarioPerfil>
    {
        public UsuarioPerfilConfig()
        {
            ToTable("UsuarioPerfil");

            HasKey(e => e.UsuarioPerfilId);

            Property(e => e.UsuarioPerfilId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(c => c.Nombre)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            Property(c => c.Apellido)
                .HasColumnType("nvarchar")
                .HasMaxLength(32)
                .IsRequired();

            //Property(c => c.Sexo)
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(1)
            //    .IsRequired();

            Property(c => c.FechaNacimiento)
                .HasColumnType("date")
                .IsRequired();

            Property(c => c.Cedula)
                .HasColumnType("nvarchar")
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnAnnotation(
                    "Index", new IndexAnnotation(new IndexAttribute("Idx_Cedula") { IsUnique = true }));

            Property(c => c.Telefono)
                .HasColumnType("nvarchar")
                .HasMaxLength(10)
                .IsRequired();

            Property(c => c.Salario)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(c => c.Codigo);

            Property(c => c.FechaEntrada)
                .HasColumnType("date")
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

            //HasRequired(u => u.Usuario)
                //.WithOptional(t => t.UsuarioPerfil);
        }
    }
}