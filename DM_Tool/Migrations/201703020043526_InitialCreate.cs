namespace DM_Tool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Monsters",
                c => new
                    {
                        monsterID = c.Int(nullable: false, identity: true),
                        monsterName = c.String(nullable: false, maxLength: 25),
                        monsterHP = c.Int(nullable: false),
                        monsterDamage = c.String(nullable: false, maxLength: 25),
                        experience = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.monsterID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        playerID = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 25),
                        race = c.String(nullable: false, maxLength: 25),
                        level = c.Int(nullable: false),
                        hitpoints = c.Int(nullable: false),
                        accuracy = c.Int(nullable: false),
                        strength = c.Int(nullable: false),
                        dexterity = c.Int(nullable: false),
                        concentration = c.Int(nullable: false),
                        intelligence = c.Int(nullable: false),
                        wisdom = c.Int(nullable: false),
                        charisma = c.Int(nullable: false),
                        initiative = c.String(nullable: false, maxLength: 10),
                        speed = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.playerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
            DropTable("dbo.Monsters");
        }
    }
}
