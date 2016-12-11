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
            vehicles.ForEach(v => context.Vechicles.Add(v));


            var tolls = new List<Toll>
            {
                new Toll { Name="M50 Barrier Free Toll", Location="Between Junction 6 (M50/N3 Blanchardstown) and Junction 7 (M50/N4 Lucan)", Vehicles = vehicles.Where(v => (v.TollID == 1)).ToList()},
                new Toll { Name="M1 (Gormanston to Monasterboice)", Location="Between Junction 7 (Julianstown) and Junction 10 (Drogheda North)", Vehicles = vehicles.Where(v => (v.TollID == 2)).ToList()},
                new Toll { Name="M3 Clonee-Kells (Clonee-Dunshaughlin)", Location="Between Junction 5 (Dunboyne) and Junction 6 (Dunshaughlin)", Vehicles = vehicles.Where(v => (v.TollID == 3)).ToList()},
                new Toll { Name="M3 Clonee-Kells (Navan-Kells)", Location="Between Junction 9 (Navan North) and Junction 10 (Kells)", Vehicles = vehicles.Where(v => (v.TollID == 4)).ToList()},
                new Toll { Name="M4 (Kilcock-Enfield-Kinnegad)", Location="Between Junction 8 (Kilcock) and Junction 10 (Kinnegad east)", Vehicles = vehicles.Where(v => (v.TollID == 5)).ToList()},
                new Toll { Name="N6 (Galway to Ballinasloe)", Location="Between junction 15 (Ballinasloe West) and junction 16 (Loughrea)", Vehicles = vehicles.Where(v => (v.TollID == 6)).ToList()},
                new Toll { Name="M7/M8 (Portlaoise - Castletown/ Portlaoise - Cullahill)", Location="Between Junction 18 (Portlaoise west) and Junction 21 (Borris-In-Ossory) and Between Junction 3 (Rathdowney) on the M8 and Junction 18 (Portlaoise West) on the M7", Vehicles = vehicles.Where(v => (v.TollID == 7)).ToList()},
                new Toll { Name="N8 (Rathcormac - Fermoy Bypass)", Location="Between Junctions 15 (Fermoy South) and Junction 17 (Watergrasshill)", Vehicles = vehicles.Where(v => (v.TollID == 8)).ToList()},
                new Toll { Name="N25 (Waterford City Bypass)", Location="Between the Junction for the M9/N24 and the Junction for R710", Vehicles = vehicles.Where(v => (v.TollID == 9)).ToList()},
                new Toll { Name="East-Link Bridge", Location="Located in the Docklands linking the North Wall to Ringsend", Vehicles = vehicles.Where(v => (v.TollID == 10)).ToList()},
                new Toll { Name="Dublin Tunnel", Location="Between M1 Dublin-Belfast motorway and the M50 to Dublin Port", Vehicles = vehicles.Where(v => (v.TollID == 11)).ToList()},
                new Toll { Name="Limerick Tunnel", Location="Between Junction 2 and Junction 4", Vehicles = vehicles.Where(v => (v.TollID == 12)).ToList()}
            };
            tolls.ForEach(t => context.Tolls.Add(t));

            var petrolstations = new List<PetrolStation>
            {
                new PetrolStation { Name="Maxol", Location="Harold's Cross, Dublin 6W", Petrol="127.7c", Diesel="118.7c" },
                new PetrolStation { Name="Applegreen", Location="Grange Road, Baldoyle, Dublin 13", Petrol="129.8c", Diesel="119.8c" },
                new PetrolStation { Name="Esso", Location="Kimmage Road Lower, Dublin 12", Petrol="129.9c", Diesel="120.9c" },
                new PetrolStation { Name="Tesco", Location="Dundrum Town Centre, Dublin 14", Petrol="127.7c", Diesel="117.7c" },
                new PetrolStation { Name="Texaco", Location="Rathfarnham Road, Dublin 14", Petrol="129.7c", Diesel="120.7c" },
                new PetrolStation { Name="Topaz", Location="Nutgrove Shopping Centre, Rathfarnham, Dublin 14", Petrol="131.9c", Diesel="122.9c" },
                new PetrolStation { Name="Maxol", Location="Tymon Road, Tallaght, Dublin 24", Petrol="130.9c", Diesel="121.9c" },
                new PetrolStation { Name="Topaz", Location="Butterfield Avenue, Rathfarnham, Dublin 14", Petrol="133.9c", Diesel="123.9c" },
                new PetrolStation { Name="Topaz", Location="Ushers Quay, Dublin 8", Petrol="127.9c", Diesel="117.9c" },
                new PetrolStation { Name="Applegreen", Location="Ballyfermot Road, Dublin 10", Petrol="130.8c", Diesel="120.8c" }
            };
            petrolstations.ForEach(p => context.PetrolStations.Add(p));

            var garages = new List<Garage>
            {
                new Garage { Name="Fitzwilliam Garage", Location="8 Hagans Court, Off Lower Baggot Street, Dublin 2" },
                new Garage { Name="Bedford Motors", Location="60A Beaumont Ave, Churchtown Upper, Dublin 14" },
                new Garage { Name="Mulligan's Garage", Location="17 Synge Lane Dublin 8" },
                new Garage { Name="Kelly's Garage", Location="13a Mountpleasant Ave Lower, Dublin Southside, Rathmines, Co. Dublin" },
                new Garage { Name="Sweeneys Garage Tallaght", Location="6 Old Belgard Road, Tallaght, Co. Dublin" },
                new Garage { Name="Hillside Garage Servicing and Repairs", Location="A3, South City Business Park, Oldbawn, Dublin 24" },
                new Garage { Name="O'Brien Garage", Location="39 Herbert Ln, Grand Canal Dock, Dublin" },
                new Garage { Name="Dorset Expert Garage", Location="59 Dorset Street Lower, Inns Quay, Dublin" },
                new Garage { Name="Sean Kavanagh's Garage", Location="Fonthill Rd, Ronanstown, Clondalkin, Co. Dublin" },
                new Garage { Name="Stuarts Garage - Land Rover", Location="24, Greenhills Rd, Dublin 24" }
            };
            garages.ForEach(g => context.Garages.Add(g));
            context.SaveChanges();

        }
    }
}