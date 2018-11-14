using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutboleAR.Models
{
    public class MatchModels
    {
        public String Nombre { get; set; }
        public DateTime FechaHora { get; set; }
        //public List<CanchaModels> Cancha { get; set; }
        public CanchaModels cancha { get; set; }
    }
}