using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FutboleAR.Models
{
    public class MatchModels 
    {
        [Key]
        public int ID { get; set; }
        public DateTime FechaHora { get; set; }
        public List<UserModels> Usuarios { get; set; }
        public CanchaModels Cancha { get; set; }
    }
    /*
    public class MatchDBContext : DbContext
    {
        public DbSet<MatchModels> Matches { get; set; }
    }*/
}