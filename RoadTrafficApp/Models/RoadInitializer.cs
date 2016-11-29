using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RoadTrafficApp.Models;

namespace RoadTrafficApp.Models
{
    public class RoadInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RoadContext>
    {
        protected override void Seed(RoadContext context)
        {
            var tolls = new List<Toll>
            {
                new Toll { Name="M50 Barrier Free Toll", Location="Between Junction 6 (M50/N3 Blanchardstown) and Junction 7 (M50/N4 Lucan)"},
                new Toll { Name="M1 (Gormanston to Monasterboice)", Location="Between Junction 7 (Julianstown) and Junction 10 (Drogheda North)"},
                new Toll { Name="M3 Clonee-Kells (Clonee-Dunshaughlin)", Location="Between Junction 5 (Dunboyne) and Junction 6 (Dunshaughlin)"},
                new Toll { Name="M3 Clonee-Kells (Navan-Kells)", Location="Between Junction 9 (Navan North) and Junction 10 (Kells)"},
                new Toll { Name="M4 (Kilcock-Enfield-Kinnegad)", Location="Between Junction 8 (Kilcock) and Junction 10 (Kinnegad east)"},
                new Toll { Name="N6 (Galway to Ballinasloe)", Location="Between junction 15 (Ballinasloe West) and junction 16 (Loughrea)"},
                new Toll { Name="M7/M8 (Portlaoise - Castletown/ Portlaoise - Cullahill)", Location="Between Junction 18 (Portlaoise west) and Junction 21 (Borris-In-Ossory) and Between Junction 3 (Rathdowney) on the M8 and Junction 18 (Portlaoise West) on the M7"},
                new Toll { Name="N8 (Rathcormac - Fermoy Bypass)", Location="Between Junctions 15 (Fermoy South) and Junction 17 (Watergrasshill)"},
                new Toll { Name="N25 (Waterford City Bypass)", Location="Between the Junction for the M9/N24 and the Junction for R710"},
                new Toll { Name="East-Link Bridge", Location="Located in the Docklands linking the North Wall to Ringsend"},
                new Toll { Name="Dublin Tunnel", Location="Between M1 Dublin-Belfast motorway and the M50 to Dublin Port"},
                new Toll { Name="Limerick Tunnel", Location="Between Junction 2 and Junction 4"}
            };
            tolls.ForEach(t => context.Tolls.Add(t));
            //context.SaveChanges();

            var vehicles = new List<Vehicle>
            {
                new Vehicle { TollID=1, VehicleType="Motor Cars and public service vehicles with seating for up to 8 passengers", Price="Tag Account - €2.10, Video Account - €2.60, Unregistered - €3.10" },
                new Vehicle { TollID=1, VehicleType="Goods vehicles with an unladen weight not exceeding 2,000kg Buses or coaches with seating for more than 8 passengers", Price="Tag Account - €2.90, Video Account - €3.40, Unregistered - €3.90" },
                new Vehicle { TollID=1, VehicleType="Goods vehicles with an unladen weight exceeding 2,000kg but not exceeding 10,000kg", Price="Tag Account - €4.20, Video Account - €4.70, Unregistered - €5.30" },
                new Vehicle { TollID=1, VehicleType="Goods vehicles with an unladen weight exceeding 10,000kg", Price="Tag Account - €5.30, Video Account - €5.80, Unregistered - €6.30" },
                new Vehicle { TollID=2, VehicleType="Motorcycle", Price="€1.00" },
                new Vehicle { TollID=2, VehicleType="Motor Car", Price="€1.90" },
                new Vehicle { TollID=2, VehicleType="Buses or Coach", Price="€3.40" },
                new Vehicle { TollID=2, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€3.40" },
                new Vehicle { TollID=2, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€4.80" },
                new Vehicle { TollID=2, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€6.10" },
                new Vehicle { TollID=3, VehicleType="Motorcycle", Price="€0.70" },
                new Vehicle { TollID=3, VehicleType="Motor Car", Price="€1.40" },
                new Vehicle { TollID=3, VehicleType="Buses or Coach", Price="€2.20" },
                new Vehicle { TollID=3, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€2.20" },
                new Vehicle { TollID=3, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€2.90" },
                new Vehicle { TollID=3, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€3.50" },
                new Vehicle { TollID=4, VehicleType="Motorcycle", Price="€0.70" },
                new Vehicle { TollID=4, VehicleType="Motor Car", Price="€1.40" },
                new Vehicle { TollID=4, VehicleType="Buses or Coach", Price="€2.20" },
                new Vehicle { TollID=4, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€2.20" },
                new Vehicle { TollID=4, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€2.90" },
                new Vehicle { TollID=4, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€3.50" },
                new Vehicle { TollID=5, VehicleType="Motorcycle", Price="€1.50" },
                new Vehicle { TollID=5, VehicleType="Motor Car", Price="€2.90" },
                new Vehicle { TollID=5, VehicleType="Buses or Coach", Price="€4.30" },
                new Vehicle { TollID=5, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€4.30" },
                new Vehicle { TollID=5, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€5.70" },
                new Vehicle { TollID=5, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€7.10" },
                new Vehicle { TollID=6, VehicleType="Motorcycle", Price="€1.00" },
                new Vehicle { TollID=6, VehicleType="Motor Car", Price="€1.90" },
                new Vehicle { TollID=6, VehicleType="Buses or Coach", Price="€3.40" },
                new Vehicle { TollID=6, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€3.40" },
                new Vehicle { TollID=6, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€4.80" },
                new Vehicle { TollID=6, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€6.10" },
                new Vehicle { TollID=7, VehicleType="Motorcycle", Price="€1.00" },
                new Vehicle { TollID=7, VehicleType="Motor Car", Price="€1.90" },
                new Vehicle { TollID=7, VehicleType="Buses or Coach", Price="€3.40" },
                new Vehicle { TollID=7, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€3.40" },
                new Vehicle { TollID=7, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€4.80" },
                new Vehicle { TollID=7, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€6.10" },
                new Vehicle { TollID=8, VehicleType="Motorcycle", Price="€1.00" },
                new Vehicle { TollID=8, VehicleType="Motor Car", Price="€1.90" },
                new Vehicle { TollID=8, VehicleType="Buses or Coach", Price="€3.40" },
                new Vehicle { TollID=8, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€3.40" },
                new Vehicle { TollID=8, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€4.80" },
                new Vehicle { TollID=8, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€6.10" },
                new Vehicle { TollID=9, VehicleType="Motorcycle", Price="€1.00" },
                new Vehicle { TollID=9, VehicleType="Motor Car", Price="€1.90" },
                new Vehicle { TollID=9, VehicleType="Buses or Coach", Price="€3.40" },
                new Vehicle { TollID=9, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€3.40" },
                new Vehicle { TollID=9, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€4.80" },
                new Vehicle { TollID=9, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€6.10" },
                new Vehicle { TollID=10, VehicleType="Motorcycle", Price="Free" },
                new Vehicle { TollID=10, VehicleType="Motor Car", Price="€1.75" },
                new Vehicle { TollID=10, VehicleType="Buses or Coach", Price="€2.60" },
                new Vehicle { TollID=10, VehicleType="Commercial Vehicles with an unladen weight not exceeding 2 tonnes", Price="€2.60" },
                new Vehicle { TollID=10, VehicleType="Commercial Vehicles exceeding 2 tonnes unladen weight and with not more than 2 axles", Price="€3.50" },
                new Vehicle { TollID=10, VehicleType="Commercial Vehicles exceeding 2 tonnes unladen weight and with not more than 3 axles", Price="€4.30" },
                new Vehicle { TollID=10, VehicleType="Commercial Vehicles exceeding 2 tonnes unladen weight and with more than 4 or more axles", Price="€5.20" },
                new Vehicle { TollID=11, VehicleType="Southbound Direction"},
                new Vehicle { TollID=11, VehicleType="Between 6am - 10am Monday to Friday", Price="€10.00" },
                new Vehicle { TollID=11, VehicleType="All other times", Price="€3.00" },
                new Vehicle { TollID=11, VehicleType="Northbound Direction"},
                new Vehicle { TollID=11, VehicleType="Between 4pm - 7pm Monday to Friday", Price="€10.00" },
                new Vehicle { TollID=11, VehicleType="All other times", Price="€3.00" },
                new Vehicle { TollID=11, VehicleType="Goods vehicles with a design gross vehicle weight exceeding 3,500 kilograms", Price="Exempt from tolls" },
                new Vehicle { TollID=12, VehicleType="Motor Car", Price="€1.90" },
                new Vehicle { TollID=12, VehicleType="Buses or Coach", Price="€3.40" },
                new Vehicle { TollID=12, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price="€3.40" },
                new Vehicle { TollID=12, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price="€4.80" },
                new Vehicle { TollID=12, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price="€6.10" }
            };
            vehicles.ForEach(t => context.Vechicles.Add(t));
            context.SaveChanges();


        }
    }
}