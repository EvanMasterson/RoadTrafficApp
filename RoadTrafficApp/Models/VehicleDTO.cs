using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoadTrafficApp.Models
{
    public class VehicleDTO
    {
        public int VehicleID { get; set; }
        public int TollID { get; set; }
        public string VehicleType { get; set; }
        public string Price { get; set; }

        public List<TollDTO> Toll { get; set; }
    }
}