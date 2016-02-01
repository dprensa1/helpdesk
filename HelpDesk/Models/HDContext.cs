using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HelpDesk.Models
{
    public class HDContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Solucion> Soluciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public HDContext() //: base("HelpDesk")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<HDContext>());
            //Database.SetInitializer<HDContext>(new DropCreateDatabaseIfModelChanges<HDContext>());
            //Database.SetInitializer<HDContext>(new CreateDatabaseIfNotExists<HDContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Entity<Usuario>()
                .HasMany(r => r.Roles)
                .WithMany(u => u.Usuarios)
                .Map(m =>
                {
                    m.ToTable("UsuariosRoles");
                    m.MapLeftKey("UsuarioId");
                    m.MapRightKey("RolId");
                });

            modelBuilder.Entity<Usuario>()
                .HasMany(r => r.Departamentos)
                .WithMany(u => u.Usuarios)
                .Map(m =>
                {
                    m.ToTable("UsuariosDepartamentos");
                    m.MapLeftKey("UsuarioId");
                    m.MapRightKey("DepartamentoId");
                });

            modelBuilder.Entity<Cliente>()
                .HasMany(d => d.Departamentos)
                .WithMany(c => c.Clientes)
                .Map(m =>
                {
                    m.ToTable("ClientesDepartamentos");
                    m.MapLeftKey("ClienteId");
                    m.MapRightKey("DepartamentoId");
                });



            /*
            modelBuilder.Entity<IdentityUser>()
                .ToTable("Usuarios");
            modelBuilder.Entity<ApplicationUser>()
                .ToTable("Usuarios");
            */
        }
    }
}