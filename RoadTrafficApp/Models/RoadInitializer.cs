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
                new Vehicle { TollID=1, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=1, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=1, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=1, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=1, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=1, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=2, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=2, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=2, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=2, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=2, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=2, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=3, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=3, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=3, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=3, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=3, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=3, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=4, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=4, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=4, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=4, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=4, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=4, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=5, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=5, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=5, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=5, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=5, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=5, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=6, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=6, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=6, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=6, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=6, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=6, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=7, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=7, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=7, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=7, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=7, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=7, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=8, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=8, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=8, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=8, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=8, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=8, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=9, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=9, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=9, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=9, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=9, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=9, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=10, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=10, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=10, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=10, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=10, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=10, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=11, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=11, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=11, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=11, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=11, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=11, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 },
                new Vehicle { TollID=12, VehicleType="Motorcycle", Price=1.00 },
                new Vehicle { TollID=12, VehicleType="Motor Car", Price=1.00 },
                new Vehicle { TollID=12, VehicleType="Buses or Coach", Price=1.00 },
                new Vehicle { TollID=12, VehicleType="Goods Vehicle with a design gross vehicle weight not exceeding 3,500 kilograms", Price=1.00 },
                new Vehicle { TollID=12, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 2 or 3 axles", Price=1.00 },
                new Vehicle { TollID=12, VehicleType="Goods Vehicles with a design gross vehicle weight exceeding 3,500 kilograms and having 4 or more axles", Price=1.00 }
            };
            vehicles.ForEach(t => context.Vechicles.Add(t));
            context.SaveChanges();


        }
    }
}