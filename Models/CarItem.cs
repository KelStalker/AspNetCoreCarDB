using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCarDB.Models
{ 
    public class CarItem
    {
        public Guid ID { get; set; }
        public bool OwnsCar { get; set; }
        [Required]
        public string CarModel { get; set; }    // eg: Aventador
        [Required]
        public string CarMake { get; set; }     // eg: Lamborghini
        public int? CarYear { get; set; }       // a 4 digit intenger depicting the year
        // note the year is not required and can be void so the type is followed by a '?'
    }   // From Page 23
}

