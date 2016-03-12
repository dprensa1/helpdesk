using HelpDesk.Infraestructure.ConfigurationModel;
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
        public DbSet<Empleado> Clientes { get; set; }

        public HDContext() //: base("HelpDesk")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<HDContext>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<HDContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HDContext>());
        }

        public static HDContext Create()
        {
            return new HDContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new DepartamentoConfig());
            modelBuilder.Configurations.Add(new DocumentoConfig());
            modelBuilder.Configurations.Add(new RolConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new TecnicoConfig());
            modelBuilder.Configurations.Add(new SolucionConfig());
            modelBuilder.Configurations.Add(new SolicitudConfig());

            modelBuilder.Entity<IdentityUserLogin>().HasKey(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            //modelBuilder.Entity<Usuario>()
            //    .HasMany(r => r.Roles)
            //    .WithMany(u => u.Usuarios)
            //    .Map(m =>
            //    {
            //        m.ToTable("UsuariosRoles");
            //        m.MapLeftKey("UsuarioId");
            //        m.MapRightKey("RolId");
            //    });

            //modelBuilder.Entity<Usuario>()
            //    .HasMany(r => r.Departamentos)
            //    .WithMany(u => u.Usuarios)
            //    .Map(m =>
            //    {
            //        m.ToTable("UsuariosDepartamentos");
            //        m.MapLeftKey("UsuarioId");
            //        m.MapRightKey("DepartamentoId");
            //    });

            //modelBuilder.Entity<Cliente>()
            //    .HasMany(d => d.Departamentos)
            //    .WithMany(c => c.Clientes)
            //    .Map(m =>
            //    {
            //        m.ToTable("ClientesDepartamentos");
            //        m.MapLeftKey("ClienteId");
            //        m.MapRightKey("DepartamentoId");
            //    });



            /*
            modelBuilder.Entity<IdentityUser>()
                .ToTable("Usuarios");
            modelBuilder.Entity<ApplicationUser>()
                .ToTable("Usuarios");
            */
        }
    }
}