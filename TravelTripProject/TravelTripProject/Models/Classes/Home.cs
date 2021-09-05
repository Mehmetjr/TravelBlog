using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Home
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
    }
}