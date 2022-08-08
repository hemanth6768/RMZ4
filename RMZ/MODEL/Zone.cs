using System.ComponentModel.DataAnnotations;

namespace RMZ.MODEL
{
    public class Zone
    {
        public Building Building { get; set; }

        public Facility Facility { get; set; }
        public string Floornumber { get; set; }
        [Key]
        public string ZoneId { get; set; }


        public decimal Eletricmeter { get; set; }   

        public decimal watermeteer { get; set; }

    }
}
