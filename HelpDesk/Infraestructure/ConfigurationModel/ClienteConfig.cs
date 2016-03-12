using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.ConfigurationModel
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("Clientes");

            HasKey(e => new { e.EmpleadoId, e.Cedula });

            Property(e => e.EmpleadoId)
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

            Property(c => c.Sexo)
                .HasColumnType("char")
                .HasMaxLength(1)
                .IsRequired();

            Property(c => c.FechaNacimiento)
                .HasColumnType("date2")
                .IsRequired();

            Property(c => c.Cedula)
                .HasColumnType("nvarchar")
                .HasMaxLength(11)
                .IsRequired();

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

            HasRequired(d => d.Departamento)
                .WithMany(e => e.Clientes )
                .HasForeignKey(d => d.DepartamentoId);

            //
            //HasMany(s => s.Solicitudes)
            //        .WithRequired(s => s.Empleado)
            //        .HasForeignKey(s => s.SolicitudId);
        }
    }
}