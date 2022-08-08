using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMZ.MODEL
{
    public class Building
    {
        [Key]
        public int Bid { get; set; }
        public string BuildingName { get; set; } 

        public Facility Facility { get; set; }

        public List<Zone> zones { get; set; }
    }
}
    