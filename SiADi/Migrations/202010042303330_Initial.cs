namespace SiADi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cargos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Salario = c.Double(nullable: false),
                        Horario_entrada = c.DateTime(nullable: false),
                        Horario_salida = c.DateTime(nullable: false),
                        Area_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.Area_Id)
                .Index(t => t.Area_Id);
            
            CreateTable(
                "dbo.Asistencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        Tipo = c.Boolean(nullable: false),
                        Persona_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.Persona_Id)
                .Index(t => t.Persona_Id);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dni = c.Int(nullable: false),
                        Cuil = c.Long(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Fecha_nacimiento = c.DateTime(nullable: false),
                        Edad = c.Int(nullable: false),
                        Direccion = c.String(),
                        Telefono = c.Long(nullable: false),
                        Codigo_qr = c.String(),
                        Foto = c.String(),
                        Contraseña = c.String(),
                        Cargo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cargos", t => t.Cargo_Id)
                .Index(t => t.Cargo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personas", "Cargo_Id", "dbo.Cargos");
            DropForeignKey("dbo.Asistencias", "Persona_Id", "dbo.Personas");
            DropForeignKey("dbo.Cargos", "Area_Id", "dbo.Areas");
            DropIndex("dbo.Personas", new[] { "Cargo_Id" });
            DropIndex("dbo.Asistencias", new[] { "Persona_Id" });
            DropIndex("dbo.Cargos", new[] { "Area_Id" });
            DropTable("dbo.Personas");
            DropTable("dbo.Asistencias");
            DropTable("dbo.Cargos");
            DropTable("dbo.Areas");
        }
    }
}
