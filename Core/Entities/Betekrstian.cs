using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Betekrstian :BaseEntitiy
    {
         public string betekrstianName { get; set; }
        public double longtiude { get; set; }
        public double latitude { get; set; }
        public HagereSibket HagereSibket { get; set; }
       public int HagereSibketId { get; set; }
       public Region Region { get; set; }
       public int RegionId { get; set; }
    }
}