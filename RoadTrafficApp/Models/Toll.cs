using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoadTrafficApp.Models
{
    public class Toll
    {
        private ICollection<Vehicle> _vehicles;

        public Toll()
        {
            _vehicles = new List<Vehicle>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Vehicle> Vehicles
        {
            get { return _vehicles; }
            set { _vehicles = value; }
        }
    }
}