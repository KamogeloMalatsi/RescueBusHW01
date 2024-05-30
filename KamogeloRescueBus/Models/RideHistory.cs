using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KamogeloRescueBus.Models
{
    public class RideHistory
    {
        public string bookingID { get; set; }
        public string DriverName { get; set; }
        public string VehicleType { get; set; }
        public string PickUpAddress { get; set; }
        public int BookingType { get; set; }
        public string RideDate { get; set; }
    }
}