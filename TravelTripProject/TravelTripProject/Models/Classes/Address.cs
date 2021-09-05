using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string Address1 { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

    }
}