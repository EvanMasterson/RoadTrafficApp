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
        private ICollection<Toll> _tolls;

        public Vehicle()
        {
            _tolls = new List<Toll>();
        }

        public int VehicleID { get; set; }
        public int TollID { get; set; }
        public string VehicleType { get; set; }
        public string Price { get; set; }

        public virtual ICollection<Toll> Toll
        {
            get { return _tolls;}
            set { _tolls = value; }
        }
    }
}