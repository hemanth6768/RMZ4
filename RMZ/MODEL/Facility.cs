using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMZ.MODEL
{
    public class Facility
    {
        [Key]
        public int  FacilityId { get; set; }

        public  string Facilityname { get; set; }

        //[ForeignKey("Cityid")]
        //public int Cityid { get; set; } 
        //public int cityId { get; set; } 
        public City City { get; set; }

        //public ICollection<City> city { get; set; }

        public List<Building> buildings { get; set; }

       
    }
}
