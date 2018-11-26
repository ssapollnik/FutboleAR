using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FutboleAR.Models
{
    public class CanchaModels 
    {
        [Key]
        public int ID { get; set; }
        public String CanchaNombre { get; set; }
        public String Direccion { get; set; }
        public int Capacidad { get; set; }
    }
    /*
    public class CanchahDBContext : DbContext
    {
        public DbSet<CanchaModels> Canchas { get; set; }
    }*/
}