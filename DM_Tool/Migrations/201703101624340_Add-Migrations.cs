namespace DM_Tool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "playerClass", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "playerClass");
        }
    }
}
