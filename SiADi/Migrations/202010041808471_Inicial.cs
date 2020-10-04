namespace SiADi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personas", "Cuil", c => c.Long(nullable: false));
            AlterColumn("dbo.Personas", "Telefono", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "Telefono", c => c.Int(nullable: false));
            AlterColumn("dbo.Personas", "Cuil", c => c.Int(nullable: false));
        }
    }
}
