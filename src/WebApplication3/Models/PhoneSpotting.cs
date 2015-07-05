using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class PhoneSpotting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhoneSpottingId { get; set; }
        public DateTime SpotTime { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public string PhoneManufacturer { get; set; }
        public string PhoneModel { get; set; }
        public string Notes { get; set; }
    }
}
