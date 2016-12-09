using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoadTrafficApp.Models
{
    public class TollDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<VehicleDTO> Vehicle { get; set; }
    }
}