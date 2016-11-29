using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoadTrafficApp.Models
{
    public class Vehicle
    {
        [Key]
        public int Toll_ID { get; set; }
        public string VehicleType { get; set; }
        public double Price { get; set; }

        public virtual Toll Toll { get; set; }
    }
}