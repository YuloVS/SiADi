namespace SiADi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorregidoArea : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Areas", "AreaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Areas", "AreaId", c => c.Int(nullable: false));
        }
    }
}
