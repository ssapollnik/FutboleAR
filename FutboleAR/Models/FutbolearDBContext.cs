using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FutboleAR.Models
{
    public class FutbolearDBContext : DbContext
    {
        public DbSet<UserModels> Users { get; set; }
        public DbSet<MatchModels> Matches { get; set; }
        public DbSet<CanchaModels> Canchas { get; set; }
    }
}