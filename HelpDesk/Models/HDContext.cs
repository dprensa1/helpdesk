﻿using HelpDesk.Infraestructure.ConfigurationModel;
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
        public DbSet<UsuarioPerfil> UsuarioPerfiles { get; set; }

        public HDContext() //: base("HelpDesk")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<HDContext>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<HDContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HDContext>());
        }

        public static HDContext Create()
        {
            return new HDContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUserLogin>().HasKey(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new DepartamentoConfig());
            modelBuilder.Configurations.Add(new DocumentoConfig());
            modelBuilder.Configurations.Add(new SolucionConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new RolConfig());
            modelBuilder.Configurations.Add(new UsuarioPerfilConfig());
            modelBuilder.Configurations.Add(new SolicitudConfig());
            modelBuilder.Configurations.Add(new ClienteConfig());

            //modelBuilder.Entity<UsuarioPerfil>().HasRequired(u => u.Usuario)
            //    .WithOptional(t => t.UsuarioPerfil);

            modelBuilder.Entity<Usuario>().HasOptional(u => u.UsuarioPerfil)
                .WithOptionalPrincipal(t => t.Usuario);
        }
    }
}