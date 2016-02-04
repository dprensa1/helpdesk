namespace HelpDesk.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<HelpDesk.Models.HDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HDContext context)
        {
            /*
            context.Usuarios.Add(
                new Usuario
                { 
                    Nombre = "Jose",
                    Apellido = "Perez",
                    UserName = "jperez",
                    Clave = "123456",
                    Departamentos = {
                        new Departamento
                        {
                            Nombre = "Desarrollo",
                            FechaCreacion = DateTime.Today,
                        }
                    },
                    Roles = {
                        new Rol {
                            Nombre = "admin",
                            Descripcion = "Testing",
                        }
                    },
                    Estado = true

                });

            //*/
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
