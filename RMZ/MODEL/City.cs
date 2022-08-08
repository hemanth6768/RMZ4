using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RMZ.MODEL
{
    public class City
    {
        
        [Key]
        public int Cityid { get; set; } 
        public string CityName { get; set; }

        
        // public List<Facility> facility { get; set; }
        //public Facility falclity { get; set; }

        public List<Facility> facilities { get; set; }

    }
}
