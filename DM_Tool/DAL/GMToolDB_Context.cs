using System.Data.Entity;
using DM_Tool.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DM_Tool.DAL
{
    public class GMToolDB_Context : DbContext
    {
        public GMToolDB_Context(): base("DefaultConnection")
        {

        }

        public DbSet<Players> Players { get; set; }
        public DbSet<Monsters> Monsters { get; set; }

    }
}