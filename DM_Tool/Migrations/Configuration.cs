namespace DM_Tool.Migrations
{
    using DAL;
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GMToolDB_Context>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "DM_Tool.Models.GMToolDB_Context";
        }

        protected override void Seed(GMToolDB_Context context)
        {

            context.Players.AddOrUpdate(
                new Players()
                {
                    name = "Rod",
                    race = "human",
                    playerClass= "rogue",
                    level = 1,
                    hitpoints = 3,
                    accuracy = 4,
                    strength = 5,
                    dexterity = 6,
                    concentration = 7,
                    intelligence = 5,
                    wisdom = 9,
                    charisma = 4,
                    initiative = "5fel",
                    speed = "5ft/sec",
                });

            context.Monsters.AddOrUpdate(
                new Monsters()
                {
                    monsterName = "Thor",
                    monsterHP = 500,
                    monsterDamage = "6hppersec",
                    experience = 600,

                });
        }
    }
}
