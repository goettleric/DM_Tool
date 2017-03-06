using System.Data.Entity;
using DM_Tool.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DM_Tool.Models
{
    public class GMToolDB_Context : DbContext
    {
        public GMToolDB_Context(): base("GMToolDB_Context")
        {

        }

        public DbSet<Players> Players { get; set; }
        public DbSet<Monsters> Monsters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}