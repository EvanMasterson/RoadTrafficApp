using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoadTrafficApp.Models
{
    public class TollDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<VehicleDTO> Vehicles { get; set; }
    }
}