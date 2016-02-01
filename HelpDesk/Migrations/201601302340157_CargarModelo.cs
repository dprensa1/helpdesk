namespace HelpDesk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CargarModelo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 16),
                        DepartamentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaId)
                .ForeignKey("dbo.Departamentos", t => t.DepartamentoId, cascadeDelete: true)
                .Index(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Departamentos",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 16),
                        Apellido = c.String(nullable: false, maxLength: 16),
                        AreaId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Departamentos", t => t.AreaId, cascadeDelete: true)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.Tecnicos",
                c => new
                    {
                        TecnicoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 16),
                        Apellido = c.String(nullable: false, maxLength: 16),
                        AreaId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TecnicoId)
                .ForeignKey("dbo.Departamentos", t => t.AreaId, cascadeDelete: true)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 16),
                        Descripcion = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        TecnicoId = c.Int(nullable: false),
                        User = c.String(nullable: false, maxLength: 8),
                        Clave = c.String(nullable: false, maxLength: 16),
                        RolId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Roles", t => t.RolId, cascadeDelete: true)
                .ForeignKey("dbo.Tecnicos", t => t.TecnicoId, cascadeDelete: true)
                .Index(t => t.TecnicoId)
                .Index(t => t.User, unique: true, name: "UserIDX")
                .Index(t => t.RolId);
            
            CreateTable(
                "dbo.Solicitudes",
                c => new
                    {
                        SolicitudId = c.Int(nullable: false, identity: true),
                        FechaCreacion = c.DateTime(nullable: false, storeType: "date"),
                        ClienteId = c.Int(nullable: false),
                        Asunto = c.String(nullable: false, maxLength: 32),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        CategoriaId = c.Int(nullable: false),
                        TecnicoId = c.Int(nullable: false),
                        SolucionId = c.Int(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false, storeType: "date"),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SolicitudId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: false)
                .ForeignKey("dbo.Soluciones", t => t.SolucionId, cascadeDelete: true)
                .ForeignKey("dbo.Tecnicos", t => t.TecnicoId, cascadeDelete: false)
                .Index(t => t.ClienteId)
                .Index(t => t.CategoriaId)
                .Index(t => t.TecnicoId)
                .Index(t => t.SolucionId);
            
            CreateTable(
                "dbo.Soluciones",
                c => new
                    {
                        SolucionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 16),
                        Detalle = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.SolucionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solicitudes", "TecnicoId", "dbo.Tecnicos");
            DropForeignKey("dbo.Solicitudes", "SolucionId", "dbo.Soluciones");
            DropForeignKey("dbo.Solicitudes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Solicitudes", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.Usuarios", "TecnicoId", "dbo.Tecnicos");
            DropForeignKey("dbo.Usuarios", "RolId", "dbo.Roles");
            DropForeignKey("dbo.Tecnicos", "AreaId", "dbo.Departamentos");
            DropForeignKey("dbo.Clientes", "AreaId", "dbo.Departamentos");
            DropForeignKey("dbo.Categorias", "DepartamentoId", "dbo.Departamentos");
            DropIndex("dbo.Solicitudes", new[] { "SolucionId" });
            DropIndex("dbo.Solicitudes", new[] { "TecnicoId" });
            DropIndex("dbo.Solicitudes", new[] { "CategoriaId" });
            DropIndex("dbo.Solicitudes", new[] { "ClienteId" });
            DropIndex("dbo.Usuarios", new[] { "RolId" });
            DropIndex("dbo.Usuarios", "UserIDX");
            DropIndex("dbo.Usuarios", new[] { "TecnicoId" });
            DropIndex("dbo.Tecnicos", new[] { "AreaId" });
            DropIndex("dbo.Clientes", new[] { "AreaId" });
            DropIndex("dbo.Categorias", new[] { "DepartamentoId" });
            DropTable("dbo.Soluciones");
            DropTable("dbo.Solicitudes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
            DropTable("dbo.Tecnicos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Departamentos");
            DropTable("dbo.Categorias");
        }
    }
}
