using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DM_Tool.Models
{
    public class GMToolDB_Context : DbContext
    {
        public DbSet<Players> Players { get; set; }
        public DbSet<Monsters> Monsters { get; set; }

    }
}