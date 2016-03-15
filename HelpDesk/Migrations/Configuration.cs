namespace HelpDesk.Migrations
{
    using FizzWare.NBuilder;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    internal sealed class Configuration : DbMigrationsConfiguration<HDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HDContext context)
        {
            var Categoria = Builder<Categoria>.CreateListOfSize(25)
                /*.All()
                .With(c => c.Nombre = Faker.NameFaker.Name())
                .With(c => c.CreadoEn = Faker.DateTimeFaker.DateTime())
                .With(c => c.CreadoPor = Faker.NameFaker.Name())
                .With(c => c.CreadoEn = Faker.DateTimeFaker.DateTime())
                .With(c => c.ModificadoPor = Faker.NameFaker.Name())*/
                .Build();

            var Departamento = Builder<Departamento>.CreateListOfSize(25)
                /*.All()
                .With(c => c.Nombre = Faker.NameFaker.Name())
                .With(c => c.Ubicacion = Faker.LocationFaker.Street())
                .With(c => c.CreadoEn = Faker.DateTimeFaker.DateTime())
                .With(c => c.CreadoPor = Faker.NameFaker.Name())
                .With(c => c.CreadoEn = Faker.DateTimeFaker.DateTime())
                .With(c => c.ModificadoPor = Faker.NameFaker.Name())*/
                .Build();

            var Solicitud = Builder<Solicitud>.CreateListOfSize(25)
                /*.All()
                .With(c => c.Fecha = Faker.DateTimeFaker.DateTime())
                .With(c => c.Asunto = Faker.TextFaker.Sentence())
                .With(c => c.Descripcion = Faker.TextFaker.Sentences(2))
                .With(c => c.CreadoEn = Faker.DateTimeFaker.DateTime())
                .With(c => c.CreadoPor = Faker.NameFaker.Name())
                .With(c => c.CreadoEn = Faker.DateTimeFaker.DateTime())
                .With(c => c.ModificadoPor = Faker.NameFaker.Name())*/
                .Build();
            var Cliente = Builder<Cliente>.CreateListOfSize(25).Build();
            var UsuarioPerfil = Builder<UsuarioPerfil>.CreateListOfSize(25).Build();
            var Usuario = Builder<Usuario>.CreateListOfSize(25).Build();
            var Documento = Builder<Documento>.CreateListOfSize(25).Build();
            var Solucion = Builder<Solucion>.CreateListOfSize(25).Build();
            var Roles = Builder<Rol>.CreateListOfSize(25).Build();

            context.Categorias.AddOrUpdate(c => c.CategoriaId, Categoria.ToArray());
            context.Departamentos.AddOrUpdate(c => c.DepartamentoId, Departamento.ToArray());
            context.Documentos.AddOrUpdate(c => c.DocumentoId, Documento.ToArray());
            context.Soluciones.AddOrUpdate(c => c.SolucionId, Solucion.ToArray());
            context.Usuarios.AddOrUpdate(c => c.Id, Usuario.ToArray());
            context.Roles.AddOrUpdate(c => c.Id, Roles.ToArray());
            context.UsuarioPerfiles.AddOrUpdate(c => c.UsuarioPerfilId, UsuarioPerfil.ToArray());
            context.Solicitudes.AddOrUpdate(c => c.SolicitudId, Solicitud.ToArray());
            context.Clientes.AddOrUpdate(c => c.ClienteId, Cliente.ToArray());
        }
    }
}
