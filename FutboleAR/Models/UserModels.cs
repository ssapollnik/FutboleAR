using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FutboleAR.Models
{
    public class UserModels
    {
        [Key]
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
    }
    /*
    public class UserDBContext : DbContext
    {
        public DbSet<UserModels> Users { get; set; }
    }*/
}