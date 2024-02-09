using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Vehicle
    {
        protected string plateNr {get; set;}

        protected int SpotsNeeded { get; set; }
        protected VehicleSize Size { get; set; }

        public virtual bool CanFitInSpot(Parking_Spot spot)
        {
            return false;
        }
    }
    public enum VehicleSize
    {
        //for Motorcycle
        Small,
        //for Car
        Large,

    }
    public class Car : Vehicle
    {
        public Car(string licensePlate)
        {
            Size = VehicleSize.Large;
            plateNr = licensePlate;
            SpotsNeeded = 1;

        }

        public override bool CanFitInSpot(Parking_Spot spot)
        {
            return spot.SpotSize == VehicleSize.Large;
        }

    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(string licensePlate)
        {
            Size = VehicleSize.Small;
            plateNr = licensePlate;
            SpotsNeeded = 1;
        }
        public override bool CanFitInSpot(Parking_Spot spot)
        {
            return spot.SpotSize == VehicleSize.Small;
        }
    }
}
