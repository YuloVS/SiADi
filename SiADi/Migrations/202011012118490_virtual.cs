namespace SiADi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _virtual : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cargos", "Area_Id", "dbo.Areas");
            DropIndex("dbo.Cargos", new[] { "Area_Id" });
            RenameColumn(table: "dbo.Cargos", name: "Area_Id", newName: "AreaId");
            AlterColumn("dbo.Cargos", "AreaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cargos", "AreaId");
            AddForeignKey("dbo.Cargos", "AreaId", "dbo.Areas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cargos", "AreaId", "dbo.Areas");
            DropIndex("dbo.Cargos", new[] { "AreaId" });
            AlterColumn("dbo.Cargos", "AreaId", c => c.Int());
            RenameColumn(table: "dbo.Cargos", name: "AreaId", newName: "Area_Id");
            CreateIndex("dbo.Cargos", "Area_Id");
            AddForeignKey("dbo.Cargos", "Area_Id", "dbo.Areas", "Id");
        }
    }
}
