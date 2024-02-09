using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Parking_Spot
    {
        public VehicleSize SpotSize { get; set; }
        public Vehicle Vehicle { get; set; }
        public bool IsOccupied => Vehicle != null;

        public Parking_Spot(VehicleSize spotSize)
        {
            SpotSize = spotSize;
        }
        public bool Park(Vehicle vehicle)
        {
            if (IsOccupied) return false;

            if (vehicle.CanFitInSpot(this))
            {
                Vehicle = vehicle;
                return true;
            }

            return false;
        }
        public void FindParkingSpots()
        {


        }

        public void RemoveVehicle()
        {
            Vehicle = null;
        }

    }
}

