namespace SiADi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bajaagregada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Areas", "baja", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cargos", "baja", c => c.Boolean(nullable: false));
            AddColumn("dbo.Asistencias", "baja", c => c.Boolean(nullable: false));
            AddColumn("dbo.Personas", "baja", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personas", "baja");
            DropColumn("dbo.Asistencias", "baja");
            DropColumn("dbo.Cargos", "baja");
            DropColumn("dbo.Areas", "baja");
        }
    }
}
