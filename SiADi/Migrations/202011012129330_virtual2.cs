namespace SiADi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class virtual2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Asistencias", "Persona_Id", "dbo.Personas");
            DropIndex("dbo.Asistencias", new[] { "Persona_Id" });
            RenameColumn(table: "dbo.Asistencias", name: "Persona_Id", newName: "PersonaId");
            AlterColumn("dbo.Asistencias", "PersonaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Asistencias", "PersonaId");
            AddForeignKey("dbo.Asistencias", "PersonaId", "dbo.Personas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Asistencias", "PersonaId", "dbo.Personas");
            DropIndex("dbo.Asistencias", new[] { "PersonaId" });
            AlterColumn("dbo.Asistencias", "PersonaId", c => c.Int());
            RenameColumn(table: "dbo.Asistencias", name: "PersonaId", newName: "Persona_Id");
            CreateIndex("dbo.Asistencias", "Persona_Id");
            AddForeignKey("dbo.Asistencias", "Persona_Id", "dbo.Personas", "Id");
        }
    }
}
