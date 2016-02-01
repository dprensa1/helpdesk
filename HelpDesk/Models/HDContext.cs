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
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public HDContext() : base("HelpDesk")
        {
            //Database.SetInitializer<Lyra>(new DropCreateDatabaseAlways<Lyra>());
            //Database.SetInitializer<Lyra>(new DropCreateDatabaseIfModelChanges<Lyra>());

            Database.SetInitializer<HDContext>(new CreateDatabaseIfNotExists<HDContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            /*
            modelBuilder.Entity<IdentityUser>()
                .ToTable("Usuarios");
            modelBuilder.Entity<ApplicationUser>()
                .ToTable("Usuarios");
            
            */
        }
    }
}